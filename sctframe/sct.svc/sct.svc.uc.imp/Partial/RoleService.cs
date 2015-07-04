using sct.cm.data;
using sct.dto.uc;
using sct.ent.uc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Collections.Specialized;


namespace sct.svc.uc.imp
{

    public class RoleService : RoleBaseService, IRoleService
    {


        protected RoleFacilityRpt RoleFacilityRpt { get; set; }

        public PageResult<RoleInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {

            PageResult<RoleInfo> result = new PageResult<RoleInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<RoleInfo> list = null;

            using (var DbContext = new UCDbContext())
            {
                var query = from i in DbContext.Role
                            join a in DbContext.App on i.AppId equals a.Id
                            select new RoleInfo()
                            {
                                Id = i.Id,
                                RoleCode = i.RoleCode,
                                RoleName = i.RoleName,
                                AppId = i.AppId,
                                SYS_IsValid = i.SYS_IsValid,
                                SYS_OrderSeq = i.SYS_OrderSeq,
                                SYS_AppId = i.SYS_AppId,
                                SYS_StaffId = i.SYS_StaffId,
                                SYS_StationId = i.SYS_StationId,
                                SYS_DepartmentId = i.SYS_DepartmentId,
                                SYS_CompanyId = i.SYS_CompanyId,
                                SYS_CreateTime = i.SYS_CreateTime,
                                AppName = a.AppName,
                            };


                #region 条件
                foreach (string key in searchCondtionCollection)
                {
                    string condition = searchCondtionCollection[key];
                    switch (key.ToLower())
                    {
                        case "rolename":
                            query = query.Where(x => x.RoleName.Contains(condition));
                            break;
                        case "rolecode":
                            query = query.Where(x => x.RoleCode.Contains(condition));
                            break;
                        case "appid":
                            query = query.Where(x => x.AppId.Equals(condition));
                            break;
                        case "isvalid":
                            int value = Convert.ToInt32(condition);
                            query = query.Where(x => x.SYS_IsValid.Equals(value));
                            break;
                        default:
                            break;
                    }
                }
                #endregion

                result.TotalRecords = query.Count();

                #region 排序
                foreach (string sort in sortCollection)
                {
                    string direct = sortCollection[sort];
                    switch (sort.ToLower())
                    {
                        case "createtime":
                            if (direct.ToLower().Equals("asc"))
                            {
                                query = query.OrderBy(x => new { x.SYS_CreateTime }).Skip(skip).Take(take);
                            }
                            else
                            {
                                query = query.OrderByDescending(x => new { x.SYS_CreateTime }).Skip(skip).Take(take);
                            }
                            break;
                        case "rolename":
                            if (direct.ToLower().Equals("asc"))
                            {
                                query = query.OrderBy(x => x.RoleName).Skip(skip).Take(take);
                            }
                            else
                            {
                                query = query.OrderByDescending(x => x.RoleName).Skip(skip).Take(take);
                            }
                            break;
                        default:
                            query = query.OrderByDescending(x => new { x.SYS_OrderSeq }).Skip(skip).Take(take);
                            break;
                    }
                }
                #endregion
                list = query.ToList();
            }

            result.PageSize = pageSize;
            result.PageNumber = pageNumber;
            result.Data = list;
            return result; ;

        }

        /// <summary>
        /// 重载读取权限信息内容，加载关联的功能列表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public override RoleInfo Load(string key)
        {
            RoleInfo info = new RoleInfo();
            using (var DbContext = new UCDbContext())
            {
                Role entity = RoleRpt.Get(DbContext, key);
                if (info != null)
                {
                    DESwap.RoleETD(entity, info);

                    /*******查询关联权限*******/
                    var fflist = (from i in DbContext.RoleFacility
                                  where i.RoleId.Equals(info.Id)
                                  select i).ToList();
                    info.RoleFacilityInfoList = new List<RoleFacilityInfo>();
                    fflist.ForEach(x =>
                    {
                        RoleFacilityInfo rfinfo = new RoleFacilityInfo();
                        DESwap.RoleFacilityETD(x, rfinfo);
                        info.RoleFacilityInfoList.Add(rfinfo);
                    });
                }

            }
            return info;
        }

        public override OperationResult Create(RoleInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
                Role entity = new Role();
                DESwap.RoleDTE(info, entity);
                RoleRpt.Insert(DbContext, entity);

                /*关联权限是否为空*/
                if (info.RoleFacilityInfoList != null)
                {
                    /*****新增列表*********/
                    List<RoleFacility> insertlist = new List<RoleFacility>();
                    /*****删除列表*********/
                    List<RoleFacility> deletelist = new List<RoleFacility>();

                    /*原有列表*/
                    var existlist = (from i in DbContext.RoleFacility
                                     where i.RoleId.Equals(info.Id)
                                     select i).ToList();

                    /*************如果为选中且没有关联表id则为新增******************/
                    foreach (var rfinfo in info.RoleFacilityInfoList)
                    {
                        if (string.IsNullOrEmpty(rfinfo.Id) && rfinfo.Selected)
                        {
                            /*************如果为选中且没有关联表id则为新增******************/
                            rfinfo.Id = System.Guid.NewGuid().ToString();
                            rfinfo.RoleId = info.Id;
                            RoleFacility roleFacility = new RoleFacility();
                            DESwap.RoleFacilityDTE(rfinfo, roleFacility);
                            insertlist.Add(roleFacility);
                        }
                        else if (!string.IsNullOrEmpty(rfinfo.Id) && rfinfo.Selected == false)
                        {
                            /*************如果为未选中且有关联表id则为删除******************/
                            var roleFacility = existlist.Where(x => x.Id.Equals(rfinfo.Id)).FirstOrDefault();
                            if (roleFacility == null)
                            {
                                deletelist.Add(roleFacility);
                            }
                        }
                    }

                    RoleFacilityRpt.Insert(DbContext, insertlist);
                    RoleFacilityRpt.Delete(DbContext, deletelist);
                }
                DbContext.SaveChanges();

                result.ResultType = OperationResultType.Success;
                result.Message = "操作成功!";
                return result;
            }
        }
        /// <summary>
        /// 重载修改权限信息内容，编辑关承功能列表
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public override OperationResult Modify(RoleInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
                Role entity = RoleRpt.Get(DbContext, info.Id);
                DESwap.RoleDTE(info, entity);
                RoleRpt.Update(DbContext, entity);

                /*关联权限是否为空*/
                if (info.RoleFacilityInfoList != null)
                {
                    /*****新增列表*********/
                    List<RoleFacility> insertlist = new List<RoleFacility>();
                    /*****删除列表*********/
                    List<RoleFacility> deletelist = new List<RoleFacility>();


                    /*原有列表*/
                    var existlist = (from i in DbContext.RoleFacility
                                     where i.RoleId.Equals(info.Id)
                                     select i).ToList();

                    /*************如果为选中且没有关联表id则为新增******************/
                    foreach (var rfinfo in info.RoleFacilityInfoList)
                    {
                        if (string.IsNullOrEmpty(rfinfo.Id) && rfinfo.Selected)
                        {
                            /*************如果为选中且没有关联表id则为新增******************/
                            rfinfo.Id = System.Guid.NewGuid().ToString();
                            rfinfo.RoleId = info.Id;
                            RoleFacility roleFacility = new RoleFacility();
                            DESwap.RoleFacilityDTE(rfinfo, roleFacility);
                            insertlist.Add(roleFacility);
                        }
                        else if (!string.IsNullOrEmpty(rfinfo.Id) && rfinfo.Selected == false)
                        {
                            /*************如果为未选中且有关联表id则为删除******************/
                            var facilityFunction = existlist.Where(x => x.Id.Equals(rfinfo.Id)).FirstOrDefault();
                            if (facilityFunction != null)
                            {
                                deletelist.Add(facilityFunction);
                            }
                        }
                    }

                    RoleFacilityRpt.Insert(DbContext, insertlist);
                    RoleFacilityRpt.Delete(DbContext, deletelist);
                }

                DbContext.SaveChanges();

                result.ResultType = OperationResultType.Success;
                result.Message = "操作成功!";
                return result;
            }

        }
    }

}

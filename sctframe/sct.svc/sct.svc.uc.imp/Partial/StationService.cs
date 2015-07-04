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

    public class StationService : StationBaseService, IStationService
    {
        protected virtual StationRoleRpt StationRoleRpt { get; set; }

        public PageResult<StationInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {
            PageResult<StationInfo> result = new PageResult<StationInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<StationInfo> list = null;

            using (var DbContext = new UCDbContext())
            {
                var query = from i in DbContext.Station
                            join p in DbContext.Station on i.ParentId equals p.Id into parent
                            join d in DbContext.Department on i.DepartmentId equals d.Id
                            join c in DbContext.Company on d.CompanyId equals c.Id
                            from tp in parent.DefaultIfEmpty()
                            select new StationInfo()
                            {
                                Id = i.Id,
                                StationName = i.StationName,
                                DepartmentId = i.DepartmentId,
                                DepartmentName = d.DepartmentName,
                                CompanyId = d.CompanyId,
                                CompanyName = c.CompanyName,
                                ParentId = i.ParentId,
                                SYS_IsValid = i.SYS_IsValid,
                                SYS_OrderSeq = i.SYS_OrderSeq,
                                SYS_AppId = i.SYS_AppId,
                                SYS_StaffId = i.SYS_StaffId,
                                SYS_StationId = i.SYS_StationId,
                                SYS_DepartmentId = i.SYS_DepartmentId,
                                SYS_CompanyId = i.SYS_CompanyId,
                                SYS_CreateTime = i.SYS_CreateTime,
                                ParentName = tp == null ? "" : tp.StationName
                            };


                #region 条件
                foreach (string key in searchCondtionCollection)
                {
                    string condition = searchCondtionCollection[key];
                    switch (key.ToLower())
                    {
                        case "stationname":
                            query = query.Where(x => x.DepartmentName.Contains(condition));
                            break;
                        case "parentid":
                            query = query.Where(x => x.ParentId.Equals(condition));
                            break;
                        case "departmentid":
                            query = query.Where(x => x.DepartmentId.Contains(condition));
                            break;
                        case "companyid":
                            query = query.Where(x => x.CompanyId.Equals(condition));
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
                        case "stationname":
                            if (direct.ToLower().Equals("asc"))
                            {
                                query = query.OrderBy(x => x.CompanyName).Skip(skip).Take(take);
                            }
                            else
                            {
                                query = query.OrderByDescending(x => x.CompanyName).Skip(skip).Take(take);
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
            return result;
        }

        /// <summary>
        /// 重载读取岗位内容，加载关联的功能列表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public override StationInfo Load(string key)
        {
            StationInfo info = new StationInfo();
            using (var DbContext = new UCDbContext())
            {
                Station entity = StationRpt.Get(DbContext, key);
                if (info != null)
                {
                    DESwap.StationETD(entity, info);

                    /*******查询关联权限*******/
                    var fflist = (from i in DbContext.StationRole
                                  where i.StationId.Equals(info.Id)
                                  select i).ToList();
                    info.StationRoleInfoList = new List<StationRoleInfo>();
                    fflist.ForEach(x =>
                    {
                        StationRoleInfo rfinfo = new StationRoleInfo();
                        DESwap.StationRoleETD(x, rfinfo);
                        info.StationRoleInfoList.Add(rfinfo);
                    });
                }

            }
            return info;
        }

        public override OperationResult Create(StationInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
                Station entity = new Station();
                DESwap.StationDTE(info, entity);
                StationRpt.Insert(DbContext, entity);

                /*关联角色是否为空*/
                if (info.StationRoleInfoList != null)
                {
                    /*****新增列表*********/
                    List<StationRole> insertlist = new List<StationRole>();
                    /*****删除列表*********/
                    List<StationRole> deletelist = new List<StationRole>();

                    /*原有列表*/
                    var existlist = (from i in DbContext.StationRole
                                     where i.StationId.Equals(info.Id)
                                     select i).ToList();

                    /*************如果为选中且没有关联表id则为新增******************/
                    foreach (var rfinfo in info.StationRoleInfoList)
                    {
                        if (string.IsNullOrEmpty(rfinfo.Id) && rfinfo.Selected)
                        {
                            /*************如果为选中且没有关联表id则为新增******************/
                            rfinfo.Id = System.Guid.NewGuid().ToString();
                            rfinfo.StationId = info.Id;
                            StationRole StationRole = new StationRole();
                            DESwap.StationRoleDTE(rfinfo, StationRole);
                            insertlist.Add(StationRole);
                        }
                        else if (!string.IsNullOrEmpty(rfinfo.Id) && rfinfo.Selected == false)
                        {
                            /*************如果为未选中且有关联表id则为删除******************/
                            var StationRole = existlist.Where(x => x.Id.Equals(rfinfo.Id)).FirstOrDefault();
                            if (StationRole == null)
                            {
                                deletelist.Add(StationRole);
                            }
                        }
                    }

                    StationRoleRpt.Insert(DbContext, insertlist);
                    StationRoleRpt.Delete(DbContext, deletelist);
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
        public override OperationResult Modify(StationInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
                Station entity = StationRpt.Get(DbContext, info.Id);
                DESwap.StationDTE(info, entity);
                StationRpt.Update(DbContext, entity);

                /*关联角色是否为空*/
                if (info.StationRoleInfoList != null)
                {
                    /*****新增列表*********/
                    List<StationRole> insertlist = new List<StationRole>();
                    /*****删除列表*********/
                    List<StationRole> deletelist = new List<StationRole>();


                    /*原有列表*/
                    var existlist = (from i in DbContext.StationRole
                                     where i.StationId.Equals(info.Id)
                                     select i).ToList();

                    /*************如果为选中且没有关联表id则为新增******************/
                    foreach (var rfinfo in info.StationRoleInfoList)
                    {
                        if (string.IsNullOrEmpty(rfinfo.Id) && rfinfo.Selected)
                        {
                            /*************如果为选中且没有关联表id则为新增******************/
                            rfinfo.Id = System.Guid.NewGuid().ToString();
                            rfinfo.StationId = info.Id;
                            StationRole StationRole = new StationRole();
                            DESwap.StationRoleDTE(rfinfo, StationRole);
                            insertlist.Add(StationRole);
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

                    StationRoleRpt.Insert(DbContext, insertlist);
                    StationRoleRpt.Delete(DbContext, deletelist);
                }

                DbContext.SaveChanges();

                result.ResultType = OperationResultType.Success;
                result.Message = "操作成功!";
                return result;
            }

        }
    }

}

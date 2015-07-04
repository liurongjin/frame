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

    public class FacilityService : FacilityBaseService, IFacilityService
    {
        protected FacilityFunctionRpt FacilityFunctionRpt { get; set; }

        public PageResult<FacilityInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {

            PageResult<FacilityInfo> result = new PageResult<FacilityInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<FacilityInfo> list = null;

            using (var DbContext = new UCDbContext())
            {
                var query = from i in DbContext.Facility
                            join a in DbContext.App on i.AppId equals a.Id
                            select new FacilityInfo()
                            {
                                Id = i.Id,
                                FacilityCode = i.FacilityCode,
                                FacilityName = i.FacilityName,
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
                        case "facilityname":
                            query = query.Where(x => x.FacilityName.Contains(condition));
                            break;
                        case "facilitycode":
                            query = query.Where(x => x.FacilityCode.Contains(condition));
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
                        case "facilityname":
                            if (direct.ToLower().Equals("asc"))
                            {
                                query = query.OrderBy(x => x.FacilityName).Skip(skip).Take(take);
                            }
                            else
                            {
                                query = query.OrderByDescending(x => x.FacilityName).Skip(skip).Take(take);
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
        public override FacilityInfo Load(string key)
        {
            FacilityInfo info = new FacilityInfo();
            using (var DbContext = new UCDbContext())
            {
                Facility entity = FacilityRpt.Get(DbContext, key);
                if (info != null)
                {
                    DESwap.FacilityETD(entity, info);

                    /*******查询关联权限*******/
                    var fflist = (from i in DbContext.FacilityFunction
                                  where i.FacilityId.Equals(info.Id)
                                  select i).ToList();
                    info.FacilityFunctionInfoList = new List<FacilityFunctionInfo>();
                    fflist.ForEach(x =>
                    {
                        FacilityFunctionInfo ffinfo = new FacilityFunctionInfo();
                        DESwap.FacilityFunctionETD(x, ffinfo);
                        info.FacilityFunctionInfoList.Add(ffinfo);
                    });
                }

            }
            return info;
        }

        public override OperationResult Create(FacilityInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
                Facility entity = new Facility();
                DESwap.FacilityDTE(info, entity);
                FacilityRpt.Insert(DbContext, entity);

                /*关联功能是否为空*/
                if (info.FacilityFunctionInfoList != null)
                {
                    /*****新增列表*********/
                    List<FacilityFunction> insertlist = new List<FacilityFunction>();
                    /*****删除列表*********/
                    List<FacilityFunction> deletelist = new List<FacilityFunction>();

                    /*原有列表*/
                    var existlist = (from i in DbContext.FacilityFunction
                                     where i.FacilityId.Equals(info.Id)
                                     select i).ToList();

                    /*************如果为选中且没有关联表id则为新增******************/
                    foreach (var ffinfo in info.FacilityFunctionInfoList)
                    {
                        if (string.IsNullOrEmpty(ffinfo.Id) && ffinfo.Selected)
                        {
                            /*************如果为选中且没有关联表id则为新增******************/
                            ffinfo.Id = System.Guid.NewGuid().ToString();
                            ffinfo.FacilityId = info.Id;
                            FacilityFunction facilityFunction = new FacilityFunction();
                            DESwap.FacilityFunctionDTE(ffinfo, facilityFunction);
                            insertlist.Add(facilityFunction);
                        }
                        else if (!string.IsNullOrEmpty(ffinfo.Id) && ffinfo.Selected == false)
                        {
                            /*************如果为未选中且有关联表id则为删除******************/
                            var facilityFunction = existlist.Where(x => x.Id.Equals(ffinfo.Id)).FirstOrDefault();
                            if (facilityFunction == null)
                            {
                                deletelist.Add(facilityFunction);
                            }
                        }
                    }

                    FacilityFunctionRpt.Insert(DbContext, insertlist);
                    FacilityFunctionRpt.Delete(DbContext, deletelist);
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
        public override OperationResult Modify(FacilityInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
                Facility entity = FacilityRpt.Get(DbContext, info.Id);
                DESwap.FacilityDTE(info, entity);
                FacilityRpt.Update(DbContext, entity);

                /*关联功能是否为空*/
                if (info.FacilityFunctionInfoList != null)
                {
                    /*****新增列表*********/
                    List<FacilityFunction> insertlist = new List<FacilityFunction>();
                    /*****删除列表*********/
                    List<FacilityFunction> deletelist = new List<FacilityFunction>();


                    /*原有列表*/
                    var existlist = (from i in DbContext.FacilityFunction
                                     where i.FacilityId.Equals(info.Id)
                                     select i).ToList();

                    /*************如果为选中且没有关联表id则为新增******************/
                    foreach (var ffinfo in info.FacilityFunctionInfoList)
                    {
                        if (string.IsNullOrEmpty(ffinfo.Id) && ffinfo.Selected)
                        {
                            /*************如果为选中且没有关联表id则为新增******************/
                            ffinfo.Id = System.Guid.NewGuid().ToString();
                            ffinfo.FacilityId = info.Id;
                            FacilityFunction facilityFunction = new FacilityFunction();
                            DESwap.FacilityFunctionDTE(ffinfo, facilityFunction);
                            insertlist.Add(facilityFunction);
                        }
                        else if (!string.IsNullOrEmpty(ffinfo.Id) && ffinfo.Selected == false)
                        {
                            /*************如果为未选中且有关联表id则为删除******************/
                            var facilityFunction = existlist.Where(x => x.Id.Equals(ffinfo.Id)).FirstOrDefault();
                            if (facilityFunction != null)
                            {
                                deletelist.Add(facilityFunction);
                            }
                        }
                    }

                    FacilityFunctionRpt.Insert(DbContext, insertlist);
                    FacilityFunctionRpt.Delete(DbContext, deletelist);
                }

                DbContext.SaveChanges();

                result.ResultType = OperationResultType.Success;
                result.Message = "操作成功!";
                return result;
            }

        }

    }
}

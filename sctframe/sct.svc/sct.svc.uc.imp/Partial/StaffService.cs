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

    public class StaffService : StaffBaseService, IStaffService
    {

        protected virtual StaffStationRpt StaffStationRpt { get; set; }

        public PageResult<StaffInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {
            PageResult<StaffInfo> result = new PageResult<StaffInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<StaffInfo> list = null;

            using (var DbContext = new UCDbContext())
            {
                var query = from i in DbContext.Staff
                            join d in DbContext.Department on i.DepartmentId equals d.Id
                            join c in DbContext.Company on d.CompanyId equals c.Id
                            select new StaffInfo()
                            {
                                Id = i.Id,
                                UserCode = i.UserCode,
                                UserName = i.UserName,
                                Sex = i.Sex,
                                Mobile = i.Mobile,
                                DepartmentId = i.DepartmentId,
                                DepartmentName = d.DepartmentName,
                                CompanyId = d.CompanyId,
                                CompanyName = c.CompanyName,
                                SYS_IsValid = i.SYS_IsValid,
                                SYS_OrderSeq = i.SYS_OrderSeq,
                                SYS_AppId = i.SYS_AppId,
                                SYS_StaffId = i.SYS_StaffId,
                                SYS_StationId = i.SYS_StationId,
                                SYS_DepartmentId = i.SYS_DepartmentId,
                                SYS_CompanyId = i.SYS_CompanyId,
                                SYS_CreateTime = i.SYS_CreateTime
                            };


                #region 条件
                foreach (string key in searchCondtionCollection)
                {
                    string condition = searchCondtionCollection[key];
                    switch (key.ToLower())
                    {
                        case "username":
                            query = query.Where(x => x.UserName.Contains(condition));
                            break;
                        case "departmentid":
                            query = query.Where(x => x.DepartmentId.Equals(condition));
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
                        case "username":
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
        /// 用户登陆
        /// </summary>
        /// <param name="usercode">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public OperationResult Login(string usercode, string password)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            StaffInfo info = new StaffInfo();
            using (var DbContext = new UCDbContext())
            {
                var infolist = (from i in DbContext.Staff
                                where i.UserCode.Equals(usercode)
                                select i).ToList();

                if (infolist != null && infolist.Count > 0)
                {

                    DESwap.StaffETD(infolist[0], info);
                    /*加载用户对应的功能*/
                    //   if (info.Password == password)
                    {
                        var rolefacilitylist = (from ss in DbContext.StaffStation
                                                join sr in DbContext.StationRole on ss.StationId equals sr.StationId
                                                join rf in DbContext.RoleFacility on sr.RoleId equals rf.RoleId
                                                join f in DbContext.Facility on rf.FacilityId equals f.Id
                                                where ss.StaffId.Equals(info.Id)
                                                select f).Distinct().ToList();
                        List<FacilityInfo> ilist = new List<FacilityInfo>();
                        rolefacilitylist.ForEach(x =>
                        {
                            FacilityInfo rfInfo = new FacilityInfo();
                            DESwap.FacilityETD(x, rfInfo);
                            ilist.Add(rfInfo);
                        });
                        info.FacilityInfoList = ilist;

                        result.ResultType = OperationResultType.Success;
                        result.Message = "登陆成功!";
                        result.AppendData = info;
                    }
                    //else
                    //{
                    //    result.ResultType = OperationResultType.Warning;
                    //    result.Message = "用户账号或密码不正确!";
                    //}
                }
                else
                {
                    result.ResultType = OperationResultType.Warning;
                    result.Message = "用户账号或密码不正确!";
                }
            }

            return result;
        }



        /// <summary>
        /// 重载读取岗位内容，加载关联的功能列表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public override StaffInfo Load(string key)
        {
            StaffInfo info = new StaffInfo();
            using (var DbContext = new UCDbContext())
            {
                Staff entity = StaffRpt.Get(DbContext, key);
                if (info != null)
                {
                    DESwap.StaffETD(entity, info);

                    /*******查询关联权限*******/
                    var fflist = (from i in DbContext.StaffStation
                                  where i.StaffId.Equals(info.Id)
                                  select i).ToList();
                    info.StaffStationInfoList = new List<StaffStationInfo>();
                    fflist.ForEach(x =>
                    {
                        StaffStationInfo rfinfo = new StaffStationInfo();
                        DESwap.StaffStationETD(x, rfinfo);
                        info.StaffStationInfoList.Add(rfinfo);
                    });
                }

            }
            return info;
        }

        public override OperationResult Create(StaffInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
                Staff entity = new Staff();
                DESwap.StaffDTE(info, entity);
                StaffRpt.Insert(DbContext, entity);

                /*关联角色是否为空*/
                if (info.StaffStationInfoList != null)
                {
                    /*****新增列表*********/
                    List<StaffStation> insertlist = new List<StaffStation>();
                    /*****删除列表*********/
                    List<StaffStation> deletelist = new List<StaffStation>();

                    /*原有列表*/
                    var existlist = (from i in DbContext.StaffStation
                                     where i.StaffId.Equals(info.Id)
                                     select i).ToList();

                    /*************如果为选中且没有关联表id则为新增******************/
                    foreach (var rfinfo in info.StaffStationInfoList)
                    {
                        if (string.IsNullOrEmpty(rfinfo.Id) && rfinfo.Selected)
                        {
                            /*************如果为选中且没有关联表id则为新增******************/
                            rfinfo.Id = System.Guid.NewGuid().ToString();
                            rfinfo.StaffId = info.Id;
                            StaffStation staffStation = new StaffStation();
                            DESwap.StaffStationDTE(rfinfo, staffStation);
                            insertlist.Add(staffStation);
                        }
                        else if (!string.IsNullOrEmpty(rfinfo.Id) && rfinfo.Selected == false)
                        {
                            /*************如果为未选中且有关联表id则为删除******************/
                            var staffStation = existlist.Where(x => x.Id.Equals(rfinfo.Id)).FirstOrDefault();
                            if (staffStation == null)
                            {
                                deletelist.Add(staffStation);
                            }
                        }
                    }

                    StaffStationRpt.Insert(DbContext, insertlist);
                    StaffStationRpt.Delete(DbContext, deletelist);
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
        public override OperationResult Modify(StaffInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
                Staff entity = StaffRpt.Get(DbContext, info.Id);
                DESwap.StaffDTE(info, entity);
                StaffRpt.Update(DbContext, entity);

                /*关联角色是否为空*/
                if (info.StaffStationInfoList != null)
                {
                    /*****新增列表*********/
                    List<StaffStation> insertlist = new List<StaffStation>();
                    /*****删除列表*********/
                    List<StaffStation> deletelist = new List<StaffStation>();


                    /*原有列表*/
                    var existlist = (from i in DbContext.StaffStation
                                     where i.StaffId.Equals(info.Id)
                                     select i).ToList();

                    /*************如果为选中且没有关联表id则为新增******************/
                    foreach (var rfinfo in info.StaffStationInfoList)
                    {
                        if (string.IsNullOrEmpty(rfinfo.Id) && rfinfo.Selected)
                        {
                            /*************如果为选中且没有关联表id则为新增******************/
                            rfinfo.Id = System.Guid.NewGuid().ToString();
                            rfinfo.StaffId = info.Id;
                            StaffStation staffStation = new StaffStation();
                            DESwap.StaffStationDTE(rfinfo, staffStation);
                            insertlist.Add(staffStation);
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

                    StaffStationRpt.Insert(DbContext, insertlist);
                    StaffStationRpt.Delete(DbContext, deletelist);
                }

                DbContext.SaveChanges();

                result.ResultType = OperationResultType.Success;
                result.Message = "操作成功!";
                return result;
            }

        }
    }

}

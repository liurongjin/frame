using sct.cm.data;
using sct.dto.cms;
using sct.ent.cms;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Collections.Specialized;


namespace sct.svc.cms.imp
{

    public class PlateService : PlateBaseService, IPlateService
    {
        public PageResult<PlateInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {
            PageResult<PlateInfo> result = new PageResult<PlateInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<PlateInfo> list = null;

            using (var DbContext = new CmsDbContext())
            {
                var query = from i in DbContext.Plate
                            join p in DbContext.Plate on i.ParentId equals p.Id into parent
                            from tp in parent.DefaultIfEmpty()
                            select new PlateInfo()
                            {
                                Id = i.Id,
                                Code = i.Code,
                                Name = i.Name,
                                PlateType = i.PlateType,
                                ParentId = i.ParentId,
                                LimitNum = i.LimitNum,
                                ImageUrl = i.ImageUrl,
                                SYS_IsValid = i.SYS_IsValid,
                                SYS_OrderSeq = i.SYS_OrderSeq,
                                SYS_AppId = i.SYS_AppId,
                                SYS_StaffId = i.SYS_StaffId,
                                SYS_StationId = i.SYS_StationId,
                                SYS_DepartmentId = i.SYS_DepartmentId,
                                SYS_CompanyId = i.SYS_CompanyId,
                                SYS_CreateTime = i.SYS_CreateTime,
                                ParentName = tp.Name == null ? "" : tp.Name
                            };


                #region 条件
                foreach (string key in searchCondtionCollection)
                {
                    string condition = searchCondtionCollection[key];
                    switch (key.ToLower())
                    {
                        case "name":
                            query = query.Where(x => x.Name.Contains(condition));
                            break;
                        case "code":
                            query = query.Where(x => x.Code.Contains(condition));
                            break;
                        case "parentid":
                            query = query.Where(x => x.ParentId.Equals(condition));
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
                        case "name":
                            if (direct.ToLower().Equals("asc"))
                            {
                                query = query.OrderBy(x => x.Name).Skip(skip).Take(take);
                            }
                            else
                            {
                                query = query.OrderByDescending(x => x.Name).Skip(skip).Take(take);
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

    }

}

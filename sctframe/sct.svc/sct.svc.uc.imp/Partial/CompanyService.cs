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

    public class CompanyService : CompanyBaseService, ICompanyService
    {

        public PageResult<CompanyInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {
            PageResult<CompanyInfo> result = new PageResult<CompanyInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<CompanyInfo> list = null;

            using (var DbContext = new UCDbContext())
            {
                var query = from i in DbContext.Company
                            join p in DbContext.Company on i.ParentId equals p.Id into parent
                            from tp in parent.DefaultIfEmpty()
                            select new CompanyInfo()
                            {
                                Id = i.Id,
                                CompanyCode = i.CompanyCode,
                                CompanyName = i.CompanyName,
                                ParentId = i.ParentId,
                                BusinessCertiticate = i.BusinessCertiticate,
                                CodeCertificate = i.CodeCertificate,
                                CompanyAbbreviation = i.CompanyAbbreviation,
                                Phone = i.Phone,
                                RegionId = i.RegionId,
                                IsOwner = i.IsOwner,
                                SYS_IsValid = i.SYS_IsValid,
                                SYS_OrderSeq = i.SYS_OrderSeq,
                                SYS_AppId = i.SYS_AppId,
                                SYS_StaffId = i.SYS_StaffId,
                                SYS_StationId = i.SYS_StationId,
                                SYS_DepartmentId = i.SYS_DepartmentId,
                                SYS_CompanyId = i.SYS_CompanyId,
                                SYS_CreateTime = i.SYS_CreateTime,
                                ParentName = tp.CompanyName == null ? "" : tp.CompanyName
                            };


                #region 条件
                foreach (string key in searchCondtionCollection)
                {
                    string condition = searchCondtionCollection[key];
                    switch (key.ToLower())
                    {
                        case "companyname":
                            query = query.Where(x => x.CompanyName.Contains(condition));
                            break;
                        case "companycode":
                            query = query.Where(x => x.CompanyCode.Contains(condition));
                            break;
                        case "parentid":
                            query = query.Where(x => x.ParentId.Equals(condition));
                            break;
                        case "regionid":
                            query = query.Where(x => x.RegionId.Equals(condition));
                            break;
                        case "isowner":
                            query = query.Where(x => x.IsOwner.Equals(condition));
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
                        case "companyname":
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

    }

}

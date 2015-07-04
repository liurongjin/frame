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

    public class ArticleCatalogService : ArticleCatalogBaseService, IArticleCatalogService
    {

        public PageResult<ArticleCatalogInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {
            PageResult<ArticleCatalogInfo> result = new PageResult<ArticleCatalogInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<ArticleCatalogInfo> list = null;

            using (var DbContext = new CmsDbContext())
            {
                var query = from i in DbContext.ArticleCatalog
                            join p in DbContext.ArticleCatalog on i.ParentId equals p.Id into parent
                            from tp in parent.DefaultIfEmpty()
                            select new ArticleCatalogInfo()
                            {
                                Id = i.Id,
                                Code = i.Code,
                                Name = i.Name,
                                IsColumn = i.IsColumn,
                                ParentId = i.ParentId,
                                Image = i.Image,
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
                        case "iscolumn":
                            int iscolumn = Convert.ToInt32(condition);
                            query = query.Where(x => x.IsColumn.Equals(iscolumn));
                            break;
                        case "isvalid":
                            int isvalid = Convert.ToInt32(condition);
                            query = query.Where(x => x.SYS_IsValid.Equals(isvalid));
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

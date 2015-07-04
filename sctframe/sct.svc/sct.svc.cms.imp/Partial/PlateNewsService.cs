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

    public class PlateNewsService : PlateNewsBaseService, IPlateNewsService
    {

        public PageResult<PlateNewsInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {
            PageResult<PlateNewsInfo> result = new PageResult<PlateNewsInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<PlateNewsInfo> list = null;

            using (var DbContext = new CmsDbContext())
            {
                var query = from i in DbContext.PlateNews
                            join p in DbContext.Plate on i.PlateId equals p.Id
                            join ac in DbContext.ArticleCatalog on i.ArticleCatalogId equals ac.Id into articlecatalog
                            from tac in articlecatalog.DefaultIfEmpty()
                            select new PlateNewsInfo()
                            {
                                Id = i.Id,
                                Title = i.Title,
                                PlateId = i.PlateId,
                                ImageUrl = i.ImageUrl,
                                NewsLabel = i.NewsLabel,
                                ArticleCatalogId = i.ArticleCatalogId,
                                SYS_IsValid = i.SYS_IsValid,
                                SYS_OrderSeq = i.SYS_OrderSeq,
                                SYS_AppId = i.SYS_AppId,
                                SYS_StaffId = i.SYS_StaffId,
                                SYS_StationId = i.SYS_StationId,
                                SYS_DepartmentId = i.SYS_DepartmentId,
                                SYS_CompanyId = i.SYS_CompanyId,
                                SYS_CreateTime = i.SYS_CreateTime,
                                PlateName = p.Name,
                                ArticleCatalogName = tac.Name == null ? "" : tac.Name
                            };


                #region 条件
                foreach (string key in searchCondtionCollection)
                {
                    string condition = searchCondtionCollection[key];
                    switch (key.ToLower())
                    {
                        case "title":
                            query = query.Where(x => x.Title.Contains(condition));
                            break;
                        case "plateid":
                            query = query.Where(x => x.PlateId.Equals(condition));
                            break;
                        case "articlecatalogid":
                            query = query.Where(x => x.ArticleCatalogId.Equals(condition));
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
                        case "title":
                            if (direct.ToLower().Equals("asc"))
                            {
                                query = query.OrderBy(x => x.Title).Skip(skip).Take(take);
                            }
                            else
                            {
                                query = query.OrderByDescending(x => x.Title).Skip(skip).Take(take);
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

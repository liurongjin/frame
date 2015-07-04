using sct.cm.data;
using sct.dto.mrp;
using sct.ent.mrp;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Collections.Specialized;


namespace sct.svc.mrp.imp
{

    public class ProductCatalogService : ProductCatalogBaseService, IProductCatalogService
    {

        public PageResult<ProductCatalogInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {
            PageResult<ProductCatalogInfo> result = new PageResult<ProductCatalogInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<ProductCatalogInfo> list = null;

            using (var DbContext = new MRPDbContext())
            {
                var query = from i in DbContext.ProductCatalog
                            join p in DbContext.ProductCatalog on i.ParentId equals p.Id into parent
                            from tp in parent.DefaultIfEmpty()
                            select new ProductCatalogInfo()
                            {
                                Id = i.Id,
                                ProductCatalogCode = i.ProductCatalogCode,
                                ProductCatalogName = i.ProductCatalogName,
                                ParentId = i.ParentId,
                                SYS_IsValid = i.SYS_IsValid,
                                SYS_OrderSeq = i.SYS_OrderSeq,
                                SYS_AppId = i.SYS_AppId,
                                SYS_StaffId = i.SYS_StaffId,
                                SYS_StationId = i.SYS_StationId,
                                SYS_DepartmentId = i.SYS_DepartmentId,
                                SYS_CompanyId = i.SYS_CompanyId,
                                SYS_CreateTime = i.SYS_CreateTime,
                                ParentName = tp.ProductCatalogName == null ? "" : tp.ProductCatalogName
                            };


                #region 条件
                foreach (string key in searchCondtionCollection)
                {
                    string condition = searchCondtionCollection[key];
                    switch (key.ToLower())
                    {
                        case "productcatalogname":
                            query = query.Where(x => x.ProductCatalogName.Contains(condition));
                            break;
                        case "productcatalogcode":
                            query = query.Where(x => x.ProductCatalogCode.Contains(condition));
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
                        case "productcatalogname":
                            if (direct.ToLower().Equals("asc"))
                            {
                                query = query.OrderBy(x => x.ProductCatalogName).Skip(skip).Take(take);
                            }
                            else
                            {
                                query = query.OrderByDescending(x => x.ProductCatalogName).Skip(skip).Take(take);
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

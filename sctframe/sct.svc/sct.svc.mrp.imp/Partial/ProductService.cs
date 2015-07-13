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

    public class ProductService : ProductBaseService, IProductService
    {

        public PageResult<ProductInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {
            PageResult<ProductInfo> result = new PageResult<ProductInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<ProductInfo> list = null;

            using (var DbContext = new MRPDbContext())
            {
                var query = from i in DbContext.Product
                            join p in DbContext.ProductCatalog on i.ProductCatalogId equals p.Id
                            select new ProductInfo()
                            {
                                Id = i.Id,
                                ProductCode = i.ProductCode,
                                ProductName = i.ProductName,
                                ProductCatalogName = p.ProductCatalogName,
                                ProductCatalogId = i.ProductCatalogId,
                                ImageUrl = i.ImageUrl,
                                SearchKey = i.SearchKey,
                                Special = i.Special,
                                Size = i.Size,
                                MinStock = i.MinStock,
                                Stock = i.Stock,
                                MaxStock = i.MaxStock,
                                Texture = i.Texture,
                                Color = i.Color,
                                UnitId = i.UnitId,
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
                        case "productname":
                            query = query.Where(x => x.ProductName.Contains(condition));
                            break;
                        case "productcatalogid":
                            query = query.Where(x => x.ProductCatalogId.Equals(condition));
                            break;
                        case "searchkey":
                            query = query.Where(x => x.SearchKey.Equals(condition));
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
                        case "productname":
                            if (direct.ToLower().Equals("asc"))
                            {
                                query = query.OrderBy(x => x.ProductName).Skip(skip).Take(take);
                            }
                            else
                            {
                                query = query.OrderByDescending(x => x.ProductName).Skip(skip).Take(take);
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

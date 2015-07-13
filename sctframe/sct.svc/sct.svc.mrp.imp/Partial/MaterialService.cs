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

    public class MaterialService : MaterialBaseService, IMaterialService
    {

        public PageResult<MaterialInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {
            PageResult<MaterialInfo> result = new PageResult<MaterialInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<MaterialInfo> list = null;

            using (var DbContext = new MRPDbContext())
            {
                var query = from i in DbContext.Material
                            join p in DbContext.MaterialCatalog on i.MaterialCatalogId equals p.Id
                            select new MaterialInfo()
                            {
                                Id = i.Id,
                                MaterialCode = i.MaterialCode,
                                MaterialName = i.MaterialName,
                                MaterialCatalogName = p.MaterialCatalogName,
                                MaterialCatalogId = i.MaterialCatalogId,
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
                        case "materialname":
                            query = query.Where(x => x.MaterialName.Contains(condition));
                            break;
                        case "materialcatalogid":
                            query = query.Where(x => x.MaterialCatalogId.Equals(condition));
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
                        case "materialname":
                            if (direct.ToLower().Equals("asc"))
                            {
                                query = query.OrderBy(x => x.MaterialName).Skip(skip).Take(take);
                            }
                            else
                            {
                                query = query.OrderByDescending(x => x.MaterialName).Skip(skip).Take(take);
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

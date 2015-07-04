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

    public class ProductCatalogBaseService
    { 

         protected virtual ProductCatalogRpt ProductCatalogRpt { get; set; }

         public virtual OperationResult Create(ProductCatalogInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              ProductCatalog entity = new ProductCatalog();
              DESwap.ProductCatalogDTE(info, entity);
              ProductCatalogRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ProductCatalogInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            ProductCatalog entity = ProductCatalogRpt.Get(DbContext, info.Id);
            DESwap.ProductCatalogDTE(info, entity);
            ProductCatalogRpt.Update(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(string key)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            ProductCatalog entity = ProductCatalogRpt.Get(DbContext, key);
            ProductCatalogRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ProductCatalogInfo Load(string key)
         {
            ProductCatalogInfo info = new ProductCatalogInfo();
            using (var DbContext = new MRPDbContext())
            {
            ProductCatalog entity = ProductCatalogRpt.Get(DbContext, key);
            DESwap.ProductCatalogETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ProductCatalogInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductCatalog> eList = new List<ProductCatalog>();
            infoList.ForEach(x =>
            {
                ProductCatalog entity = new ProductCatalog();
                DESwap. ProductCatalogDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductCatalogRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ProductCatalogInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductCatalog> eList = new List<ProductCatalog>();
            infoList.ForEach(x =>
            {
                ProductCatalog entity = new ProductCatalog();
                DESwap. ProductCatalogDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductCatalogRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductCatalog> eList = new List<ProductCatalog>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                ProductCatalog entity = ProductCatalogRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ProductCatalogRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ProductCatalogInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ProductCatalog> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.ProductCatalog
                        select i;

            #region 条件
            foreach (string key in searchCondtionCollection)
            {
                string condition = searchCondtionCollection[key];
                switch (key.ToLower())
                {
                    case "isvalid":
                        int value = Convert.ToInt32(condition);
                        query = query.Where(x => x.SYS_IsValid.Equals(value));
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region 排序
            foreach (string sort in sortCollection)
            {
                string direct = string.Empty;
                switch (sort.ToLower())
                {
                    case "createtime":
                        if (direct.ToLower().Equals("asc"))
                        {
                            query = query.OrderBy(x => new { x.SYS_CreateTime });
                        }
                        else
                        {
                            query = query.OrderByDescending(x => new { x.SYS_CreateTime });
                        }
                        break;
                    default:
                        query = query.OrderByDescending(x => new { x.SYS_OrderSeq });
                        break;
                }
            }
           list = query.ToList();
            }
            #endregion
            #region linq to entity
            List<ProductCatalogInfo> ilist = new List<ProductCatalogInfo>();
            list.ForEach(x =>
            {
                ProductCatalogInfo info = new ProductCatalogInfo();
                DESwap.ProductCatalogETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

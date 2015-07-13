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

    public class ProductWareStockBaseService
    { 

         protected virtual ProductWareStockRpt ProductWareStockRpt { get; set; }

         public virtual OperationResult Create(ProductWareStockInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              ProductWareStock entity = new ProductWareStock();
              DESwap.ProductWareStockDTE(info, entity);
              ProductWareStockRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ProductWareStockInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            ProductWareStock entity = ProductWareStockRpt.Get(DbContext, info.Id);
            DESwap.ProductWareStockDTE(info, entity);
            ProductWareStockRpt.Update(DbContext, entity);
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
            ProductWareStock entity = ProductWareStockRpt.Get(DbContext, key);
            ProductWareStockRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ProductWareStockInfo Load(string key)
         {
            ProductWareStockInfo info = new ProductWareStockInfo();
            using (var DbContext = new MRPDbContext())
            {
            ProductWareStock entity = ProductWareStockRpt.Get(DbContext, key);
            DESwap.ProductWareStockETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ProductWareStockInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductWareStock> eList = new List<ProductWareStock>();
            infoList.ForEach(x =>
            {
                ProductWareStock entity = new ProductWareStock();
                DESwap. ProductWareStockDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductWareStockRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ProductWareStockInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductWareStock> eList = new List<ProductWareStock>();
            infoList.ForEach(x =>
            {
                ProductWareStock entity = new ProductWareStock();
                DESwap. ProductWareStockDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductWareStockRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductWareStock> eList = new List<ProductWareStock>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                ProductWareStock entity = ProductWareStockRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ProductWareStockRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ProductWareStockInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ProductWareStock> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.ProductWareStock
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
            List<ProductWareStockInfo> ilist = new List<ProductWareStockInfo>();
            list.ForEach(x =>
            {
                ProductWareStockInfo info = new ProductWareStockInfo();
                DESwap.ProductWareStockETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

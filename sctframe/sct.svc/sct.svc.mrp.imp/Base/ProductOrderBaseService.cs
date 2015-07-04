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

    public class ProductOrderBaseService
    { 

         protected virtual ProductOrderRpt ProductOrderRpt { get; set; }

         public virtual OperationResult Create(ProductOrderInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              ProductOrder entity = new ProductOrder();
              DESwap.ProductOrderDTE(info, entity);
              ProductOrderRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ProductOrderInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            ProductOrder entity = ProductOrderRpt.Get(DbContext, info.Id);
            DESwap.ProductOrderDTE(info, entity);
            ProductOrderRpt.Update(DbContext, entity);
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
            ProductOrder entity = ProductOrderRpt.Get(DbContext, key);
            ProductOrderRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ProductOrderInfo Load(string key)
         {
            ProductOrderInfo info = new ProductOrderInfo();
            using (var DbContext = new MRPDbContext())
            {
            ProductOrder entity = ProductOrderRpt.Get(DbContext, key);
            DESwap.ProductOrderETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ProductOrderInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductOrder> eList = new List<ProductOrder>();
            infoList.ForEach(x =>
            {
                ProductOrder entity = new ProductOrder();
                DESwap. ProductOrderDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductOrderRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ProductOrderInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductOrder> eList = new List<ProductOrder>();
            infoList.ForEach(x =>
            {
                ProductOrder entity = new ProductOrder();
                DESwap. ProductOrderDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductOrderRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductOrder> eList = new List<ProductOrder>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                ProductOrder entity = ProductOrderRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ProductOrderRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ProductOrderInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ProductOrder> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.ProductOrder
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
            List<ProductOrderInfo> ilist = new List<ProductOrderInfo>();
            list.ForEach(x =>
            {
                ProductOrderInfo info = new ProductOrderInfo();
                DESwap.ProductOrderETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

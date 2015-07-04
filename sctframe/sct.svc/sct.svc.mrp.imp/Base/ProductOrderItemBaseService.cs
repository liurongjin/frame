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

    public class ProductOrderItemBaseService
    { 

         protected virtual ProductOrderItemRpt ProductOrderItemRpt { get; set; }

         public virtual OperationResult Create(ProductOrderItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              ProductOrderItem entity = new ProductOrderItem();
              DESwap.ProductOrderItemDTE(info, entity);
              ProductOrderItemRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ProductOrderItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            ProductOrderItem entity = ProductOrderItemRpt.Get(DbContext, info.Id);
            DESwap.ProductOrderItemDTE(info, entity);
            ProductOrderItemRpt.Update(DbContext, entity);
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
            ProductOrderItem entity = ProductOrderItemRpt.Get(DbContext, key);
            ProductOrderItemRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ProductOrderItemInfo Load(string key)
         {
            ProductOrderItemInfo info = new ProductOrderItemInfo();
            using (var DbContext = new MRPDbContext())
            {
            ProductOrderItem entity = ProductOrderItemRpt.Get(DbContext, key);
            DESwap.ProductOrderItemETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ProductOrderItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductOrderItem> eList = new List<ProductOrderItem>();
            infoList.ForEach(x =>
            {
                ProductOrderItem entity = new ProductOrderItem();
                DESwap. ProductOrderItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductOrderItemRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ProductOrderItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductOrderItem> eList = new List<ProductOrderItem>();
            infoList.ForEach(x =>
            {
                ProductOrderItem entity = new ProductOrderItem();
                DESwap. ProductOrderItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductOrderItemRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductOrderItem> eList = new List<ProductOrderItem>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                ProductOrderItem entity = ProductOrderItemRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ProductOrderItemRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ProductOrderItemInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ProductOrderItem> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.ProductOrderItem
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
            List<ProductOrderItemInfo> ilist = new List<ProductOrderItemInfo>();
            list.ForEach(x =>
            {
                ProductOrderItemInfo info = new ProductOrderItemInfo();
                DESwap.ProductOrderItemETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

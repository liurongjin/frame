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

    public class ProductBillItemBaseService
    { 

         protected virtual ProductBillItemRpt ProductBillItemRpt { get; set; }

         public virtual OperationResult Create(ProductBillItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              ProductBillItem entity = new ProductBillItem();
              DESwap.ProductBillItemDTE(info, entity);
              ProductBillItemRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ProductBillItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            ProductBillItem entity = ProductBillItemRpt.Get(DbContext, info.Id);
            DESwap.ProductBillItemDTE(info, entity);
            ProductBillItemRpt.Update(DbContext, entity);
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
            ProductBillItem entity = ProductBillItemRpt.Get(DbContext, key);
            ProductBillItemRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ProductBillItemInfo Load(string key)
         {
            ProductBillItemInfo info = new ProductBillItemInfo();
            using (var DbContext = new MRPDbContext())
            {
            ProductBillItem entity = ProductBillItemRpt.Get(DbContext, key);
            DESwap.ProductBillItemETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ProductBillItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductBillItem> eList = new List<ProductBillItem>();
            infoList.ForEach(x =>
            {
                ProductBillItem entity = new ProductBillItem();
                DESwap. ProductBillItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductBillItemRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ProductBillItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductBillItem> eList = new List<ProductBillItem>();
            infoList.ForEach(x =>
            {
                ProductBillItem entity = new ProductBillItem();
                DESwap. ProductBillItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductBillItemRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductBillItem> eList = new List<ProductBillItem>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                ProductBillItem entity = ProductBillItemRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ProductBillItemRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ProductBillItemInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ProductBillItem> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.ProductBillItem
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
            List<ProductBillItemInfo> ilist = new List<ProductBillItemInfo>();
            list.ForEach(x =>
            {
                ProductBillItemInfo info = new ProductBillItemInfo();
                DESwap.ProductBillItemETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

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

    public class ProductBillBaseService
    { 

         protected virtual ProductBillRpt ProductBillRpt { get; set; }

         public virtual OperationResult Create(ProductBillInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              ProductBill entity = new ProductBill();
              DESwap.ProductBillDTE(info, entity);
              ProductBillRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ProductBillInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            ProductBill entity = ProductBillRpt.Get(DbContext, info.Id);
            DESwap.ProductBillDTE(info, entity);
            ProductBillRpt.Update(DbContext, entity);
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
            ProductBill entity = ProductBillRpt.Get(DbContext, key);
            ProductBillRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ProductBillInfo Load(string key)
         {
            ProductBillInfo info = new ProductBillInfo();
            using (var DbContext = new MRPDbContext())
            {
            ProductBill entity = ProductBillRpt.Get(DbContext, key);
            DESwap.ProductBillETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ProductBillInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductBill> eList = new List<ProductBill>();
            infoList.ForEach(x =>
            {
                ProductBill entity = new ProductBill();
                DESwap. ProductBillDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductBillRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ProductBillInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductBill> eList = new List<ProductBill>();
            infoList.ForEach(x =>
            {
                ProductBill entity = new ProductBill();
                DESwap. ProductBillDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ProductBillRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ProductBill> eList = new List<ProductBill>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                ProductBill entity = ProductBillRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ProductBillRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ProductBillInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ProductBill> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.ProductBill
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
            List<ProductBillInfo> ilist = new List<ProductBillInfo>();
            list.ForEach(x =>
            {
                ProductBillInfo info = new ProductBillInfo();
                DESwap.ProductBillETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

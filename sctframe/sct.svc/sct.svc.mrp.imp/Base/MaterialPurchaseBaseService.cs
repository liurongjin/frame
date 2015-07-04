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

    public class MaterialPurchaseBaseService
    { 

         protected virtual MaterialPurchaseRpt MaterialPurchaseRpt { get; set; }

         public virtual OperationResult Create(MaterialPurchaseInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              MaterialPurchase entity = new MaterialPurchase();
              DESwap.MaterialPurchaseDTE(info, entity);
              MaterialPurchaseRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(MaterialPurchaseInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchase entity = MaterialPurchaseRpt.Get(DbContext, info.Id);
            DESwap.MaterialPurchaseDTE(info, entity);
            MaterialPurchaseRpt.Update(DbContext, entity);
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
            MaterialPurchase entity = MaterialPurchaseRpt.Get(DbContext, key);
            MaterialPurchaseRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual MaterialPurchaseInfo Load(string key)
         {
            MaterialPurchaseInfo info = new MaterialPurchaseInfo();
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchase entity = MaterialPurchaseRpt.Get(DbContext, key);
            DESwap.MaterialPurchaseETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<MaterialPurchaseInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchase> eList = new List<MaterialPurchase>();
            infoList.ForEach(x =>
            {
                MaterialPurchase entity = new MaterialPurchase();
                DESwap. MaterialPurchaseDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchaseRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<MaterialPurchaseInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchase> eList = new List<MaterialPurchase>();
            infoList.ForEach(x =>
            {
                MaterialPurchase entity = new MaterialPurchase();
                DESwap. MaterialPurchaseDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchaseRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchase> eList = new List<MaterialPurchase>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                MaterialPurchase entity = MaterialPurchaseRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            MaterialPurchaseRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<MaterialPurchaseInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<MaterialPurchase> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.MaterialPurchase
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
            List<MaterialPurchaseInfo> ilist = new List<MaterialPurchaseInfo>();
            list.ForEach(x =>
            {
                MaterialPurchaseInfo info = new MaterialPurchaseInfo();
                DESwap.MaterialPurchaseETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

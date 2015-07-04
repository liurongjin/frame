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

    public class MaterialPurchaseItemBaseService
    { 

         protected virtual MaterialPurchaseItemRpt MaterialPurchaseItemRpt { get; set; }

         public virtual OperationResult Create(MaterialPurchaseItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              MaterialPurchaseItem entity = new MaterialPurchaseItem();
              DESwap.MaterialPurchaseItemDTE(info, entity);
              MaterialPurchaseItemRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(MaterialPurchaseItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchaseItem entity = MaterialPurchaseItemRpt.Get(DbContext, info.Id);
            DESwap.MaterialPurchaseItemDTE(info, entity);
            MaterialPurchaseItemRpt.Update(DbContext, entity);
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
            MaterialPurchaseItem entity = MaterialPurchaseItemRpt.Get(DbContext, key);
            MaterialPurchaseItemRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual MaterialPurchaseItemInfo Load(string key)
         {
            MaterialPurchaseItemInfo info = new MaterialPurchaseItemInfo();
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchaseItem entity = MaterialPurchaseItemRpt.Get(DbContext, key);
            DESwap.MaterialPurchaseItemETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<MaterialPurchaseItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchaseItem> eList = new List<MaterialPurchaseItem>();
            infoList.ForEach(x =>
            {
                MaterialPurchaseItem entity = new MaterialPurchaseItem();
                DESwap. MaterialPurchaseItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchaseItemRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<MaterialPurchaseItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchaseItem> eList = new List<MaterialPurchaseItem>();
            infoList.ForEach(x =>
            {
                MaterialPurchaseItem entity = new MaterialPurchaseItem();
                DESwap. MaterialPurchaseItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchaseItemRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchaseItem> eList = new List<MaterialPurchaseItem>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                MaterialPurchaseItem entity = MaterialPurchaseItemRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            MaterialPurchaseItemRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<MaterialPurchaseItemInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<MaterialPurchaseItem> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.MaterialPurchaseItem
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
            List<MaterialPurchaseItemInfo> ilist = new List<MaterialPurchaseItemInfo>();
            list.ForEach(x =>
            {
                MaterialPurchaseItemInfo info = new MaterialPurchaseItemInfo();
                DESwap.MaterialPurchaseItemETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

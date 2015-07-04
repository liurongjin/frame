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

    public class MaterialPurchasePlanItemBaseService
    { 

         protected virtual MaterialPurchasePlanItemRpt MaterialPurchasePlanItemRpt { get; set; }

         public virtual OperationResult Create(MaterialPurchasePlanItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              MaterialPurchasePlanItem entity = new MaterialPurchasePlanItem();
              DESwap.MaterialPurchasePlanItemDTE(info, entity);
              MaterialPurchasePlanItemRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(MaterialPurchasePlanItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchasePlanItem entity = MaterialPurchasePlanItemRpt.Get(DbContext, info.Id);
            DESwap.MaterialPurchasePlanItemDTE(info, entity);
            MaterialPurchasePlanItemRpt.Update(DbContext, entity);
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
            MaterialPurchasePlanItem entity = MaterialPurchasePlanItemRpt.Get(DbContext, key);
            MaterialPurchasePlanItemRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual MaterialPurchasePlanItemInfo Load(string key)
         {
            MaterialPurchasePlanItemInfo info = new MaterialPurchasePlanItemInfo();
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchasePlanItem entity = MaterialPurchasePlanItemRpt.Get(DbContext, key);
            DESwap.MaterialPurchasePlanItemETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<MaterialPurchasePlanItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchasePlanItem> eList = new List<MaterialPurchasePlanItem>();
            infoList.ForEach(x =>
            {
                MaterialPurchasePlanItem entity = new MaterialPurchasePlanItem();
                DESwap. MaterialPurchasePlanItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchasePlanItemRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<MaterialPurchasePlanItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchasePlanItem> eList = new List<MaterialPurchasePlanItem>();
            infoList.ForEach(x =>
            {
                MaterialPurchasePlanItem entity = new MaterialPurchasePlanItem();
                DESwap. MaterialPurchasePlanItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchasePlanItemRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchasePlanItem> eList = new List<MaterialPurchasePlanItem>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                MaterialPurchasePlanItem entity = MaterialPurchasePlanItemRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            MaterialPurchasePlanItemRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<MaterialPurchasePlanItemInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<MaterialPurchasePlanItem> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.MaterialPurchasePlanItem
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
            List<MaterialPurchasePlanItemInfo> ilist = new List<MaterialPurchasePlanItemInfo>();
            list.ForEach(x =>
            {
                MaterialPurchasePlanItemInfo info = new MaterialPurchasePlanItemInfo();
                DESwap.MaterialPurchasePlanItemETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

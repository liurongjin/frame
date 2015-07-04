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

    public class MaterialPurchasePlanBaseService
    { 

         protected virtual MaterialPurchasePlanRpt MaterialPurchasePlanRpt { get; set; }

         public virtual OperationResult Create(MaterialPurchasePlanInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              MaterialPurchasePlan entity = new MaterialPurchasePlan();
              DESwap.MaterialPurchasePlanDTE(info, entity);
              MaterialPurchasePlanRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(MaterialPurchasePlanInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchasePlan entity = MaterialPurchasePlanRpt.Get(DbContext, info.Id);
            DESwap.MaterialPurchasePlanDTE(info, entity);
            MaterialPurchasePlanRpt.Update(DbContext, entity);
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
            MaterialPurchasePlan entity = MaterialPurchasePlanRpt.Get(DbContext, key);
            MaterialPurchasePlanRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual MaterialPurchasePlanInfo Load(string key)
         {
            MaterialPurchasePlanInfo info = new MaterialPurchasePlanInfo();
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchasePlan entity = MaterialPurchasePlanRpt.Get(DbContext, key);
            DESwap.MaterialPurchasePlanETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<MaterialPurchasePlanInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchasePlan> eList = new List<MaterialPurchasePlan>();
            infoList.ForEach(x =>
            {
                MaterialPurchasePlan entity = new MaterialPurchasePlan();
                DESwap. MaterialPurchasePlanDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchasePlanRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<MaterialPurchasePlanInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchasePlan> eList = new List<MaterialPurchasePlan>();
            infoList.ForEach(x =>
            {
                MaterialPurchasePlan entity = new MaterialPurchasePlan();
                DESwap. MaterialPurchasePlanDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialPurchasePlanRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialPurchasePlan> eList = new List<MaterialPurchasePlan>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                MaterialPurchasePlan entity = MaterialPurchasePlanRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            MaterialPurchasePlanRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<MaterialPurchasePlanInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<MaterialPurchasePlan> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.MaterialPurchasePlan
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
            List<MaterialPurchasePlanInfo> ilist = new List<MaterialPurchasePlanInfo>();
            list.ForEach(x =>
            {
                MaterialPurchasePlanInfo info = new MaterialPurchasePlanInfo();
                DESwap.MaterialPurchasePlanETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

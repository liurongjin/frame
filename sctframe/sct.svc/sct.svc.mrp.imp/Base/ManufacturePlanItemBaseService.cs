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

    public class ManufacturePlanItemBaseService
    { 

         protected virtual ManufacturePlanItemRpt ManufacturePlanItemRpt { get; set; }

         public virtual OperationResult Create(ManufacturePlanItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              ManufacturePlanItem entity = new ManufacturePlanItem();
              DESwap.ManufacturePlanItemDTE(info, entity);
              ManufacturePlanItemRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ManufacturePlanItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            ManufacturePlanItem entity = ManufacturePlanItemRpt.Get(DbContext, info.Id);
            DESwap.ManufacturePlanItemDTE(info, entity);
            ManufacturePlanItemRpt.Update(DbContext, entity);
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
            ManufacturePlanItem entity = ManufacturePlanItemRpt.Get(DbContext, key);
            ManufacturePlanItemRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ManufacturePlanItemInfo Load(string key)
         {
            ManufacturePlanItemInfo info = new ManufacturePlanItemInfo();
            using (var DbContext = new MRPDbContext())
            {
            ManufacturePlanItem entity = ManufacturePlanItemRpt.Get(DbContext, key);
            DESwap.ManufacturePlanItemETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ManufacturePlanItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ManufacturePlanItem> eList = new List<ManufacturePlanItem>();
            infoList.ForEach(x =>
            {
                ManufacturePlanItem entity = new ManufacturePlanItem();
                DESwap. ManufacturePlanItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ManufacturePlanItemRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ManufacturePlanItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ManufacturePlanItem> eList = new List<ManufacturePlanItem>();
            infoList.ForEach(x =>
            {
                ManufacturePlanItem entity = new ManufacturePlanItem();
                DESwap. ManufacturePlanItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ManufacturePlanItemRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ManufacturePlanItem> eList = new List<ManufacturePlanItem>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                ManufacturePlanItem entity = ManufacturePlanItemRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ManufacturePlanItemRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ManufacturePlanItemInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ManufacturePlanItem> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.ManufacturePlanItem
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
            List<ManufacturePlanItemInfo> ilist = new List<ManufacturePlanItemInfo>();
            list.ForEach(x =>
            {
                ManufacturePlanItemInfo info = new ManufacturePlanItemInfo();
                DESwap.ManufacturePlanItemETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

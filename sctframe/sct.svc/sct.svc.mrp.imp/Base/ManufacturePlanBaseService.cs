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

    public class ManufacturePlanBaseService
    { 

         protected virtual ManufacturePlanRpt ManufacturePlanRpt { get; set; }

         public virtual OperationResult Create(ManufacturePlanInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              ManufacturePlan entity = new ManufacturePlan();
              DESwap.ManufacturePlanDTE(info, entity);
              ManufacturePlanRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ManufacturePlanInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            ManufacturePlan entity = ManufacturePlanRpt.Get(DbContext, info.Id);
            DESwap.ManufacturePlanDTE(info, entity);
            ManufacturePlanRpt.Update(DbContext, entity);
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
            ManufacturePlan entity = ManufacturePlanRpt.Get(DbContext, key);
            ManufacturePlanRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ManufacturePlanInfo Load(string key)
         {
            ManufacturePlanInfo info = new ManufacturePlanInfo();
            using (var DbContext = new MRPDbContext())
            {
            ManufacturePlan entity = ManufacturePlanRpt.Get(DbContext, key);
            DESwap.ManufacturePlanETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ManufacturePlanInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ManufacturePlan> eList = new List<ManufacturePlan>();
            infoList.ForEach(x =>
            {
                ManufacturePlan entity = new ManufacturePlan();
                DESwap. ManufacturePlanDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ManufacturePlanRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ManufacturePlanInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ManufacturePlan> eList = new List<ManufacturePlan>();
            infoList.ForEach(x =>
            {
                ManufacturePlan entity = new ManufacturePlan();
                DESwap. ManufacturePlanDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            ManufacturePlanRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ManufacturePlan> eList = new List<ManufacturePlan>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                ManufacturePlan entity = ManufacturePlanRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ManufacturePlanRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ManufacturePlanInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ManufacturePlan> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.ManufacturePlan
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
            List<ManufacturePlanInfo> ilist = new List<ManufacturePlanInfo>();
            list.ForEach(x =>
            {
                ManufacturePlanInfo info = new ManufacturePlanInfo();
                DESwap.ManufacturePlanETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

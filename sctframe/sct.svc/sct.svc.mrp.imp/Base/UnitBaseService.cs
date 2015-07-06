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

    public class UnitBaseService
    { 

         protected virtual UnitRpt UnitRpt { get; set; }

         public virtual OperationResult Create(UnitInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              Unit entity = new Unit();
              DESwap.UnitDTE(info, entity);
              UnitRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(UnitInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            Unit entity = UnitRpt.Get(DbContext, info.Id);
            DESwap.UnitDTE(info, entity);
            UnitRpt.Update(DbContext, entity);
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
            Unit entity = UnitRpt.Get(DbContext, key);
            UnitRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual UnitInfo Load(string key)
         {
            UnitInfo info = new UnitInfo();
            using (var DbContext = new MRPDbContext())
            {
            Unit entity = UnitRpt.Get(DbContext, key);
            DESwap.UnitETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<UnitInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Unit> eList = new List<Unit>();
            infoList.ForEach(x =>
            {
                Unit entity = new Unit();
                DESwap. UnitDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            UnitRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<UnitInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Unit> eList = new List<Unit>();
            infoList.ForEach(x =>
            {
                Unit entity = new Unit();
                DESwap. UnitDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            UnitRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Unit> eList = new List<Unit>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                Unit entity = UnitRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            UnitRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<UnitInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<Unit> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.Unit
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
            List<UnitInfo> ilist = new List<UnitInfo>();
            list.ForEach(x =>
            {
                UnitInfo info = new UnitInfo();
                DESwap.UnitETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

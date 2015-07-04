using sct.cm.data;
using sct.dto.uc;
using sct.ent.uc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Collections.Specialized;


namespace sct.svc.uc.imp
{

    public class FunctionBaseService
    { 

         protected virtual FunctionRpt FunctionRpt { get; set; }

         public virtual OperationResult Create(FunctionInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              Function entity = new Function();
              DESwap.FunctionDTE(info, entity);
              FunctionRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(FunctionInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            Function entity = FunctionRpt.Get(DbContext, info.Id);
            DESwap.FunctionDTE(info, entity);
            FunctionRpt.Update(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(string key)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            Function entity = FunctionRpt.Get(DbContext, key);
            FunctionRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual FunctionInfo Load(string key)
         {
            FunctionInfo info = new FunctionInfo();
            using (var DbContext = new UCDbContext())
            {
            Function entity = FunctionRpt.Get(DbContext, key);
            DESwap.FunctionETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<FunctionInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Function> eList = new List<Function>();
            infoList.ForEach(x =>
            {
                Function entity = new Function();
                DESwap. FunctionDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            FunctionRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<FunctionInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Function> eList = new List<Function>();
            infoList.ForEach(x =>
            {
                Function entity = new Function();
                DESwap. FunctionDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            FunctionRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Function> eList = new List<Function>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                Function entity = FunctionRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            FunctionRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<FunctionInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<Function> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.Function
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
            List<FunctionInfo> ilist = new List<FunctionInfo>();
            list.ForEach(x =>
            {
                FunctionInfo info = new FunctionInfo();
                DESwap.FunctionETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

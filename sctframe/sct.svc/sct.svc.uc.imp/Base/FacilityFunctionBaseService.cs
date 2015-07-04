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

    public class FacilityFunctionBaseService
    { 

         protected virtual FacilityFunctionRpt FacilityFunctionRpt { get; set; }

         public virtual OperationResult Create(FacilityFunctionInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              FacilityFunction entity = new FacilityFunction();
              DESwap.FacilityFunctionDTE(info, entity);
              FacilityFunctionRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(FacilityFunctionInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            FacilityFunction entity = FacilityFunctionRpt.Get(DbContext, info.Id);
            DESwap.FacilityFunctionDTE(info, entity);
            FacilityFunctionRpt.Update(DbContext, entity);
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
            FacilityFunction entity = FacilityFunctionRpt.Get(DbContext, key);
            FacilityFunctionRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual FacilityFunctionInfo Load(string key)
         {
            FacilityFunctionInfo info = new FacilityFunctionInfo();
            using (var DbContext = new UCDbContext())
            {
            FacilityFunction entity = FacilityFunctionRpt.Get(DbContext, key);
            DESwap.FacilityFunctionETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<FacilityFunctionInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<FacilityFunction> eList = new List<FacilityFunction>();
            infoList.ForEach(x =>
            {
                FacilityFunction entity = new FacilityFunction();
                DESwap. FacilityFunctionDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            FacilityFunctionRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<FacilityFunctionInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<FacilityFunction> eList = new List<FacilityFunction>();
            infoList.ForEach(x =>
            {
                FacilityFunction entity = new FacilityFunction();
                DESwap. FacilityFunctionDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            FacilityFunctionRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<FacilityFunction> eList = new List<FacilityFunction>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                FacilityFunction entity = FacilityFunctionRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            FacilityFunctionRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<FacilityFunctionInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<FacilityFunction> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.FacilityFunction
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
            List<FacilityFunctionInfo> ilist = new List<FacilityFunctionInfo>();
            list.ForEach(x =>
            {
                FacilityFunctionInfo info = new FacilityFunctionInfo();
                DESwap.FacilityFunctionETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

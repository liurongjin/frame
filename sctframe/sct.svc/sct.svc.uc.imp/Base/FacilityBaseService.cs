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

    public class FacilityBaseService
    { 

         protected virtual FacilityRpt FacilityRpt { get; set; }

         public virtual OperationResult Create(FacilityInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              Facility entity = new Facility();
              DESwap.FacilityDTE(info, entity);
              FacilityRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(FacilityInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            Facility entity = FacilityRpt.Get(DbContext, info.Id);
            DESwap.FacilityDTE(info, entity);
            FacilityRpt.Update(DbContext, entity);
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
            Facility entity = FacilityRpt.Get(DbContext, key);
            FacilityRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual FacilityInfo Load(string key)
         {
            FacilityInfo info = new FacilityInfo();
            using (var DbContext = new UCDbContext())
            {
            Facility entity = FacilityRpt.Get(DbContext, key);
            DESwap.FacilityETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<FacilityInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Facility> eList = new List<Facility>();
            infoList.ForEach(x =>
            {
                Facility entity = new Facility();
                DESwap. FacilityDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            FacilityRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<FacilityInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Facility> eList = new List<Facility>();
            infoList.ForEach(x =>
            {
                Facility entity = new Facility();
                DESwap. FacilityDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            FacilityRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Facility> eList = new List<Facility>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                Facility entity = FacilityRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            FacilityRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<FacilityInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<Facility> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.Facility
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
            List<FacilityInfo> ilist = new List<FacilityInfo>();
            list.ForEach(x =>
            {
                FacilityInfo info = new FacilityInfo();
                DESwap.FacilityETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

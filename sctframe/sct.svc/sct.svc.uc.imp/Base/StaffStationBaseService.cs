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

    public class StaffStationBaseService
    { 

         protected virtual StaffStationRpt StaffStationRpt { get; set; }

         public virtual OperationResult Create(StaffStationInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              StaffStation entity = new StaffStation();
              DESwap.StaffStationDTE(info, entity);
              StaffStationRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(StaffStationInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            StaffStation entity = StaffStationRpt.Get(DbContext, info.Id);
            DESwap.StaffStationDTE(info, entity);
            StaffStationRpt.Update(DbContext, entity);
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
            StaffStation entity = StaffStationRpt.Get(DbContext, key);
            StaffStationRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual StaffStationInfo Load(string key)
         {
            StaffStationInfo info = new StaffStationInfo();
            using (var DbContext = new UCDbContext())
            {
            StaffStation entity = StaffStationRpt.Get(DbContext, key);
            DESwap.StaffStationETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<StaffStationInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<StaffStation> eList = new List<StaffStation>();
            infoList.ForEach(x =>
            {
                StaffStation entity = new StaffStation();
                DESwap. StaffStationDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            StaffStationRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<StaffStationInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<StaffStation> eList = new List<StaffStation>();
            infoList.ForEach(x =>
            {
                StaffStation entity = new StaffStation();
                DESwap. StaffStationDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            StaffStationRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<StaffStation> eList = new List<StaffStation>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                StaffStation entity = StaffStationRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            StaffStationRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<StaffStationInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<StaffStation> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.StaffStation
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
            List<StaffStationInfo> ilist = new List<StaffStationInfo>();
            list.ForEach(x =>
            {
                StaffStationInfo info = new StaffStationInfo();
                DESwap.StaffStationETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

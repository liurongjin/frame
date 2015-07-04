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

    public class StationRoleBaseService
    { 

         protected virtual StationRoleRpt StationRoleRpt { get; set; }

         public virtual OperationResult Create(StationRoleInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              StationRole entity = new StationRole();
              DESwap.StationRoleDTE(info, entity);
              StationRoleRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(StationRoleInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            StationRole entity = StationRoleRpt.Get(DbContext, info.Id);
            DESwap.StationRoleDTE(info, entity);
            StationRoleRpt.Update(DbContext, entity);
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
            StationRole entity = StationRoleRpt.Get(DbContext, key);
            StationRoleRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual StationRoleInfo Load(string key)
         {
            StationRoleInfo info = new StationRoleInfo();
            using (var DbContext = new UCDbContext())
            {
            StationRole entity = StationRoleRpt.Get(DbContext, key);
            DESwap.StationRoleETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<StationRoleInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<StationRole> eList = new List<StationRole>();
            infoList.ForEach(x =>
            {
                StationRole entity = new StationRole();
                DESwap. StationRoleDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            StationRoleRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<StationRoleInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<StationRole> eList = new List<StationRole>();
            infoList.ForEach(x =>
            {
                StationRole entity = new StationRole();
                DESwap. StationRoleDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            StationRoleRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<StationRole> eList = new List<StationRole>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                StationRole entity = StationRoleRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            StationRoleRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<StationRoleInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<StationRole> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.StationRole
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
            List<StationRoleInfo> ilist = new List<StationRoleInfo>();
            list.ForEach(x =>
            {
                StationRoleInfo info = new StationRoleInfo();
                DESwap.StationRoleETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

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

    public class RoleFacilityBaseService
    { 

         protected virtual RoleFacilityRpt RoleFacilityRpt { get; set; }

         public virtual OperationResult Create(RoleFacilityInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              RoleFacility entity = new RoleFacility();
              DESwap.RoleFacilityDTE(info, entity);
              RoleFacilityRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(RoleFacilityInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            RoleFacility entity = RoleFacilityRpt.Get(DbContext, info.Id);
            DESwap.RoleFacilityDTE(info, entity);
            RoleFacilityRpt.Update(DbContext, entity);
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
            RoleFacility entity = RoleFacilityRpt.Get(DbContext, key);
            RoleFacilityRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual RoleFacilityInfo Load(string key)
         {
            RoleFacilityInfo info = new RoleFacilityInfo();
            using (var DbContext = new UCDbContext())
            {
            RoleFacility entity = RoleFacilityRpt.Get(DbContext, key);
            DESwap.RoleFacilityETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<RoleFacilityInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<RoleFacility> eList = new List<RoleFacility>();
            infoList.ForEach(x =>
            {
                RoleFacility entity = new RoleFacility();
                DESwap. RoleFacilityDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            RoleFacilityRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<RoleFacilityInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<RoleFacility> eList = new List<RoleFacility>();
            infoList.ForEach(x =>
            {
                RoleFacility entity = new RoleFacility();
                DESwap. RoleFacilityDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            RoleFacilityRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<RoleFacility> eList = new List<RoleFacility>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                RoleFacility entity = RoleFacilityRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            RoleFacilityRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<RoleFacilityInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<RoleFacility> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.RoleFacility
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
            List<RoleFacilityInfo> ilist = new List<RoleFacilityInfo>();
            list.ForEach(x =>
            {
                RoleFacilityInfo info = new RoleFacilityInfo();
                DESwap.RoleFacilityETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

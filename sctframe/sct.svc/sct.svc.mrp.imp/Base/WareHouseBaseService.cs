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

    public class WareHouseBaseService
    { 

         protected virtual WareHouseRpt WareHouseRpt { get; set; }

         public virtual OperationResult Create(WareHouseInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              WareHouse entity = new WareHouse();
              DESwap.WareHouseDTE(info, entity);
              WareHouseRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(WareHouseInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            WareHouse entity = WareHouseRpt.Get(DbContext, info.Id);
            DESwap.WareHouseDTE(info, entity);
            WareHouseRpt.Update(DbContext, entity);
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
            WareHouse entity = WareHouseRpt.Get(DbContext, key);
            WareHouseRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual WareHouseInfo Load(string key)
         {
            WareHouseInfo info = new WareHouseInfo();
            using (var DbContext = new MRPDbContext())
            {
            WareHouse entity = WareHouseRpt.Get(DbContext, key);
            DESwap.WareHouseETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<WareHouseInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<WareHouse> eList = new List<WareHouse>();
            infoList.ForEach(x =>
            {
                WareHouse entity = new WareHouse();
                DESwap. WareHouseDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            WareHouseRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<WareHouseInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<WareHouse> eList = new List<WareHouse>();
            infoList.ForEach(x =>
            {
                WareHouse entity = new WareHouse();
                DESwap. WareHouseDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            WareHouseRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<WareHouse> eList = new List<WareHouse>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                WareHouse entity = WareHouseRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            WareHouseRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<WareHouseInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<WareHouse> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.WareHouse
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
            List<WareHouseInfo> ilist = new List<WareHouseInfo>();
            list.ForEach(x =>
            {
                WareHouseInfo info = new WareHouseInfo();
                DESwap.WareHouseETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

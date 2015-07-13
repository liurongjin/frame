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

    public class CompanyWareHouseBaseService
    { 

         protected virtual CompanyWareHouseRpt CompanyWareHouseRpt { get; set; }

         public virtual OperationResult Create(CompanyWareHouseInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              CompanyWareHouse entity = new CompanyWareHouse();
              DESwap.CompanyWareHouseDTE(info, entity);
              CompanyWareHouseRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(CompanyWareHouseInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            CompanyWareHouse entity = CompanyWareHouseRpt.Get(DbContext, info.Id);
            DESwap.CompanyWareHouseDTE(info, entity);
            CompanyWareHouseRpt.Update(DbContext, entity);
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
            CompanyWareHouse entity = CompanyWareHouseRpt.Get(DbContext, key);
            CompanyWareHouseRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual CompanyWareHouseInfo Load(string key)
         {
            CompanyWareHouseInfo info = new CompanyWareHouseInfo();
            using (var DbContext = new MRPDbContext())
            {
            CompanyWareHouse entity = CompanyWareHouseRpt.Get(DbContext, key);
            DESwap.CompanyWareHouseETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<CompanyWareHouseInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<CompanyWareHouse> eList = new List<CompanyWareHouse>();
            infoList.ForEach(x =>
            {
                CompanyWareHouse entity = new CompanyWareHouse();
                DESwap. CompanyWareHouseDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            CompanyWareHouseRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<CompanyWareHouseInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<CompanyWareHouse> eList = new List<CompanyWareHouse>();
            infoList.ForEach(x =>
            {
                CompanyWareHouse entity = new CompanyWareHouse();
                DESwap. CompanyWareHouseDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            CompanyWareHouseRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<CompanyWareHouse> eList = new List<CompanyWareHouse>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                CompanyWareHouse entity = CompanyWareHouseRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            CompanyWareHouseRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<CompanyWareHouseInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<CompanyWareHouse> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.CompanyWareHouse
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
            List<CompanyWareHouseInfo> ilist = new List<CompanyWareHouseInfo>();
            list.ForEach(x =>
            {
                CompanyWareHouseInfo info = new CompanyWareHouseInfo();
                DESwap.CompanyWareHouseETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

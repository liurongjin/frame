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

    public class GatherBillBaseService
    { 

         protected virtual GatherBillRpt GatherBillRpt { get; set; }

         public virtual OperationResult Create(GatherBillInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              GatherBill entity = new GatherBill();
              DESwap.GatherBillDTE(info, entity);
              GatherBillRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(GatherBillInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            GatherBill entity = GatherBillRpt.Get(DbContext, info.Id);
            DESwap.GatherBillDTE(info, entity);
            GatherBillRpt.Update(DbContext, entity);
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
            GatherBill entity = GatherBillRpt.Get(DbContext, key);
            GatherBillRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual GatherBillInfo Load(string key)
         {
            GatherBillInfo info = new GatherBillInfo();
            using (var DbContext = new MRPDbContext())
            {
            GatherBill entity = GatherBillRpt.Get(DbContext, key);
            DESwap.GatherBillETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<GatherBillInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<GatherBill> eList = new List<GatherBill>();
            infoList.ForEach(x =>
            {
                GatherBill entity = new GatherBill();
                DESwap. GatherBillDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            GatherBillRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<GatherBillInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<GatherBill> eList = new List<GatherBill>();
            infoList.ForEach(x =>
            {
                GatherBill entity = new GatherBill();
                DESwap. GatherBillDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            GatherBillRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<GatherBill> eList = new List<GatherBill>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                GatherBill entity = GatherBillRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            GatherBillRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<GatherBillInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<GatherBill> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.GatherBill
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
            List<GatherBillInfo> ilist = new List<GatherBillInfo>();
            list.ForEach(x =>
            {
                GatherBillInfo info = new GatherBillInfo();
                DESwap.GatherBillETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

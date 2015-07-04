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

    public class MaterialBillBaseService
    { 

         protected virtual MaterialBillRpt MaterialBillRpt { get; set; }

         public virtual OperationResult Create(MaterialBillInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              MaterialBill entity = new MaterialBill();
              DESwap.MaterialBillDTE(info, entity);
              MaterialBillRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(MaterialBillInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            MaterialBill entity = MaterialBillRpt.Get(DbContext, info.Id);
            DESwap.MaterialBillDTE(info, entity);
            MaterialBillRpt.Update(DbContext, entity);
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
            MaterialBill entity = MaterialBillRpt.Get(DbContext, key);
            MaterialBillRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual MaterialBillInfo Load(string key)
         {
            MaterialBillInfo info = new MaterialBillInfo();
            using (var DbContext = new MRPDbContext())
            {
            MaterialBill entity = MaterialBillRpt.Get(DbContext, key);
            DESwap.MaterialBillETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<MaterialBillInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialBill> eList = new List<MaterialBill>();
            infoList.ForEach(x =>
            {
                MaterialBill entity = new MaterialBill();
                DESwap. MaterialBillDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialBillRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<MaterialBillInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialBill> eList = new List<MaterialBill>();
            infoList.ForEach(x =>
            {
                MaterialBill entity = new MaterialBill();
                DESwap. MaterialBillDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialBillRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialBill> eList = new List<MaterialBill>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                MaterialBill entity = MaterialBillRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            MaterialBillRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<MaterialBillInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<MaterialBill> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.MaterialBill
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
            List<MaterialBillInfo> ilist = new List<MaterialBillInfo>();
            list.ForEach(x =>
            {
                MaterialBillInfo info = new MaterialBillInfo();
                DESwap.MaterialBillETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

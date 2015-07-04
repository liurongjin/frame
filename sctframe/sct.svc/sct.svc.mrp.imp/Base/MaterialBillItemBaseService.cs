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

    public class MaterialBillItemBaseService
    { 

         protected virtual MaterialBillItemRpt MaterialBillItemRpt { get; set; }

         public virtual OperationResult Create(MaterialBillItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              MaterialBillItem entity = new MaterialBillItem();
              DESwap.MaterialBillItemDTE(info, entity);
              MaterialBillItemRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(MaterialBillItemInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            MaterialBillItem entity = MaterialBillItemRpt.Get(DbContext, info.Id);
            DESwap.MaterialBillItemDTE(info, entity);
            MaterialBillItemRpt.Update(DbContext, entity);
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
            MaterialBillItem entity = MaterialBillItemRpt.Get(DbContext, key);
            MaterialBillItemRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual MaterialBillItemInfo Load(string key)
         {
            MaterialBillItemInfo info = new MaterialBillItemInfo();
            using (var DbContext = new MRPDbContext())
            {
            MaterialBillItem entity = MaterialBillItemRpt.Get(DbContext, key);
            DESwap.MaterialBillItemETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<MaterialBillItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialBillItem> eList = new List<MaterialBillItem>();
            infoList.ForEach(x =>
            {
                MaterialBillItem entity = new MaterialBillItem();
                DESwap. MaterialBillItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialBillItemRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<MaterialBillItemInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialBillItem> eList = new List<MaterialBillItem>();
            infoList.ForEach(x =>
            {
                MaterialBillItem entity = new MaterialBillItem();
                DESwap. MaterialBillItemDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialBillItemRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialBillItem> eList = new List<MaterialBillItem>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                MaterialBillItem entity = MaterialBillItemRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            MaterialBillItemRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<MaterialBillItemInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<MaterialBillItem> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.MaterialBillItem
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
            List<MaterialBillItemInfo> ilist = new List<MaterialBillItemInfo>();
            list.ForEach(x =>
            {
                MaterialBillItemInfo info = new MaterialBillItemInfo();
                DESwap.MaterialBillItemETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

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

    public class MaterialWareStockBaseService
    { 

         protected virtual MaterialWareStockRpt MaterialWareStockRpt { get; set; }

         public virtual OperationResult Create(MaterialWareStockInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              MaterialWareStock entity = new MaterialWareStock();
              DESwap.MaterialWareStockDTE(info, entity);
              MaterialWareStockRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(MaterialWareStockInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            MaterialWareStock entity = MaterialWareStockRpt.Get(DbContext, info.Id);
            DESwap.MaterialWareStockDTE(info, entity);
            MaterialWareStockRpt.Update(DbContext, entity);
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
            MaterialWareStock entity = MaterialWareStockRpt.Get(DbContext, key);
            MaterialWareStockRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual MaterialWareStockInfo Load(string key)
         {
            MaterialWareStockInfo info = new MaterialWareStockInfo();
            using (var DbContext = new MRPDbContext())
            {
            MaterialWareStock entity = MaterialWareStockRpt.Get(DbContext, key);
            DESwap.MaterialWareStockETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<MaterialWareStockInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialWareStock> eList = new List<MaterialWareStock>();
            infoList.ForEach(x =>
            {
                MaterialWareStock entity = new MaterialWareStock();
                DESwap. MaterialWareStockDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialWareStockRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<MaterialWareStockInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialWareStock> eList = new List<MaterialWareStock>();
            infoList.ForEach(x =>
            {
                MaterialWareStock entity = new MaterialWareStock();
                DESwap. MaterialWareStockDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialWareStockRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialWareStock> eList = new List<MaterialWareStock>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                MaterialWareStock entity = MaterialWareStockRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            MaterialWareStockRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<MaterialWareStockInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<MaterialWareStock> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.MaterialWareStock
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
            List<MaterialWareStockInfo> ilist = new List<MaterialWareStockInfo>();
            list.ForEach(x =>
            {
                MaterialWareStockInfo info = new MaterialWareStockInfo();
                DESwap.MaterialWareStockETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

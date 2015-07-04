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

    public class MaterialCatalogBaseService
    { 

         protected virtual MaterialCatalogRpt MaterialCatalogRpt { get; set; }

         public virtual OperationResult Create(MaterialCatalogInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              MaterialCatalog entity = new MaterialCatalog();
              DESwap.MaterialCatalogDTE(info, entity);
              MaterialCatalogRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(MaterialCatalogInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            MaterialCatalog entity = MaterialCatalogRpt.Get(DbContext, info.Id);
            DESwap.MaterialCatalogDTE(info, entity);
            MaterialCatalogRpt.Update(DbContext, entity);
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
            MaterialCatalog entity = MaterialCatalogRpt.Get(DbContext, key);
            MaterialCatalogRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual MaterialCatalogInfo Load(string key)
         {
            MaterialCatalogInfo info = new MaterialCatalogInfo();
            using (var DbContext = new MRPDbContext())
            {
            MaterialCatalog entity = MaterialCatalogRpt.Get(DbContext, key);
            DESwap.MaterialCatalogETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<MaterialCatalogInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialCatalog> eList = new List<MaterialCatalog>();
            infoList.ForEach(x =>
            {
                MaterialCatalog entity = new MaterialCatalog();
                DESwap. MaterialCatalogDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialCatalogRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<MaterialCatalogInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialCatalog> eList = new List<MaterialCatalog>();
            infoList.ForEach(x =>
            {
                MaterialCatalog entity = new MaterialCatalog();
                DESwap. MaterialCatalogDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialCatalogRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<MaterialCatalog> eList = new List<MaterialCatalog>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                MaterialCatalog entity = MaterialCatalogRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            MaterialCatalogRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<MaterialCatalogInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<MaterialCatalog> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.MaterialCatalog
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
            List<MaterialCatalogInfo> ilist = new List<MaterialCatalogInfo>();
            list.ForEach(x =>
            {
                MaterialCatalogInfo info = new MaterialCatalogInfo();
                DESwap.MaterialCatalogETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

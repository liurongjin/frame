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

    public class MaterialBaseService
    { 

         protected virtual MaterialRpt MaterialRpt { get; set; }

         public virtual OperationResult Create(MaterialInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
              Material entity = new Material();
              DESwap.MaterialDTE(info, entity);
              MaterialRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(MaterialInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new MRPDbContext())
            {
            Material entity = MaterialRpt.Get(DbContext, info.Id);
            DESwap.MaterialDTE(info, entity);
            MaterialRpt.Update(DbContext, entity);
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
            Material entity = MaterialRpt.Get(DbContext, key);
            MaterialRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual MaterialInfo Load(string key)
         {
            MaterialInfo info = new MaterialInfo();
            using (var DbContext = new MRPDbContext())
            {
            Material entity = MaterialRpt.Get(DbContext, key);
            DESwap.MaterialETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<MaterialInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Material> eList = new List<Material>();
            infoList.ForEach(x =>
            {
                Material entity = new Material();
                DESwap. MaterialDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<MaterialInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Material> eList = new List<Material>();
            infoList.ForEach(x =>
            {
                Material entity = new Material();
                DESwap. MaterialDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new MRPDbContext())
            {
            MaterialRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Material> eList = new List<Material>();
            using (var DbContext = new MRPDbContext())
            {
            keyList.ForEach(x =>
            {
                Material entity = MaterialRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            MaterialRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<MaterialInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<Material> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.Material
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
            List<MaterialInfo> ilist = new List<MaterialInfo>();
            list.ForEach(x =>
            {
                MaterialInfo info = new MaterialInfo();
                DESwap.MaterialETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

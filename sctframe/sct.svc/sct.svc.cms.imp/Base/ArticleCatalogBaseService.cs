using sct.cm.data;
using sct.dto.cms;
using sct.ent.cms;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Collections.Specialized;


namespace sct.svc.cms.imp
{

    public class ArticleCatalogBaseService
    { 

         protected virtual ArticleCatalogRpt ArticleCatalogRpt { get; set; }

         public virtual OperationResult Create(ArticleCatalogInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
              ArticleCatalog entity = new ArticleCatalog();
              DESwap.ArticleCatalogDTE(info, entity);
              ArticleCatalogRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ArticleCatalogInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
            ArticleCatalog entity = ArticleCatalogRpt.Get(DbContext, info.Id);
            DESwap.ArticleCatalogDTE(info, entity);
            ArticleCatalogRpt.Update(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(string key)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
            ArticleCatalog entity = ArticleCatalogRpt.Get(DbContext, key);
            ArticleCatalogRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ArticleCatalogInfo Load(string key)
         {
            ArticleCatalogInfo info = new ArticleCatalogInfo();
            using (var DbContext = new CmsDbContext())
            {
            ArticleCatalog entity = ArticleCatalogRpt.Get(DbContext, key);
            DESwap.ArticleCatalogETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ArticleCatalogInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleCatalog> eList = new List<ArticleCatalog>();
            infoList.ForEach(x =>
            {
                ArticleCatalog entity = new ArticleCatalog();
                DESwap. ArticleCatalogDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleCatalogRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ArticleCatalogInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleCatalog> eList = new List<ArticleCatalog>();
            infoList.ForEach(x =>
            {
                ArticleCatalog entity = new ArticleCatalog();
                DESwap. ArticleCatalogDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleCatalogRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleCatalog> eList = new List<ArticleCatalog>();
            using (var DbContext = new CmsDbContext())
            {
            keyList.ForEach(x =>
            {
                ArticleCatalog entity = ArticleCatalogRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ArticleCatalogRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ArticleCatalogInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ArticleCatalog> list = null;

            using (var DbContext = new CmsDbContext())
            {
            var query = from i in DbContext.ArticleCatalog
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
            List<ArticleCatalogInfo> ilist = new List<ArticleCatalogInfo>();
            list.ForEach(x =>
            {
                ArticleCatalogInfo info = new ArticleCatalogInfo();
                DESwap.ArticleCatalogETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

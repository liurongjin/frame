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

    public class ArticleBaseService
    { 

         protected virtual ArticleRpt ArticleRpt { get; set; }

         public virtual OperationResult Create(ArticleInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
              Article entity = new Article();
              DESwap.ArticleDTE(info, entity);
              ArticleRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ArticleInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
            Article entity = ArticleRpt.Get(DbContext, info.Id);
            DESwap.ArticleDTE(info, entity);
            ArticleRpt.Update(DbContext, entity);
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
            Article entity = ArticleRpt.Get(DbContext, key);
            ArticleRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ArticleInfo Load(string key)
         {
            ArticleInfo info = new ArticleInfo();
            using (var DbContext = new CmsDbContext())
            {
            Article entity = ArticleRpt.Get(DbContext, key);
            DESwap.ArticleETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ArticleInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Article> eList = new List<Article>();
            infoList.ForEach(x =>
            {
                Article entity = new Article();
                DESwap. ArticleDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ArticleInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Article> eList = new List<Article>();
            infoList.ForEach(x =>
            {
                Article entity = new Article();
                DESwap. ArticleDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Article> eList = new List<Article>();
            using (var DbContext = new CmsDbContext())
            {
            keyList.ForEach(x =>
            {
                Article entity = ArticleRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ArticleRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ArticleInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<Article> list = null;

            using (var DbContext = new CmsDbContext())
            {
            var query = from i in DbContext.Article
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
            List<ArticleInfo> ilist = new List<ArticleInfo>();
            list.ForEach(x =>
            {
                ArticleInfo info = new ArticleInfo();
                DESwap.ArticleETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

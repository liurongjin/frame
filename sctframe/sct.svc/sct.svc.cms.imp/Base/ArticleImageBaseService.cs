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

    public class ArticleImageBaseService
    { 

         protected virtual ArticleImageRpt ArticleImageRpt { get; set; }

         public virtual OperationResult Create(ArticleImageInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
              ArticleImage entity = new ArticleImage();
              DESwap.ArticleImageDTE(info, entity);
              ArticleImageRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ArticleImageInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
            ArticleImage entity = ArticleImageRpt.Get(DbContext, info.Id);
            DESwap.ArticleImageDTE(info, entity);
            ArticleImageRpt.Update(DbContext, entity);
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
            ArticleImage entity = ArticleImageRpt.Get(DbContext, key);
            ArticleImageRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ArticleImageInfo Load(string key)
         {
            ArticleImageInfo info = new ArticleImageInfo();
            using (var DbContext = new CmsDbContext())
            {
            ArticleImage entity = ArticleImageRpt.Get(DbContext, key);
            DESwap.ArticleImageETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ArticleImageInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleImage> eList = new List<ArticleImage>();
            infoList.ForEach(x =>
            {
                ArticleImage entity = new ArticleImage();
                DESwap. ArticleImageDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleImageRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ArticleImageInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleImage> eList = new List<ArticleImage>();
            infoList.ForEach(x =>
            {
                ArticleImage entity = new ArticleImage();
                DESwap. ArticleImageDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleImageRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleImage> eList = new List<ArticleImage>();
            using (var DbContext = new CmsDbContext())
            {
            keyList.ForEach(x =>
            {
                ArticleImage entity = ArticleImageRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ArticleImageRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ArticleImageInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ArticleImage> list = null;

            using (var DbContext = new CmsDbContext())
            {
            var query = from i in DbContext.ArticleImage
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
            List<ArticleImageInfo> ilist = new List<ArticleImageInfo>();
            list.ForEach(x =>
            {
                ArticleImageInfo info = new ArticleImageInfo();
                DESwap.ArticleImageETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

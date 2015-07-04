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

    public class ArticleVideoBaseService
    { 

         protected virtual ArticleVideoRpt ArticleVideoRpt { get; set; }

         public virtual OperationResult Create(ArticleVideoInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
              ArticleVideo entity = new ArticleVideo();
              DESwap.ArticleVideoDTE(info, entity);
              ArticleVideoRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ArticleVideoInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
            ArticleVideo entity = ArticleVideoRpt.Get(DbContext, info.Id);
            DESwap.ArticleVideoDTE(info, entity);
            ArticleVideoRpt.Update(DbContext, entity);
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
            ArticleVideo entity = ArticleVideoRpt.Get(DbContext, key);
            ArticleVideoRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ArticleVideoInfo Load(string key)
         {
            ArticleVideoInfo info = new ArticleVideoInfo();
            using (var DbContext = new CmsDbContext())
            {
            ArticleVideo entity = ArticleVideoRpt.Get(DbContext, key);
            DESwap.ArticleVideoETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ArticleVideoInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleVideo> eList = new List<ArticleVideo>();
            infoList.ForEach(x =>
            {
                ArticleVideo entity = new ArticleVideo();
                DESwap. ArticleVideoDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleVideoRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ArticleVideoInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleVideo> eList = new List<ArticleVideo>();
            infoList.ForEach(x =>
            {
                ArticleVideo entity = new ArticleVideo();
                DESwap. ArticleVideoDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleVideoRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleVideo> eList = new List<ArticleVideo>();
            using (var DbContext = new CmsDbContext())
            {
            keyList.ForEach(x =>
            {
                ArticleVideo entity = ArticleVideoRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ArticleVideoRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ArticleVideoInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ArticleVideo> list = null;

            using (var DbContext = new CmsDbContext())
            {
            var query = from i in DbContext.ArticleVideo
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
            List<ArticleVideoInfo> ilist = new List<ArticleVideoInfo>();
            list.ForEach(x =>
            {
                ArticleVideoInfo info = new ArticleVideoInfo();
                DESwap.ArticleVideoETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

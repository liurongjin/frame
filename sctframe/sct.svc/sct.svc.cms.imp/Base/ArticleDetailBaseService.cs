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

    public class ArticleDetailBaseService
    { 

         protected virtual ArticleDetailRpt ArticleDetailRpt { get; set; }

         public virtual OperationResult Create(ArticleDetailInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
              ArticleDetail entity = new ArticleDetail();
              DESwap.ArticleDetailDTE(info, entity);
              ArticleDetailRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ArticleDetailInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
            ArticleDetail entity = ArticleDetailRpt.Get(DbContext, info.Id);
            DESwap.ArticleDetailDTE(info, entity);
            ArticleDetailRpt.Update(DbContext, entity);
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
            ArticleDetail entity = ArticleDetailRpt.Get(DbContext, key);
            ArticleDetailRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ArticleDetailInfo Load(string key)
         {
            ArticleDetailInfo info = new ArticleDetailInfo();
            using (var DbContext = new CmsDbContext())
            {
            ArticleDetail entity = ArticleDetailRpt.Get(DbContext, key);
            DESwap.ArticleDetailETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ArticleDetailInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleDetail> eList = new List<ArticleDetail>();
            infoList.ForEach(x =>
            {
                ArticleDetail entity = new ArticleDetail();
                DESwap. ArticleDetailDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleDetailRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ArticleDetailInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleDetail> eList = new List<ArticleDetail>();
            infoList.ForEach(x =>
            {
                ArticleDetail entity = new ArticleDetail();
                DESwap. ArticleDetailDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleDetailRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleDetail> eList = new List<ArticleDetail>();
            using (var DbContext = new CmsDbContext())
            {
            keyList.ForEach(x =>
            {
                ArticleDetail entity = ArticleDetailRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ArticleDetailRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ArticleDetailInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ArticleDetail> list = null;

            using (var DbContext = new CmsDbContext())
            {
            var query = from i in DbContext.ArticleDetail
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
            List<ArticleDetailInfo> ilist = new List<ArticleDetailInfo>();
            list.ForEach(x =>
            {
                ArticleDetailInfo info = new ArticleDetailInfo();
                DESwap.ArticleDetailETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

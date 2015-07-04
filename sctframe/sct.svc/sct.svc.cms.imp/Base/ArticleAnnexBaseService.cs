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

    public class ArticleAnnexBaseService
    { 

         protected virtual ArticleAnnexRpt ArticleAnnexRpt { get; set; }

         public virtual OperationResult Create(ArticleAnnexInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
              ArticleAnnex entity = new ArticleAnnex();
              DESwap.ArticleAnnexDTE(info, entity);
              ArticleAnnexRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ArticleAnnexInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
            ArticleAnnex entity = ArticleAnnexRpt.Get(DbContext, info.Id);
            DESwap.ArticleAnnexDTE(info, entity);
            ArticleAnnexRpt.Update(DbContext, entity);
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
            ArticleAnnex entity = ArticleAnnexRpt.Get(DbContext, key);
            ArticleAnnexRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ArticleAnnexInfo Load(string key)
         {
            ArticleAnnexInfo info = new ArticleAnnexInfo();
            using (var DbContext = new CmsDbContext())
            {
            ArticleAnnex entity = ArticleAnnexRpt.Get(DbContext, key);
            DESwap.ArticleAnnexETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ArticleAnnexInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleAnnex> eList = new List<ArticleAnnex>();
            infoList.ForEach(x =>
            {
                ArticleAnnex entity = new ArticleAnnex();
                DESwap. ArticleAnnexDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleAnnexRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ArticleAnnexInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleAnnex> eList = new List<ArticleAnnex>();
            infoList.ForEach(x =>
            {
                ArticleAnnex entity = new ArticleAnnex();
                DESwap. ArticleAnnexDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            ArticleAnnexRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ArticleAnnex> eList = new List<ArticleAnnex>();
            using (var DbContext = new CmsDbContext())
            {
            keyList.ForEach(x =>
            {
                ArticleAnnex entity = ArticleAnnexRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ArticleAnnexRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ArticleAnnexInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ArticleAnnex> list = null;

            using (var DbContext = new CmsDbContext())
            {
            var query = from i in DbContext.ArticleAnnex
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
            List<ArticleAnnexInfo> ilist = new List<ArticleAnnexInfo>();
            list.ForEach(x =>
            {
                ArticleAnnexInfo info = new ArticleAnnexInfo();
                DESwap.ArticleAnnexETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

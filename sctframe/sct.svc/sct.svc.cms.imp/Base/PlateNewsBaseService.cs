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

    public class PlateNewsBaseService
    { 

         protected virtual PlateNewsRpt PlateNewsRpt { get; set; }

         public virtual OperationResult Create(PlateNewsInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
              PlateNews entity = new PlateNews();
              DESwap.PlateNewsDTE(info, entity);
              PlateNewsRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(PlateNewsInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
            PlateNews entity = PlateNewsRpt.Get(DbContext, info.Id);
            DESwap.PlateNewsDTE(info, entity);
            PlateNewsRpt.Update(DbContext, entity);
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
            PlateNews entity = PlateNewsRpt.Get(DbContext, key);
            PlateNewsRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual PlateNewsInfo Load(string key)
         {
            PlateNewsInfo info = new PlateNewsInfo();
            using (var DbContext = new CmsDbContext())
            {
            PlateNews entity = PlateNewsRpt.Get(DbContext, key);
            DESwap.PlateNewsETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<PlateNewsInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<PlateNews> eList = new List<PlateNews>();
            infoList.ForEach(x =>
            {
                PlateNews entity = new PlateNews();
                DESwap. PlateNewsDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            PlateNewsRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<PlateNewsInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<PlateNews> eList = new List<PlateNews>();
            infoList.ForEach(x =>
            {
                PlateNews entity = new PlateNews();
                DESwap. PlateNewsDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            PlateNewsRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<PlateNews> eList = new List<PlateNews>();
            using (var DbContext = new CmsDbContext())
            {
            keyList.ForEach(x =>
            {
                PlateNews entity = PlateNewsRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            PlateNewsRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<PlateNewsInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<PlateNews> list = null;

            using (var DbContext = new CmsDbContext())
            {
            var query = from i in DbContext.PlateNews
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
            List<PlateNewsInfo> ilist = new List<PlateNewsInfo>();
            list.ForEach(x =>
            {
                PlateNewsInfo info = new PlateNewsInfo();
                DESwap.PlateNewsETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

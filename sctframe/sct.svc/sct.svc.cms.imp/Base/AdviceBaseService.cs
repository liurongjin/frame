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

    public class AdviceBaseService
    { 

         protected virtual AdviceRpt AdviceRpt { get; set; }

         public virtual OperationResult Create(AdviceInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
              Advice entity = new Advice();
              DESwap.AdviceDTE(info, entity);
              AdviceRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(AdviceInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
            Advice entity = AdviceRpt.Get(DbContext, info.Id);
            DESwap.AdviceDTE(info, entity);
            AdviceRpt.Update(DbContext, entity);
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
            Advice entity = AdviceRpt.Get(DbContext, key);
            AdviceRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual AdviceInfo Load(string key)
         {
            AdviceInfo info = new AdviceInfo();
            using (var DbContext = new CmsDbContext())
            {
            Advice entity = AdviceRpt.Get(DbContext, key);
            DESwap.AdviceETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<AdviceInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Advice> eList = new List<Advice>();
            infoList.ForEach(x =>
            {
                Advice entity = new Advice();
                DESwap. AdviceDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            AdviceRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<AdviceInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Advice> eList = new List<Advice>();
            infoList.ForEach(x =>
            {
                Advice entity = new Advice();
                DESwap. AdviceDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            AdviceRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Advice> eList = new List<Advice>();
            using (var DbContext = new CmsDbContext())
            {
            keyList.ForEach(x =>
            {
                Advice entity = AdviceRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            AdviceRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<AdviceInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<Advice> list = null;

            using (var DbContext = new CmsDbContext())
            {
            var query = from i in DbContext.Advice
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
            List<AdviceInfo> ilist = new List<AdviceInfo>();
            list.ForEach(x =>
            {
                AdviceInfo info = new AdviceInfo();
                DESwap.AdviceETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

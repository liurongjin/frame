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

    public class FriendLinkBaseService
    { 

         protected virtual FriendLinkRpt FriendLinkRpt { get; set; }

         public virtual OperationResult Create(FriendLinkInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
              FriendLink entity = new FriendLink();
              DESwap.FriendLinkDTE(info, entity);
              FriendLinkRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(FriendLinkInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
            FriendLink entity = FriendLinkRpt.Get(DbContext, info.Id);
            DESwap.FriendLinkDTE(info, entity);
            FriendLinkRpt.Update(DbContext, entity);
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
            FriendLink entity = FriendLinkRpt.Get(DbContext, key);
            FriendLinkRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual FriendLinkInfo Load(string key)
         {
            FriendLinkInfo info = new FriendLinkInfo();
            using (var DbContext = new CmsDbContext())
            {
            FriendLink entity = FriendLinkRpt.Get(DbContext, key);
            DESwap.FriendLinkETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<FriendLinkInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<FriendLink> eList = new List<FriendLink>();
            infoList.ForEach(x =>
            {
                FriendLink entity = new FriendLink();
                DESwap. FriendLinkDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            FriendLinkRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<FriendLinkInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<FriendLink> eList = new List<FriendLink>();
            infoList.ForEach(x =>
            {
                FriendLink entity = new FriendLink();
                DESwap. FriendLinkDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            FriendLinkRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<FriendLink> eList = new List<FriendLink>();
            using (var DbContext = new CmsDbContext())
            {
            keyList.ForEach(x =>
            {
                FriendLink entity = FriendLinkRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            FriendLinkRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<FriendLinkInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<FriendLink> list = null;

            using (var DbContext = new CmsDbContext())
            {
            var query = from i in DbContext.FriendLink
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
            List<FriendLinkInfo> ilist = new List<FriendLinkInfo>();
            list.ForEach(x =>
            {
                FriendLinkInfo info = new FriendLinkInfo();
                DESwap.FriendLinkETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

using sct.cm.data;
using sct.dto.uc;
using sct.ent.uc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Collections.Specialized;


namespace sct.svc.uc.imp
{

    public class ClientTypeBaseService
    { 

         protected virtual ClientTypeRpt ClientTypeRpt { get; set; }

         public virtual OperationResult Create(ClientTypeInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              ClientType entity = new ClientType();
              DESwap.ClientTypeDTE(info, entity);
              ClientTypeRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(ClientTypeInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            ClientType entity = ClientTypeRpt.Get(DbContext, info.Id);
            DESwap.ClientTypeDTE(info, entity);
            ClientTypeRpt.Update(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(string key)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            ClientType entity = ClientTypeRpt.Get(DbContext, key);
            ClientTypeRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual ClientTypeInfo Load(string key)
         {
            ClientTypeInfo info = new ClientTypeInfo();
            using (var DbContext = new UCDbContext())
            {
            ClientType entity = ClientTypeRpt.Get(DbContext, key);
            DESwap.ClientTypeETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<ClientTypeInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ClientType> eList = new List<ClientType>();
            infoList.ForEach(x =>
            {
                ClientType entity = new ClientType();
                DESwap. ClientTypeDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            ClientTypeRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<ClientTypeInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ClientType> eList = new List<ClientType>();
            infoList.ForEach(x =>
            {
                ClientType entity = new ClientType();
                DESwap. ClientTypeDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            ClientTypeRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<ClientType> eList = new List<ClientType>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                ClientType entity = ClientTypeRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            ClientTypeRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<ClientTypeInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<ClientType> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.ClientType
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
            List<ClientTypeInfo> ilist = new List<ClientTypeInfo>();
            list.ForEach(x =>
            {
                ClientTypeInfo info = new ClientTypeInfo();
                DESwap.ClientTypeETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

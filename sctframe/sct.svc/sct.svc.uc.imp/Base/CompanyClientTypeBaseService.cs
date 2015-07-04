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

    public class CompanyClientTypeBaseService
    { 

         protected virtual CompanyClientTypeRpt CompanyClientTypeRpt { get; set; }

         public virtual OperationResult Create(CompanyClientTypeInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              CompanyClientType entity = new CompanyClientType();
              DESwap.CompanyClientTypeDTE(info, entity);
              CompanyClientTypeRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(CompanyClientTypeInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            CompanyClientType entity = CompanyClientTypeRpt.Get(DbContext, info.Id);
            DESwap.CompanyClientTypeDTE(info, entity);
            CompanyClientTypeRpt.Update(DbContext, entity);
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
            CompanyClientType entity = CompanyClientTypeRpt.Get(DbContext, key);
            CompanyClientTypeRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual CompanyClientTypeInfo Load(string key)
         {
            CompanyClientTypeInfo info = new CompanyClientTypeInfo();
            using (var DbContext = new UCDbContext())
            {
            CompanyClientType entity = CompanyClientTypeRpt.Get(DbContext, key);
            DESwap.CompanyClientTypeETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<CompanyClientTypeInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<CompanyClientType> eList = new List<CompanyClientType>();
            infoList.ForEach(x =>
            {
                CompanyClientType entity = new CompanyClientType();
                DESwap. CompanyClientTypeDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            CompanyClientTypeRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<CompanyClientTypeInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<CompanyClientType> eList = new List<CompanyClientType>();
            infoList.ForEach(x =>
            {
                CompanyClientType entity = new CompanyClientType();
                DESwap. CompanyClientTypeDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            CompanyClientTypeRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<CompanyClientType> eList = new List<CompanyClientType>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                CompanyClientType entity = CompanyClientTypeRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            CompanyClientTypeRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<CompanyClientTypeInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<CompanyClientType> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.CompanyClientType
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
            List<CompanyClientTypeInfo> ilist = new List<CompanyClientTypeInfo>();
            list.ForEach(x =>
            {
                CompanyClientTypeInfo info = new CompanyClientTypeInfo();
                DESwap.CompanyClientTypeETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

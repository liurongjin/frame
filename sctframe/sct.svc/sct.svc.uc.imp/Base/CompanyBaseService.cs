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

    public class CompanyBaseService
    { 

         protected virtual CompanyRpt CompanyRpt { get; set; }

         public virtual OperationResult Create(CompanyInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              Company entity = new Company();
              DESwap.CompanyDTE(info, entity);
              CompanyRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(CompanyInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            Company entity = CompanyRpt.Get(DbContext, info.Id);
            DESwap.CompanyDTE(info, entity);
            CompanyRpt.Update(DbContext, entity);
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
            Company entity = CompanyRpt.Get(DbContext, key);
            CompanyRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual CompanyInfo Load(string key)
         {
            CompanyInfo info = new CompanyInfo();
            using (var DbContext = new UCDbContext())
            {
            Company entity = CompanyRpt.Get(DbContext, key);
            DESwap.CompanyETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<CompanyInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Company> eList = new List<Company>();
            infoList.ForEach(x =>
            {
                Company entity = new Company();
                DESwap. CompanyDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            CompanyRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<CompanyInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Company> eList = new List<Company>();
            infoList.ForEach(x =>
            {
                Company entity = new Company();
                DESwap. CompanyDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            CompanyRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Company> eList = new List<Company>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                Company entity = CompanyRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            CompanyRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<CompanyInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<Company> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.Company
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
            List<CompanyInfo> ilist = new List<CompanyInfo>();
            list.ForEach(x =>
            {
                CompanyInfo info = new CompanyInfo();
                DESwap.CompanyETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

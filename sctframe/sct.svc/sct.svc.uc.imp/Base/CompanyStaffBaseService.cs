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

    public class CompanyStaffBaseService
    { 

         protected virtual CompanyStaffRpt CompanyStaffRpt { get; set; }

         public virtual OperationResult Create(CompanyStaffInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              CompanyStaff entity = new CompanyStaff();
              DESwap.CompanyStaffDTE(info, entity);
              CompanyStaffRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(CompanyStaffInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            CompanyStaff entity = CompanyStaffRpt.Get(DbContext, info.Id);
            DESwap.CompanyStaffDTE(info, entity);
            CompanyStaffRpt.Update(DbContext, entity);
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
            CompanyStaff entity = CompanyStaffRpt.Get(DbContext, key);
            CompanyStaffRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual CompanyStaffInfo Load(string key)
         {
            CompanyStaffInfo info = new CompanyStaffInfo();
            using (var DbContext = new UCDbContext())
            {
            CompanyStaff entity = CompanyStaffRpt.Get(DbContext, key);
            DESwap.CompanyStaffETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<CompanyStaffInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<CompanyStaff> eList = new List<CompanyStaff>();
            infoList.ForEach(x =>
            {
                CompanyStaff entity = new CompanyStaff();
                DESwap. CompanyStaffDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            CompanyStaffRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<CompanyStaffInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<CompanyStaff> eList = new List<CompanyStaff>();
            infoList.ForEach(x =>
            {
                CompanyStaff entity = new CompanyStaff();
                DESwap. CompanyStaffDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            CompanyStaffRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<CompanyStaff> eList = new List<CompanyStaff>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                CompanyStaff entity = CompanyStaffRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            CompanyStaffRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<CompanyStaffInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<CompanyStaff> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.CompanyStaff
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
            List<CompanyStaffInfo> ilist = new List<CompanyStaffInfo>();
            list.ForEach(x =>
            {
                CompanyStaffInfo info = new CompanyStaffInfo();
                DESwap.CompanyStaffETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

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

    public class DepartmentBaseService
    { 

         protected virtual DepartmentRpt DepartmentRpt { get; set; }

         public virtual OperationResult Create(DepartmentInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              Department entity = new Department();
              DESwap.DepartmentDTE(info, entity);
              DepartmentRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(DepartmentInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            Department entity = DepartmentRpt.Get(DbContext, info.Id);
            DESwap.DepartmentDTE(info, entity);
            DepartmentRpt.Update(DbContext, entity);
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
            Department entity = DepartmentRpt.Get(DbContext, key);
            DepartmentRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual DepartmentInfo Load(string key)
         {
            DepartmentInfo info = new DepartmentInfo();
            using (var DbContext = new UCDbContext())
            {
            Department entity = DepartmentRpt.Get(DbContext, key);
            DESwap.DepartmentETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<DepartmentInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Department> eList = new List<Department>();
            infoList.ForEach(x =>
            {
                Department entity = new Department();
                DESwap. DepartmentDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            DepartmentRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<DepartmentInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Department> eList = new List<Department>();
            infoList.ForEach(x =>
            {
                Department entity = new Department();
                DESwap. DepartmentDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            DepartmentRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Department> eList = new List<Department>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                Department entity = DepartmentRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            DepartmentRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<DepartmentInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<Department> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.Department
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
            List<DepartmentInfo> ilist = new List<DepartmentInfo>();
            list.ForEach(x =>
            {
                DepartmentInfo info = new DepartmentInfo();
                DESwap.DepartmentETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

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

    public class MenuBaseService
    { 

         protected virtual MenuRpt MenuRpt { get; set; }

         public virtual OperationResult Create(MenuInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
              Menu entity = new Menu();
              DESwap.MenuDTE(info, entity);
              MenuRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(MenuInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new UCDbContext())
            {
            Menu entity = MenuRpt.Get(DbContext, info.Id);
            DESwap.MenuDTE(info, entity);
            MenuRpt.Update(DbContext, entity);
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
            Menu entity = MenuRpt.Get(DbContext, key);
            MenuRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual MenuInfo Load(string key)
         {
            MenuInfo info = new MenuInfo();
            using (var DbContext = new UCDbContext())
            {
            Menu entity = MenuRpt.Get(DbContext, key);
            DESwap.MenuETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<MenuInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Menu> eList = new List<Menu>();
            infoList.ForEach(x =>
            {
                Menu entity = new Menu();
                DESwap. MenuDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            MenuRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<MenuInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Menu> eList = new List<Menu>();
            infoList.ForEach(x =>
            {
                Menu entity = new Menu();
                DESwap. MenuDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new UCDbContext())
            {
            MenuRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Menu> eList = new List<Menu>();
            using (var DbContext = new UCDbContext())
            {
            keyList.ForEach(x =>
            {
                Menu entity = MenuRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            MenuRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<MenuInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<Menu> list = null;

            using (var DbContext = new UCDbContext())
            {
            var query = from i in DbContext.Menu
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
            List<MenuInfo> ilist = new List<MenuInfo>();
            list.ForEach(x =>
            {
                MenuInfo info = new MenuInfo();
                DESwap.MenuETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

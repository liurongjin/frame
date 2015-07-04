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

    public class PlateBaseService
    { 

         protected virtual PlateRpt PlateRpt { get; set; }

         public virtual OperationResult Create(PlateInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
              Plate entity = new Plate();
              DESwap.PlateDTE(info, entity);
              PlateRpt.Insert(DbContext, entity);
              DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

         public virtual OperationResult Modify(PlateInfo info)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
            Plate entity = PlateRpt.Get(DbContext, info.Id);
            DESwap.PlateDTE(info, entity);
            PlateRpt.Update(DbContext, entity);
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
            Plate entity = PlateRpt.Get(DbContext, key);
            PlateRpt.Delete(DbContext, entity);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual PlateInfo Load(string key)
         {
            PlateInfo info = new PlateInfo();
            using (var DbContext = new CmsDbContext())
            {
            Plate entity = PlateRpt.Get(DbContext, key);
            DESwap.PlateETD(entity,info);
            }
            return info;
         }

         public virtual OperationResult Create(IEnumerable<PlateInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Plate> eList = new List<Plate>();
            infoList.ForEach(x =>
            {
                Plate entity = new Plate();
                DESwap. PlateDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            PlateRpt.Insert(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Modify(IEnumerable<PlateInfo> infoList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Plate> eList = new List<Plate>();
            infoList.ForEach(x =>
            {
                Plate entity = new Plate();
                DESwap. PlateDTE(x, entity);
                eList.Add(entity);
            });
            using (var DbContext = new CmsDbContext())
            {
            PlateRpt.Update(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual OperationResult Remove(IEnumerable<string> keyList)
         {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            List<Plate> eList = new List<Plate>();
            using (var DbContext = new CmsDbContext())
            {
            keyList.ForEach(x =>
            {
                Plate entity = PlateRpt.Get(DbContext, x);
                eList.Add(entity);
            });
            PlateRpt.Delete(DbContext, eList);
            DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
         }

         public virtual List<PlateInfo>  ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection)
         {

            List<Plate> list = null;

            using (var DbContext = new CmsDbContext())
            {
            var query = from i in DbContext.Plate
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
            List<PlateInfo> ilist = new List<PlateInfo>();
            list.ForEach(x =>
            {
                PlateInfo info = new PlateInfo();
                DESwap.PlateETD(x, info);
                ilist.Add(info);
            });
            #endregion

            return ilist;;
         }

    }

}

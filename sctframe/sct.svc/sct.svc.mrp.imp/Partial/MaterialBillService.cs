using sct.cm.data;
using sct.dto.mrp;
using sct.ent.mrp;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Collections.Specialized;


namespace sct.svc.mrp.imp
{

    public  class MaterialBillService : MaterialBillBaseService,IMaterialBillService
    { 

         public PageResult<MaterialBillInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
         {
            PageResult<MaterialBillInfo> result = new PageResult<MaterialBillInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<MaterialBill> list = null;

            using (var DbContext = new MRPDbContext())
            {
            var query = from i in DbContext.MaterialBill
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

            result.TotalRecords = query.Count();

            #region 排序
            foreach (string sort in sortCollection)
            {
                string direct = string.Empty;
                switch (sort.ToLower())
                {
                    case "createtime":
                        if (direct.ToLower().Equals("asc"))
                        {
                            query = query.OrderBy(x => new { x.SYS_CreateTime }).Skip(skip).Take(take);
                        }
                        else
                        {
                            query = query.OrderByDescending(x => new { x.SYS_CreateTime }).Skip(skip).Take(take);
                        }
                        break;
                    default:
                        query = query.OrderByDescending(x => new { x.SYS_OrderSeq }).Skip(skip).Take(take);
                        break;
                }
            }
           list = query.ToList();
            }
            #endregion
            #region linq to entity
            List<MaterialBillInfo> ilist = new List<MaterialBillInfo>();
            list.ForEach(x =>
            {
                MaterialBillInfo info = new MaterialBillInfo();
                DESwap.MaterialBillETD(x, info);
                ilist.Add(info);
            });
            #endregion

            result.PageSize = pageSize;
            result.PageNumber = pageNumber;
            result.Data = ilist;
            return result;;
         }

    }

}
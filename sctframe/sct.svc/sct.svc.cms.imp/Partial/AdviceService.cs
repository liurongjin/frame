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

    public class AdviceService : AdviceBaseService, IAdviceService
    {

        public PageResult<AdviceInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {
            PageResult<AdviceInfo> result = new PageResult<AdviceInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
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
                        case "title":
                            query = query.Where(x => x.Title.Contains(condition));
                            break;
                        case "language":
                            int language = Convert.ToInt32(condition);
                            query = query.Where(x => x.Language.Equals(language));
                            break;
                        case "state":
                            int state = Convert.ToInt32(condition);
                            query = query.Where(x => x.State.Equals(state));
                            break;
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
                        case "title":
                            if (direct.ToLower().Equals("asc"))
                            {
                                query = query.OrderBy(x => x.Title).Skip(skip).Take(take);
                            }
                            else
                            {
                                query = query.OrderByDescending(x => x.Title).Skip(skip).Take(take);
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
            List<AdviceInfo> ilist = new List<AdviceInfo>();
            list.ForEach(x =>
            {
                AdviceInfo info = new AdviceInfo();
                DESwap.AdviceETD(x, info);
                ilist.Add(info);
            });
            #endregion

            result.PageSize = pageSize;
            result.PageNumber = pageNumber;
            result.Data = ilist;
            return result; ;
        }

        public override OperationResult Create(AdviceInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
                Advice entity = new Advice();
                DESwap.AdviceDTE(info, entity);
                /*需要设默认值*/
                entity.HandleTime = DateTime.Now;
                AdviceRpt.Insert(DbContext, entity);
                DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

        public override OperationResult Modify(AdviceInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
                Advice entity = AdviceRpt.Get(DbContext, info.Id);
                DESwap.AdviceDTE(info, entity);
                /*需要设默认值*/
                entity.HandleTime = DateTime.Now;
                AdviceRpt.Update(DbContext, entity);
                DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

    }

}

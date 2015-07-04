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

    public class ArticleService : ArticleBaseService, IArticleService
    {
        protected ArticleImageRpt ArticleImageRpt { get; set; }

        protected ArticleDetailRpt ArticleDetailRpt { get; set; }

        protected ArticleVideoRpt ArticleVideoRpt { get; set; }

        public PageResult<ArticleInfo> ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize)
        {
            PageResult<ArticleInfo> result = new PageResult<ArticleInfo>();
            int skip = (pageNumber - 1) * pageSize;
            int take = pageSize;
            List<ArticleInfo> list = null;

            using (var DbContext = new CmsDbContext())
            {
                var query = from i in DbContext.Article
                            join ac in DbContext.ArticleCatalog on i.ArticleCatalogId equals ac.Id
                            select new ArticleInfo()
                            {
                                Id = i.Id,
                                Title = i.Title,
                                FormDate = i.FormDate,
                                ArticleType = i.ArticleType,
                                ArticleCatalogId = i.ArticleCatalogId,
                                SignImage = i.SignImage,
                                SYS_IsValid = i.SYS_IsValid,
                                SYS_OrderSeq = i.SYS_OrderSeq,
                                SYS_AppId = i.SYS_AppId,
                                SYS_StaffId = i.SYS_StaffId,
                                SYS_StationId = i.SYS_StationId,
                                SYS_DepartmentId = i.SYS_DepartmentId,
                                SYS_CompanyId = i.SYS_CompanyId,
                                SYS_CreateTime = i.SYS_CreateTime,
                                ArticleCatalogName = ac.Name
                            };


                #region 条件
                foreach (string key in searchCondtionCollection)
                {
                    string condition = searchCondtionCollection[key];
                    switch (key.ToLower())
                    {
                        case "titile":
                            query = query.Where(x => x.Title.Contains(condition));
                            break;
                        case "articlecatalogid":
                            query = query.Where(x => x.ArticleCatalogId.Equals(condition));
                            break;
                        case "isvalid":
                            int isvalid = Convert.ToInt32(condition);
                            query = query.Where(x => x.SYS_IsValid.Equals(isvalid));
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
                    string direct = sortCollection[sort];
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
                #endregion
                list = query.ToList();
            }


            result.PageSize = pageSize;
            result.PageNumber = pageNumber;
            result.Data = list;
            return result; ;
        }

        public override OperationResult Create(ArticleInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
                /*******保存资讯正文摘要*******/
                info.AuditTime = DateTime.Now;
                info.AuditState = (int)sct.dto.cms.EnumSet.ArticleAuditState.Edit;
                Article entity = new Article();
                DESwap.ArticleDTE(info, entity);
                ArticleRpt.Insert(DbContext, entity);

                if (info.ArticleType == (int)sct.dto.cms.EnumSet.ArticleType.Article)
                {
                    /*******保存正文*******/
                    if (info.ArticleDetail == null)
                    {
                        info.ArticleDetail = new ArticleDetailInfo();
                    }
                    info.ArticleDetail.Id = System.Guid.NewGuid().ToString();
                    info.ArticleDetail.ArticleId = info.Id;
                    ArticleDetail detail = new ArticleDetail();
                    DESwap.ArticleDetailDTE(info.ArticleDetail, detail);
                    ArticleDetailRpt.Insert(DbContext, detail);
                }
                else if (info.ArticleType == (int)sct.dto.cms.EnumSet.ArticleType.Picture)
                {
                    /*******保存图片*******/
                    List<ArticleImage> imagelist = new List<ArticleImage>();
                    foreach (var imageinfo in info.ArticleImageList)
                    {
                        if (string.IsNullOrEmpty(imageinfo.Id))
                        {
                            imageinfo.Id = System.Guid.NewGuid().ToString();
                            imageinfo.ArticleId = info.Id;
                            ArticleImage image = new ArticleImage();
                            DESwap.ArticleImageDTE(imageinfo, image);
                            imagelist.Add(image);
                        }
                    }
                    ArticleImageRpt.Insert(DbContext, imagelist);

                }
                else if (info.ArticleType == (int)sct.dto.cms.EnumSet.ArticleType.Video)
                {
                    /*******保存视频*******/
                    if (info.ArticleVideo == null)
                    {
                        info.ArticleVideo = new ArticleVideoInfo();
                    }
                    info.ArticleVideo.Id = System.Guid.NewGuid().ToString();
                    info.ArticleVideo.ArticleId = info.Id;
                    ArticleVideo video = new ArticleVideo();
                    DESwap.ArticleVideoDTE(info.ArticleVideo, video);
                    ArticleVideoRpt.Insert(DbContext, video);
                }
                /*异常数据未处理*/

                DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }

        public override ArticleInfo Load(string key)
        {

            ArticleInfo info = new ArticleInfo();
            using (var DbContext = new CmsDbContext())
            {

                var entity = ArticleRpt.Get(DbContext, key);
                if (entity != null)
                {
                    DESwap.ArticleETD(entity, info);

                    if (entity.ArticleType == (int)sct.dto.cms.EnumSet.ArticleType.Article)
                    {
                        /*******查询正文*******/
                        var detail = (from i in DbContext.ArticleDetail
                                      where i.ArticleId.Equals(entity.Id)
                                      select i).FirstOrDefault();
                        info.ArticleDetail = new ArticleDetailInfo();
                        if (detail != null)
                        {
                            DESwap.ArticleDetailETD(detail, info.ArticleDetail);
                        }
                        /********实例化相关对象属性****************/
                        info.ArticleImageList = new List<ArticleImageInfo>();
                        info.ArticleVideo = new ArticleVideoInfo();

                    }
                    else if (entity.ArticleType == (int)sct.dto.cms.EnumSet.ArticleType.Picture)
                    {
                        /*******查询图片*******/
                        var imagelist = (from i in DbContext.ArticleImage
                                         where i.ArticleId.Equals(entity.Id)
                                         select i).ToList();
                        info.ArticleImageList = new List<ArticleImageInfo>();
                        imagelist.ForEach(x =>
                        {
                            ArticleImageInfo image = new ArticleImageInfo();
                            DESwap.ArticleImageETD(x, image);
                            info.ArticleImageList.Add(image);
                        });

                        /********实例化相关对象属性****************/
                        info.ArticleDetail = new ArticleDetailInfo();
                        info.ArticleVideo = new ArticleVideoInfo();
                    }
                    else if (entity.ArticleType == (int)sct.dto.cms.EnumSet.ArticleType.Video)
                    {
                        /*******查询视频*******/
                        var video = (from i in DbContext.ArticleVideo
                                     where i.ArticleId.Equals(entity.Id)
                                     select i).FirstOrDefault();
                        info.ArticleVideo = new ArticleVideoInfo();
                        if (video != null)
                        {
                            DESwap.ArticleVideoETD(video, info.ArticleVideo);
                        }

                        /********实例化相关对象属性****************/
                        info.ArticleDetail = new ArticleDetailInfo();
                        info.ArticleImageList = new List<ArticleImageInfo>();
                    }
                }

            } 

            return info;
        }

        public override OperationResult Modify(ArticleInfo info)
        {
            OperationResult result = new OperationResult(OperationResultType.Error, "操作失败,请稍后重试!");
            using (var DbContext = new CmsDbContext())
            {
                /*******保存资讯正文摘要*******/
                Article article = ArticleRpt.Get(DbContext, info.Id);
                DESwap.ArticleDTE(info, article);
                ArticleRpt.Update(DbContext, article);

                if (info.ArticleType == (int)sct.dto.cms.EnumSet.ArticleType.Article)
                {
                    /*******保存正文*******/
                    ArticleDetail detail = ArticleDetailRpt.Get(DbContext, info.ArticleDetail.Id);
                    DESwap.ArticleDetailDTE(info.ArticleDetail, detail);
                    ArticleDetailRpt.Update(DbContext, detail);
                }
                else if (info.ArticleType == (int)sct.dto.cms.EnumSet.ArticleType.Picture)
                {
                    /*****新增列表*********/
                    List<ArticleImage> imageinsertlist = new List<ArticleImage>();
                    /*****例改列表*********/
                    List<ArticleImage> imageupdatelist = new List<ArticleImage>();
                    /*****删除列表*********/
                    List<ArticleImage> imagedeletelist = new List<ArticleImage>();


                    var imageexistlist = (from i in DbContext.ArticleImage
                                          where i.ArticleId.Equals(article.Id)
                                          select i).ToList();

                    /*************新增或修改******************/
                    foreach (var imageinfo in info.ArticleImageList)
                    {
                        if (string.IsNullOrEmpty(imageinfo.Id))
                        {
                            /*************新增************************/
                            imageinfo.Id = System.Guid.NewGuid().ToString();
                            imageinfo.ArticleId = info.Id;
                            ArticleImage image = new ArticleImage();
                            DESwap.ArticleImageDTE(imageinfo, image);
                            imageinsertlist.Add(image);
                        }
                        else
                        {
                            /****************修改********************/
                            var image = imageexistlist.Where(x => x.Id.Equals(imageinfo.Id)).FirstOrDefault();
                            if (image != null)
                            {
                                //ArticleImage image = ArticleImageRpt.Get(DbContext, imageinfo.Id);
                                DESwap.ArticleImageDTE(imageinfo, image);
                                imageupdatelist.Add(image);
                            }
                            else
                            {
                                imageinfo.Id = System.Guid.NewGuid().ToString();
                                imageinfo.ArticleId = info.Id;
                                image = new ArticleImage();
                                DESwap.ArticleImageDTE(imageinfo, image);
                                imageinsertlist.Add(image);
                            }
                        }
                    }

                    /*************删除******************/
                    foreach (var imageexist in imageexistlist)
                    {
                        var image = info.ArticleImageList.Where(x => x.Id.Equals(imageexist.Id)).FirstOrDefault();
                        if (image == null)
                        {
                            imagedeletelist.Add(imageexist);
                        }
                    }
                    ArticleImageRpt.Insert(DbContext, imageinsertlist);
                    ArticleImageRpt.Update(DbContext, imageupdatelist);
                    ArticleImageRpt.Delete(DbContext, imagedeletelist);


                }
                else if (info.ArticleType == (int)sct.dto.cms.EnumSet.ArticleType.Video)
                {
                    /*******保存视频*******/
                    ArticleVideo video = ArticleVideoRpt.Get(DbContext, info.ArticleVideo.Id);
                    DESwap.ArticleVideoDTE(info.ArticleVideo, video);
                    ArticleVideoRpt.Update(DbContext, video);
                }
                /*异常数据未处理*/

                DbContext.SaveChanges();
            }
            result.ResultType = OperationResultType.Success;
            result.Message = "操作成功!";
            return result;
        }
    }

}

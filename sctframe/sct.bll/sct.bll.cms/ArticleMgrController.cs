using sct.cm.data;
using sct.cm.util;
using sct.dto.cms;
using sct.svc.cms;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web.Mvc;
using System.Linq;
using System;


namespace sct.bll.cms
{
    public class ArticleMgrController : Controller
    {
        /// <summary>
        /// 资讯分类
        /// </summary>
        public IArticleCatalogService ArticleCatalogService = UnitFactory.CreateUnit("ArticleCatalogService") as IArticleCatalogService;

        /// <summary>
        /// 资讯内容
        /// </summary>
        public IArticleService ArticleService = UnitFactory.CreateUnit("ArticleService") as IArticleService;

        #region ArticleCatalog Manage
        #region Form
        public ViewResult ArticleCatalogList()
        {
            ViewBag.Title = "ArticleCatalogList";
            ViewBag.DicArticleCatalog = PublicMethod.ListAllArticleCatalog(ArticleCatalogService, null);
            return View();
        }

        public ViewResult ArticleCatalogForm(string key)
        {
            ViewBag.Title = "ArticleCatalogForm";
            ViewBag.DicArticleCatalog = PublicMethod.ListAllArticleCatalog(ArticleCatalogService, key);

            if (string.IsNullOrEmpty(key))
            {
                ArticleCatalogInfo info = new ArticleCatalogInfo();
                return View(info);
            }
            else
            {
                ArticleCatalogInfo info = ArticleCatalogService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListArticleCatalog(string name, string parentid, string iscolumn, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("name", name);
            }
            if (!string.IsNullOrEmpty(parentid))
            {
                nvc.Add("parentid", parentid);
            }

            if (!string.IsNullOrEmpty(iscolumn))
            {
                nvc.Add("iscolumn", iscolumn);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("name", "asc");
            PageResult<ArticleCatalogInfo> pr = ArticleCatalogService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<ArticleCatalogInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateArticleCatalogValid(string key, string validstatus)
        {
            ArticleCatalogInfo info = new ArticleCatalogInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = ArticleCatalogService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteArticleCatalog(string key)
        {
            ArticleCatalogInfo info = new ArticleCatalogInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = ArticleCatalogService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveArticleCatalog(ArticleCatalogInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = ArticleCatalogService.Create(info);
                }
                else
                {
                    opr = ArticleCatalogService.Modify(info);

                }
                ViewBag.DicArticleCatalog = PublicMethod.ListAllArticleCatalog(ArticleCatalogService, info.Id);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("ArticleCatalogForm", info);
        }
        #endregion
        #endregion



        #region Article Manage
        #region Form
        public ViewResult ArticleList()
        {
            ViewBag.Title = "ArticleList";
            ViewBag.DicArticleCatalog = PublicMethod.ListAllArticleCatalog(ArticleCatalogService, null);

            return View();
        }

        public ViewResult ArticleForm(string key)
        {
            ViewBag.Title = "ArticleForm";
            ViewBag.DicArticleCatalog = PublicMethod.ListAllArticleCatalog(ArticleCatalogService, null);

            if (string.IsNullOrEmpty(key))
            {
                ArticleInfo info = new ArticleInfo();
                info.ArticleDetail = new ArticleDetailInfo();
                info.ArticleVideo = new ArticleVideoInfo();
                info.ArticleImageList = new List<ArticleImageInfo>();
                return View(info);
            }
            else
            {
                ArticleInfo info = ArticleService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListArticle(string title, string articlecatalogid, string articletype, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(title))
            {
                nvc.Add("title", title);
            }

            if (!string.IsNullOrEmpty(articlecatalogid))
            {
                nvc.Add("articlecatalogid", articlecatalogid);
            }

            if (!string.IsNullOrEmpty(articletype))
            {
                nvc.Add("articletype", articletype);
            }


            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("createtime", "desc");
            PageResult<ArticleInfo> pr = ArticleService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<ArticleInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateArticleValid(string key, string validstatus)
        {
            ArticleInfo info = new ArticleInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = ArticleService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteArticle(string key)
        {
            ArticleInfo info = new ArticleInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = ArticleService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SaveArticle(ArticleInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = ArticleService.Create(info);
                }
                else
                {
                    opr = ArticleService.Modify(info);

                }
                ViewBag.DicArticleCatalog = PublicMethod.ListAllArticleCatalog(ArticleCatalogService, null);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("ArticleForm", info);
        }
        #endregion
        #endregion
    }
}

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
    public class PlateMgrController : Controller
    {
        /// <summary>
        /// 页面版块
        /// </summary>
        public IPlateService PlateService = UnitFactory.CreateUnit("PlateService") as IPlateService;

        /// <summary>
        /// 页面版块内容
        /// </summary>
        public IPlateNewsService PlateNewsService = UnitFactory.CreateUnit("PlateNewsService") as IPlateNewsService;

        /// <summary>
        /// 资讯分类
        /// </summary>
        public IArticleCatalogService ArticleCatalogService = UnitFactory.CreateUnit("ArticleCatalogService") as IArticleCatalogService;

  
        #region Plate Manage
        #region Form
        public ViewResult PlateList()
        {
            ViewBag.Title = "PlateList";
            ViewBag.DicPlate = PublicMethod.ListAllPlateInfo(PlateService, null);
            return View();
        }

        public ViewResult PlateForm(string key)
        {
            ViewBag.Title = "PlateForm";
            ViewBag.DicPlate = PublicMethod.ListAllPlateInfo(PlateService, key);
            if (string.IsNullOrEmpty(key))
            {
                PlateInfo info = new PlateInfo();
                return View(info);
            }
            else
            {
                PlateInfo info = PlateService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListPlate(string name, string parentid, string isvalid, int pagenumber, int pagesize)
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

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("name", "asc");
            PageResult<PlateInfo> pr = PlateService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<PlateInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdatePlateValid(string key, string validstatus)
        {
            PlateInfo info = new PlateInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = PlateService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeletePlate(string key)
        {
            PlateInfo info = new PlateInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = PlateService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SavePlate(PlateInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = PlateService.Create(info);
                }
                else
                {
                    opr = PlateService.Modify(info);

                }

                ViewBag.DicPlate = PublicMethod.ListAllPlateInfo(PlateService, info.Id);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("PlateForm", info);
        }
        #endregion
        #endregion

        #region PlateNews Manage
        #region Form
        public ViewResult PlateNewsList()
        {
            ViewBag.Title = "PlateNewsList";
            ViewBag.DicPlate = PublicMethod.ListAllPlateInfo(PlateService, null); ;
            ViewBag.DicArticleCatalog = PublicMethod.ListAllArticleCatalog(ArticleCatalogService, null);

            return View();
        }

        public ViewResult PlateNewsForm(string key)
        {
            ViewBag.Title = "PlateNewsForm";
            ViewBag.DicPlate = PublicMethod.ListAllPlateInfo(PlateService, null);
            ViewBag.DicArticleCatalog = PublicMethod.ListAllArticleCatalog(ArticleCatalogService, null);

            if (string.IsNullOrEmpty(key))
            {
                PlateNewsInfo info = new PlateNewsInfo();
                return View(info);
            }
            else
            {
                PlateNewsInfo info = PlateNewsService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListPlateNews(string title, string plateid, string articlecatalogid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(title))
            {
                nvc.Add("title", title);
            }
            if (!string.IsNullOrEmpty(plateid))
            {
                nvc.Add("plateid", plateid);
            }

            if (!string.IsNullOrEmpty(articlecatalogid))
            {
                nvc.Add("articlecatalogid", articlecatalogid);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("createtime", "desc");
            PageResult<PlateNewsInfo> pr = PlateNewsService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<PlateNewsInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdatePlateNewsValid(string key, string validstatus)
        {
            PlateNewsInfo info = new PlateNewsInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = PlateNewsService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeletePlateNews(string key)
        {
            PlateNewsInfo info = new PlateNewsInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = PlateNewsService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SavePlateNews(PlateNewsInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = PlateNewsService.Create(info);
                }
                else
                {
                    opr = PlateNewsService.Modify(info);

                }
                ViewBag.DicPlate = PublicMethod.ListAllPlateInfo(PlateService, null);
                ViewBag.DicArticleCatalog = PublicMethod.ListAllArticleCatalog(ArticleCatalogService, null);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("PlateNewsForm", info);
        }
        #endregion
        #endregion
    }
}

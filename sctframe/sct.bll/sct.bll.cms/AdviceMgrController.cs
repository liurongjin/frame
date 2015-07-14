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
    public class AdviceMgrController : Controller
    {
        /// <summary>
        /// 留言
        /// </summary>
        public IAdviceService AdviceService = UnitFactory.CreateUnit("AdviceService") as IAdviceService;

        #region Advice Manage
        #region Form
        public ViewResult AdviceList()
        {
            ViewBag.Title = "AdviceList"; 
            return View();
        }

        public ViewResult AdviceForm(string key)
        {
            ViewBag.Title = "AdviceForm"; 
            if (string.IsNullOrEmpty(key))
            {
                AdviceInfo info = new AdviceInfo();
                return View(info);
            }
            else
            {
                AdviceInfo info = AdviceService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListAdvice(string title, string state, string language, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(title))
            {
                nvc.Add("title", title);
            }
            if (!string.IsNullOrEmpty(state))
            {
                nvc.Add("state", state);
            }
            if (!string.IsNullOrEmpty(language))
            {
                nvc.Add("language", language);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("title", "asc");
            PageResult<AdviceInfo> pr = AdviceService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<AdviceInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateAdviceValid(string key, string validstatus)
        {
            AdviceInfo info = new AdviceInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = AdviceService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteAdvice(string key)
        {
            AdviceInfo info = new AdviceInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = AdviceService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveAdvice(AdviceInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = AdviceService.Create(info);
                }
                else
                {
                    opr = AdviceService.Modify(info);

                } 

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("AdviceForm", info);
        }
        #endregion
        #endregion
    }
}

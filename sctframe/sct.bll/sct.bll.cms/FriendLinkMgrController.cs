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
    public class FriendLinkMgrController : Controller
    {
        /// <summary>
        /// 友情链接
        /// </summary>
        public IFriendLinkService FriendLinkService = UnitFactory.CreateUnit("FriendLinkService") as IFriendLinkService;
        #region FriendLink Manage
        #region Form
        public ViewResult FriendLinkList()
        {
            ViewBag.Title = "FriendLinkList"; 
            return View();
        }

        public ViewResult FriendLinkForm(string key)
        {
            ViewBag.Title = "FriendLinkForm"; 
            if (string.IsNullOrEmpty(key))
            {
                FriendLinkInfo info = new FriendLinkInfo();
                return View(info);
            }
            else
            {
                FriendLinkInfo info = FriendLinkService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListFriendLink(string title, string language, string friendtype, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(title))
            {
                nvc.Add("title", title);
            }
            if (!string.IsNullOrEmpty(language))
            {
                nvc.Add("language", language);
            }

            if (!string.IsNullOrEmpty(friendtype))
            {
                nvc.Add("friendtype", friendtype);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("title", "asc");
            PageResult<FriendLinkInfo> pr = FriendLinkService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<FriendLinkInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateFriendLinkValid(string key, string validstatus)
        {
            FriendLinkInfo info = new FriendLinkInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = FriendLinkService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteFriendLink(string key)
        {
            FriendLinkInfo info = new FriendLinkInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = FriendLinkService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveFriendLink(FriendLinkInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = FriendLinkService.Create(info);
                }
                else
                {
                    opr = FriendLinkService.Modify(info);

                }
 
                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("FriendLinkForm", info);
        }
        #endregion
        #endregion
    }
}

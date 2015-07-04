using sct.cm.data;
using sct.cm.util;
using sct.dto.uc;
using sct.svc.uc;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace sct.bll.uc
{
    public class BasicMgrController : Controller
    {
        /// <summary>
        /// 区域
        /// </summary>
        public IRegionService RegionService = UnitFactory.CreateUnit("RegionService") as IRegionService;

        /// <summary>
        /// 应用
        /// </summary>
        public IAppService AppService = UnitFactory.CreateUnit("AppService") as IAppService;

        /// <summary>
        /// 客户类型
        /// </summary>
        public IClientTypeService ClientTypeService = UnitFactory.CreateUnit("ClientTypeService") as IClientTypeService;


        #region Region Manage
        #region Form
        public ViewResult RegionList()
        {
            ViewBag.Title = "RegionList";
            ViewBag.DicRegion = PublicMethod.ListAllRegionInfo(RegionService, null);
            return View();
        }

        public ViewResult RegionForm(string key)
        {
            ViewBag.Title = "RegionForm";
            ViewBag.DicRegion = PublicMethod.ListAllRegionInfo(RegionService, key);
            if (string.IsNullOrEmpty(key))
            {
                RegionInfo info = new RegionInfo();
                return View(info);
            }
            else
            {
                RegionInfo info = RegionService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListRegion(string name, string parentid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("regionname", name);
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
            orderby.Add("regionname", "asc");
            PageResult<RegionInfo> pr = RegionService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<RegionInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateRegionValid(string key, string validstatus)
        {
            RegionInfo info = new RegionInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = RegionService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteRegion(string key)
        {
            RegionInfo info = new RegionInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = RegionService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveRegion(RegionInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = RegionService.Create(info);
                }
                else
                {
                    opr = RegionService.Modify(info);

                }

                ViewBag.DicRegion = PublicMethod.ListAllRegionInfo(RegionService, info.Id);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("RegionForm", info);
        }
        #endregion
        #endregion


        #region App Manage
        #region Form
        public ViewResult AppList()
        {
            ViewBag.Title = "AppList";
            return View();
        }

        public ViewResult AppForm(string key)
        {
            ViewBag.Title = "AppForm";
            if (string.IsNullOrEmpty(key))
            {
                AppInfo info = new AppInfo();
                return View(info);
            }
            else
            {
                AppInfo info = AppService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListApp(string name, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("appname", name);
            }


            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("appname", "asc");
            PageResult<AppInfo> pr = AppService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<AppInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateAppValid(string key, string validstatus)
        {
            AppInfo info = new AppInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = AppService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteApp(string key)
        {
            AppInfo info = new AppInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = AppService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveApp(AppInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = AppService.Create(info);
                }
                else
                {
                    opr = AppService.Modify(info);

                }


                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("AppForm", info);
        }
        #endregion
        #endregion

        #region ClientType Manage
        #region Form
        public ViewResult ClientTypeList()
        {
            ViewBag.Title = "ClientTypeList";
            ViewBag.DicClientType = PublicMethod.ListAllClientTypeInfo(ClientTypeService, null);
            return View();
        }

        public ViewResult ClientTypeForm(string key)
        {
            ViewBag.Title = "ClientTypeForm";
            ViewBag.DicClientType = PublicMethod.ListAllClientTypeInfo(ClientTypeService, key);
            if (string.IsNullOrEmpty(key))
            {
                ClientTypeInfo info = new ClientTypeInfo();
                return View(info);
            }
            else
            {
                ClientTypeInfo info = ClientTypeService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListClientType(string name, string parentid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("clienttypename", name);
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
            orderby.Add("clienttypename", "asc");
            PageResult<ClientTypeInfo> pr = ClientTypeService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<ClientTypeInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateClientTypeValid(string key, string validstatus)
        {
            ClientTypeInfo info = new ClientTypeInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = ClientTypeService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteClientType(string key)
        {
            ClientTypeInfo info = new ClientTypeInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = ClientTypeService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveClientType(ClientTypeInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = ClientTypeService.Create(info);
                }
                else
                {
                    opr = ClientTypeService.Modify(info);

                }

                ViewBag.DicClientType = PublicMethod.ListAllClientTypeInfo(ClientTypeService, info.Id);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("ClientTypeForm", info);
        }
        #endregion
        #endregion
    }
}
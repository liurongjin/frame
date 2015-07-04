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
    public class SysMgrController : Controller
    {

        /// <summary>
        /// 应用
        /// </summary>        
        public IAppService AppService = UnitFactory.CreateUnit("AppService") as IAppService;

        /// <summary>
        /// 功能
        /// </summary>
        public IFunctionService FunctionService = UnitFactory.CreateUnit("FunctionService") as IFunctionService;

        /// <summary>
        /// 权限
        /// </summary>
        public IFacilityService FacilityService = UnitFactory.CreateUnit("FacilityService") as IFacilityService;


        /// <summary>
        /// 权限功能
        /// </summary>
        public IFacilityFunctionService FacilityFunctionService = UnitFactory.CreateUnit("FacilityFunctionService") as IFacilityFunctionService;


        /// <summary>
        /// 菜单
        /// </summary>        
        public IRoleService RoleService = UnitFactory.CreateUnit("RoleService") as IRoleService;

        /// <summary>
        /// 角色
        /// </summary>        
        public IMenuService MenuService = UnitFactory.CreateUnit("MenuService") as IMenuService;



        #region Function Manage
        #region Form
        public ViewResult FunctionList()
        {
            ViewBag.Title = "FunctionList";
            return View();
        }

        public ViewResult FunctionForm(string key)
        {
            ViewBag.Title = "FunctionForm";
            if (string.IsNullOrEmpty(key))
            {
                FunctionInfo info = new FunctionInfo();
                return View(info);
            }
            else
            {
                FunctionInfo info = FunctionService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListFunction(string name, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("functionname", name);
            }


            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("functionname", "asc");
            PageResult<FunctionInfo> pr = FunctionService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<FunctionInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateFunctionValid(string key, string validstatus)
        {
            FunctionInfo info = new FunctionInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = FunctionService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteFunction(string key)
        {
            FunctionInfo info = new FunctionInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = FunctionService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveFunction(FunctionInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = FunctionService.Create(info);
                }
                else
                {
                    opr = FunctionService.Modify(info);

                }


                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("FunctionForm", info);
        }
        #endregion
        #endregion

        #region Facility Manage
        #region Form
        public ViewResult FacilityList()
        {
            ViewBag.Title = "FacilityList";
            ViewBag.DicApp = PublicMethod.ListAllAppInfo(AppService, null);
            return View();
        }

        public ViewResult FacilityForm(string key)
        {
            ViewBag.Title = "FacilityForm";
            ViewBag.DicApp = PublicMethod.ListAllAppInfo(AppService, null);
            ViewBag.DicMenu = PublicMethod.ListAllMenuInfo(MenuService, null);

            /*所有功能*/
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("functionname", "asc");
            List<FunctionInfo> fdatalist = FunctionService.ListAllByCondition(nvc, orderby);

            if (string.IsNullOrEmpty(key))
            {
                FacilityInfo info = new FacilityInfo();
                var ffdatalist = new List<FacilityFunctionInfo>();
                var datalist = (from f in fdatalist
                                join ff in ffdatalist on f.Id equals ff.FunctionId into templist
                                from tp in templist.DefaultIfEmpty()
                                select new FacilityFunctionInfo()
                                {
                                    Id = tp == null ? "" : tp.Id,
                                    FacilityId = tp == null ? "" : tp.FacilityId,
                                    FunctionId = f.Id,
                                    FunctionName = f.FunctionName,
                                    Selected = tp == null ? false : true

                                }).ToList();
                info.FacilityFunctionInfoList = datalist;
                return View(info);
            }
            else
            {
                FacilityInfo info = FacilityService.Load(key);
                var datalist = (from f in fdatalist
                                join ff in info.FacilityFunctionInfoList on f.Id equals ff.FunctionId into templist
                                from tp in templist.DefaultIfEmpty()
                                select new FacilityFunctionInfo()
                                {
                                    Id = tp == null ? "" : tp.Id,
                                    FacilityId = tp == null ? "" : tp.FacilityId,
                                    FunctionId = f.Id,
                                    FunctionName = f.FunctionName,
                                    Selected = tp == null ? false : true

                                }).ToList();
                info.FacilityFunctionInfoList = datalist;
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListFacility(string name, string appid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("facilityname", name);
            }
            if (!string.IsNullOrEmpty(appid))
            {
                nvc.Add("appid", appid);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("facilityname", "asc");
            PageResult<FacilityInfo> pr = FacilityService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<FacilityInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateFacilityValid(string key, string validstatus)
        {
            FacilityInfo info = new FacilityInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = FacilityService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteFacility(string key)
        {
            FacilityInfo info = new FacilityInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = FacilityService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveFacility(FacilityInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = FacilityService.Create(info);
                }
                else
                {
                    opr = FacilityService.Modify(info);

                }

                ViewBag.DicApp = PublicMethod.ListAllAppInfo(AppService, null);
                ViewBag.DicMenu = PublicMethod.ListAllMenuInfo(MenuService, null);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("FacilityForm", info);
        }
        #endregion
        #endregion

        #region Menu Manage
        #region Form
        public ViewResult MenuList()
        {
            ViewBag.Title = "MenuList";
            ViewBag.DicMenu = PublicMethod.ListAllMenuInfo(MenuService, null);
            ViewBag.DicApp = PublicMethod.ListAllAppInfo(AppService, null);
            return View();
        }

        public ViewResult MenuForm(string key)
        {
            ViewBag.Title = "MenuForm";
            ViewBag.DicMenu = PublicMethod.ListAllMenuInfo(MenuService, key);
            ViewBag.DicApp = PublicMethod.ListAllAppInfo(AppService, null);
            if (string.IsNullOrEmpty(key))
            {
                MenuInfo info = new MenuInfo();
                return View(info);
            }
            else
            {
                MenuInfo info = MenuService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListMenu(string name, string parentid, string appid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("menuname", name);
            }

            if (!string.IsNullOrEmpty(parentid))
            {
                nvc.Add("parentid", parentid);
            }

            if (!string.IsNullOrEmpty(appid))
            {
                nvc.Add("appid", appid);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("menuname", "asc");
            PageResult<MenuInfo> pr = MenuService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<MenuInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateMenuValid(string key, string validstatus)
        {
            MenuInfo info = new MenuInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = MenuService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteMenu(string key)
        {
            MenuInfo info = new MenuInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = MenuService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveMenu(MenuInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = MenuService.Create(info);
                }
                else
                {
                    opr = MenuService.Modify(info);

                }
                ViewBag.DicMenu = PublicMethod.ListAllMenuInfo(MenuService, info.Id);
                ViewBag.DicApp = PublicMethod.ListAllAppInfo(AppService, null);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("MenuForm", info);
        }
        #endregion
        #endregion


        #region Role Manage
        #region Form
        public ViewResult RoleList()
        {
            ViewBag.Title = "RoleList";
            ViewBag.DicApp = PublicMethod.ListAllAppInfo(AppService, null);
            return View();
        }

        public ViewResult RoleForm(string key)
        {
            ViewBag.Title = "RoleForm";
            ViewBag.DicApp = PublicMethod.ListAllAppInfo(AppService, null);


            /*所有权限*/
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("facilityname", "asc");
            List<FacilityInfo> rdatalist = FacilityService.ListAllByCondition(nvc, orderby);


            if (string.IsNullOrEmpty(key))
            {
                RoleInfo info = new RoleInfo();

                var rfdatalist = new List<RoleFacilityInfo>();
                var datalist = (from f in rdatalist
                                join ff in rfdatalist on f.Id equals ff.FacilityId into templist
                                from tp in templist.DefaultIfEmpty()
                                select new RoleFacilityInfo()
                                {
                                    Id = tp == null ? "" : tp.Id,
                                    RoleId = tp == null ? "" : tp.RoleId,
                                    AccessScope = tp == null ? 0 : tp.AccessScope,
                                    FacilityId = f.Id,
                                    FacilityName = f.FacilityName,
                                    Selected = tp == null ? false : true

                                }).ToList();
                info.RoleFacilityInfoList = datalist;
                return View(info);
            }
            else
            {
                RoleInfo info = RoleService.Load(key);
                var datalist = (from f in rdatalist
                                join ff in info.RoleFacilityInfoList on f.Id equals ff.FacilityId into templist
                                from tp in templist.DefaultIfEmpty()
                                select new RoleFacilityInfo()
                                {
                                    Id = tp == null ? "" : tp.Id,
                                    RoleId = tp == null ? "" : tp.RoleId,
                                    AccessScope = tp == null ? 0 : tp.AccessScope,
                                    FacilityId = f.Id,
                                    FacilityName = f.FacilityName,
                                    Selected = tp == null ? false : true

                                }).ToList();
                info.RoleFacilityInfoList = datalist;
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListRole(string name, string appid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("rolename", name);
            }
            if (!string.IsNullOrEmpty(appid))
            {
                nvc.Add("appid", appid);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("rolename", "asc");
            PageResult<RoleInfo> pr = RoleService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<RoleInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateRoleValid(string key, string validstatus)
        {
            RoleInfo info = new RoleInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = RoleService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteRole(string key)
        {
            RoleInfo info = new RoleInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = RoleService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveRole(RoleInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = RoleService.Create(info);
                }
                else
                {
                    opr = RoleService.Modify(info);

                }

                ViewBag.DicApp = PublicMethod.ListAllAppInfo(AppService, null);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("RoleForm", info);
        }
        #endregion
        #endregion

    }
}

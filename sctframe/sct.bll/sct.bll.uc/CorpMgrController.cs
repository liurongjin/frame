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
    public class CorpMgrController : Controller
    {

        /// <summary>
        /// 区域
        /// </summary>
        public IRegionService RegionService = UnitFactory.CreateUnit("RegionService") as IRegionService;

        /// 公司
        /// </summary>
        public ICompanyService CompanyService = UnitFactory.CreateUnit("CompanyService") as ICompanyService;

        /// 部门
        /// </summary>
        public IDepartmentService DepartmentService = UnitFactory.CreateUnit("DepartmentService") as IDepartmentService;

        /// <summary>
        /// 岗位
        /// </summary>
        public IStationService StationService = UnitFactory.CreateUnit("StationService") as IStationService;


        /// <summary>
        /// 职员
        /// </summary>
        public IStaffService StaffService = UnitFactory.CreateUnit("StaffService") as IStaffService;

        /// <summary>
        /// 角色
        /// </summary>
        public IRoleService RoleService = UnitFactory.CreateUnit("RoleService") as IRoleService;

        #region Company Manage
        #region Form
        public ViewResult CompanyList()
        {
            ViewBag.Title = "CompanyList";
            ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, null);
            return View();
        }

        public ViewResult CompanyForm(string key)
        {
            ViewBag.Title = "CompanyForm";
            ViewBag.DicRegion = PublicMethod.ListAllRegionInfo(RegionService, null);
            ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, key);
            if (string.IsNullOrEmpty(key))
            {
                CompanyInfo info = new CompanyInfo();
                return View(info);
            }
            else
            {
                CompanyInfo info = CompanyService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListCompany(string name, string parentid, string regionid, string isowner, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("companyname", name);
            }
            if (!string.IsNullOrEmpty(parentid))
            {
                nvc.Add("parentid", parentid);
            }

            if (!string.IsNullOrEmpty(regionid))
            {
                nvc.Add("regionid", regionid);
            }

            if (!string.IsNullOrEmpty(isowner))
            {
                nvc.Add("isowner", isowner);
            }


            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("companyname", "asc");
            PageResult<CompanyInfo> pr = CompanyService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<CompanyInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateCompanyValid(string key, string validstatus)
        {
            CompanyInfo info = new CompanyInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = CompanyService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteCompany(string key)
        {
            CompanyInfo info = new CompanyInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = CompanyService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveCompany(CompanyInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = CompanyService.Create(info);
                }
                else
                {
                    opr = CompanyService.Modify(info);

                }

                ViewBag.DicRegion = PublicMethod.ListAllRegionInfo(RegionService, null);
                ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, info.Id);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("CompanyForm", info);
        }
        #endregion
        #endregion


        #region Department Manage
        #region Form
        public ViewResult DepartmentList()
        {
            ViewBag.Title = "DepartmentList";
            ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, null);
            ViewBag.DicDepartment = PublicMethod.ListAllDepartmentInfo(DepartmentService, null);
            return View();
        }

        public ViewResult DepartmentForm(string key)
        {
            ViewBag.Title = "DepartmentForm";
            ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, null);
            ViewBag.DicDepartment = PublicMethod.ListAllDepartmentInfo(DepartmentService, key);
            if (string.IsNullOrEmpty(key))
            {
                DepartmentInfo info = new DepartmentInfo();
                return View(info);
            }
            else
            {
                DepartmentInfo info = DepartmentService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListDepartment(string name, string parentid, string companyid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("departmentname", name);
            }
            if (!string.IsNullOrEmpty(parentid))
            {
                nvc.Add("parentid", parentid);
            }

            if (!string.IsNullOrEmpty(companyid))
            {
                nvc.Add("companyid", companyid);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("departmentname", "asc");
            PageResult<DepartmentInfo> pr = DepartmentService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<DepartmentInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateDepartmentValid(string key, string validstatus)
        {
            DepartmentInfo info = new DepartmentInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = DepartmentService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteDepartment(string key)
        {
            DepartmentInfo info = new DepartmentInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = DepartmentService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveDepartment(DepartmentInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = DepartmentService.Create(info);
                }
                else
                {
                    opr = DepartmentService.Modify(info);

                }
                ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, null);
                ViewBag.DicDepartment = PublicMethod.ListAllDepartmentInfo(DepartmentService, info.Id);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("DepartmentForm", info);
        }
        #endregion
        #endregion


        #region Station Manage
        #region Form
        public ViewResult StationList()
        {
            ViewBag.Title = "stationList";
            ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, null);
            ViewBag.DicDepartment = PublicMethod.ListAllDepartmentInfo(DepartmentService, null);
            ViewBag.DicStation = PublicMethod.ListAllStationInfo(StationService, null);
            return View();
        }

        public ViewResult StationForm(string key)
        {
            ViewBag.Title = "StationForm";
            ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, null);
            ViewBag.DicDepartment = PublicMethod.ListAllDepartmentInfo(DepartmentService, null);
            ViewBag.DicStation = PublicMethod.ListAllStationInfo(StationService, key);

            /*所有角色*/
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("rolename", "asc");
            List<RoleInfo> rdatalist = RoleService.ListAllByCondition(nvc, orderby);


            if (string.IsNullOrEmpty(key))
            {
                StationInfo info = new StationInfo();

                var srdatalist = new List<StationRoleInfo>();
                var datalist = (from f in rdatalist
                                join ff in srdatalist on f.Id equals ff.RoleId into templist
                                from tp in templist.DefaultIfEmpty()
                                select new StationRoleInfo()
                                {
                                    Id = tp == null ? "" : tp.Id,
                                    StationId = tp == null ? "" : tp.StationId,
                                    RoleId = f.Id,
                                    RoleName = f.RoleName,
                                    Selected = tp == null ? false : true

                                }).ToList();
                info.StationRoleInfoList = datalist;
                return View(info);
            }
            else
            {
                StationInfo info = StationService.Load(key);
                var datalist = (from f in rdatalist
                                join ff in info.StationRoleInfoList on f.Id equals ff.RoleId into templist
                                from tp in templist.DefaultIfEmpty()
                                select new StationRoleInfo()
                                {
                                    Id = tp == null ? "" : tp.Id,
                                    StationId = tp == null ? "" : tp.StationId,
                                    RoleId = f.Id,
                                    RoleName = f.RoleName,
                                    Selected = tp == null ? false : true

                                }).ToList();
                info.StationRoleInfoList = datalist;
                return View(info);
            }

        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListStation(string name, string parentid, string companyid, string departmentid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("stationname", name);
            }

            if (!string.IsNullOrEmpty(parentid))
            {
                nvc.Add("parentid", parentid);
            }

            if (!string.IsNullOrEmpty(companyid))
            {
                nvc.Add("companyid", companyid);
            }

            if (!string.IsNullOrEmpty(departmentid))
            {
                nvc.Add("departmentid", departmentid);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }

            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("stationname", "asc");
            PageResult<StationInfo> pr = StationService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<StationInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateStationValid(string key, string validstatus)
        {
            StationInfo info = new StationInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = StationService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteStation(string key)
        {
            StationInfo info = new StationInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = StationService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveStation(StationInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = StationService.Create(info);
                }
                else
                {
                    opr = StationService.Modify(info);

                }
                ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, null);
                ViewBag.DicDepartment = PublicMethod.ListAllDepartmentInfo(DepartmentService, null);
                ViewBag.DicStation = PublicMethod.ListAllStationInfo(StationService, info.Id);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("StationForm", info);
        }
        #endregion
        #endregion


        #region Staff Manage
        #region Form
        public ViewResult StaffList()
        {
            ViewBag.Title = "StaffList";
            ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, null);
            ViewBag.DicDepartment = PublicMethod.ListAllDepartmentInfo(DepartmentService, null);
            return View();
        }

        public ViewResult StaffForm(string key)
        {
            ViewBag.Title = "StaffForm";
            ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, null);
            ViewBag.DicDepartment = PublicMethod.ListAllDepartmentInfo(DepartmentService, null);



            /*所有角色*/
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("stationname", "asc");
            List<StationInfo> rdatalist = StationService.ListAllByCondition(nvc, orderby);


            if (string.IsNullOrEmpty(key))
            {
                StaffInfo info = new StaffInfo();

                var srdatalist = new List<StaffStationInfo>();
                var datalist = (from f in rdatalist
                                join ff in srdatalist on f.Id equals ff.StationId into templist
                                from tp in templist.DefaultIfEmpty()
                                select new StaffStationInfo()
                                {
                                    Id = tp == null ? "" : tp.Id,
                                    StaffId = tp == null ? "" : tp.StaffId,
                                    StationId = f.Id,
                                    StationName = f.StationName,
                                    Selected = tp == null ? false : true

                                }).ToList();
                info.StaffStationInfoList = datalist;
                return View(info);
            }
            else
            {
                StaffInfo info = StaffService.Load(key);
                var datalist = (from f in rdatalist
                                join ff in info.StaffStationInfoList on f.Id equals ff.StationId into templist
                                from tp in templist.DefaultIfEmpty()
                                select new StaffStationInfo()
                                {
                                    Id = tp == null ? "" : tp.Id,
                                    StaffId = tp == null ? "" : tp.StaffId,
                                    StationId = f.Id,
                                    StationName = f.StationName,
                                    Selected = tp == null ? false : true

                                }).ToList();
                info.StaffStationInfoList = datalist;
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListStaff(string name, string companyid, string departmentid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("staffname", name);
            }

            if (!string.IsNullOrEmpty(companyid))
            {
                nvc.Add("companyid", companyid);
            }

            if (!string.IsNullOrEmpty(departmentid))
            {
                nvc.Add("departmentid", departmentid);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }

            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("staffname", "asc");
            PageResult<StaffInfo> pr = StaffService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<StaffInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateStaffValid(string key, string validstatus)
        {
            StaffInfo info = new StaffInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = StaffService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteStaff(string key)
        {
            StaffInfo info = new StaffInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = StaffService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveStaff(StaffInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = StaffService.Create(info);
                }
                else
                {
                    opr = StaffService.Modify(info);

                }
                ViewBag.DicCompany = PublicMethod.ListAllCompanyInfo(CompanyService, null);
                ViewBag.DicDepartment = PublicMethod.ListAllDepartmentInfo(DepartmentService, null);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("StaffForm", info);
        }
        #endregion
        #endregion

    }
}

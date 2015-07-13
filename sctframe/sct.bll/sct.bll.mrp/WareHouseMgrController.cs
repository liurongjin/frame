using sct.cm.data;
using sct.cm.util;
using sct.dto.mrp;
using sct.svc.mrp;
using sct.svc.uc;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace sct.bll.mrp
{
    public class WareHouseMgrController : Controller
    {
        /// <summary>
        /// 仓库管理
        /// </summary>
        public IWareHouseService WareHouseService = UnitFactory.CreateUnit("WareHouseService") as IWareHouseService;

        /// <summary>
        /// 区域
        /// </summary>
        public IRegionService RegionService = UnitFactory.CreateUnit("RegionService") as IRegionService;

        #region WareHouse Manage
        #region Form
        public ViewResult WareHouseList()
        {
            ViewBag.Title = "WareHouseList";
            ViewBag.DicRegion = PublicMethod.ListAllRegionInfo(RegionService, null);
            return View();
        }

        public ViewResult WareHouseForm(string key)
        {
            ViewBag.Title = "WareHouseForm";
            ViewBag.DicRegion = PublicMethod.ListAllRegionInfo(RegionService, null);
            if (string.IsNullOrEmpty(key))
            {
                WareHouseInfo info = new WareHouseInfo();
                return View(info);
            }
            else
            {
                WareHouseInfo info = WareHouseService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListWareHouse(string name, string regionid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("WareHousename", name);
            }
            if (!string.IsNullOrEmpty(regionid))
            {
                nvc.Add("regionid", regionid);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("WareHousename", "asc");
            PageResult<WareHouseInfo> pr = WareHouseService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<WareHouseInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateWareHouseValid(string key, string validstatus)
        {
            WareHouseInfo info = new WareHouseInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = WareHouseService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteWareHouse(string key)
        {
            WareHouseInfo info = new WareHouseInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = WareHouseService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveWareHouse(WareHouseInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = WareHouseService.Create(info);
                }
                else
                {
                    opr = WareHouseService.Modify(info);

                }

                ViewBag.DicRegion = PublicMethod.ListAllRegionInfo(RegionService, null);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("WareHouseForm", info);
        }
        #endregion
        #endregion
    }
}

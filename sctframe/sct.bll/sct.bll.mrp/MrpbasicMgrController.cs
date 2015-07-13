using sct.cm.data;
using sct.cm.util;
using sct.dto.mrp;
using sct.svc.mrp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace sct.bll.mrp
{
    public class MrpbasicMgrController : Controller
    {
        /// <summary>
        /// 材料分类
        /// </summary>
        public IUnitService UnitService = UnitFactory.CreateUnit("UnitService") as IUnitService;


        #region Unit Manage
        #region Form
        public ViewResult UnitList()
        {
            ViewBag.Title = "UnitList";
            return View();
        }

        public ViewResult UnitForm(string key)
        {
            ViewBag.Title = "UnitForm";
            if (string.IsNullOrEmpty(key))
            {
                UnitInfo info = new UnitInfo();
                return View(info);
            }
            else
            {
                UnitInfo info = UnitService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListUnit(string name, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("unitname", name);
            }


            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("Unitname", "asc");
            PageResult<UnitInfo> pr = UnitService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<UnitInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateUnitValid(string key, string validstatus)
        {
            UnitInfo info = new UnitInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = UnitService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteUnit(string key)
        {
            UnitInfo info = new UnitInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = UnitService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveUnit(UnitInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = UnitService.Create(info);
                }
                else
                {
                    opr = UnitService.Modify(info);

                }


                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("UnitForm", info);
        }
        #endregion
        #endregion

    }
}

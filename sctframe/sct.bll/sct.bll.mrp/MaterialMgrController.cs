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
    public class MaterialMgrController : Controller
    {
        /// <summary>
        /// 材料分类
        /// </summary>
        public IMaterialCatalogService MaterialCatalogService = UnitFactory.CreateUnit("MaterialCatalogService") as IMaterialCatalogService;


        /// <summary>
        /// 材料
        /// </summary>
        public IMaterialService MaterialService = UnitFactory.CreateUnit("MaterialService") as IMaterialService;


        /// <summary>
        /// 计量单位
        /// </summary>
        public IUnitService UnitService = UnitFactory.CreateUnit("UnitService") as IUnitService;

        #region MaterialCatalog Manage
        #region Form
        public ViewResult MaterialCatalogList()
        {
            ViewBag.Title = "MaterialCatalogList";
            ViewBag.DicMaterialCatalog = PublicMethod.ListAllMaterialCatalogInfo(MaterialCatalogService, null);
            return View();
        }

        public ViewResult MaterialCatalogForm(string key)
        {
            ViewBag.Title = "MaterialCatalogForm";
            ViewBag.DicMaterialCatalog = PublicMethod.ListAllMaterialCatalogInfo(MaterialCatalogService, key);
            if (string.IsNullOrEmpty(key))
            {
                MaterialCatalogInfo info = new MaterialCatalogInfo();
                return View(info);
            }
            else
            {
                MaterialCatalogInfo info = MaterialCatalogService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListMaterialCatalog(string name, string parentid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("materialcatalogname", name);
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
            orderby.Add("materialcatalogname", "asc");
            PageResult<MaterialCatalogInfo> pr = MaterialCatalogService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<MaterialCatalogInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateMaterialCatalogValid(string key, string validstatus)
        {
            MaterialCatalogInfo info = new MaterialCatalogInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = MaterialCatalogService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteMaterialCatalog(string key)
        {
            MaterialCatalogInfo info = new MaterialCatalogInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = MaterialCatalogService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveMaterialCatalog(MaterialCatalogInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = MaterialCatalogService.Create(info);
                }
                else
                {
                    opr = MaterialCatalogService.Modify(info);

                }

                ViewBag.DicMaterialCatalog = PublicMethod.ListAllMaterialCatalogInfo(MaterialCatalogService, info.Id);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("MaterialCatalogForm", info);
        }
        #endregion
        #endregion


        #region Material Manage
        #region Form
        public ViewResult MaterialList()
        {
            ViewBag.Title = "MaterialList";
            ViewBag.DicMaterialCatalog = PublicMethod.ListAllMaterialCatalogInfo(MaterialCatalogService, null);
            ViewBag.DicUnit = PublicMethod.ListAllUnitInfo(UnitService, null);
            return View();
        }

        public ViewResult MaterialForm(string key)
        {
            ViewBag.Title = "MaterialForm";
            ViewBag.DicMaterialCatalog = PublicMethod.ListAllMaterialCatalogInfo(MaterialCatalogService, null);
            ViewBag.DicUnit = PublicMethod.ListAllUnitInfo(UnitService, null);
            if (string.IsNullOrEmpty(key))
            {
                MaterialInfo info = new MaterialInfo();
                return View(info);
            }
            else
            {
                MaterialInfo info = MaterialService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListMaterial(string name, string materialcatalogid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("materialname", name);
            }
            if (!string.IsNullOrEmpty(materialcatalogid))
            {
                nvc.Add("materialcatalogid", materialcatalogid);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("materialname", "asc");
            PageResult<MaterialInfo> pr = MaterialService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<MaterialInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateMaterialValid(string key, string validstatus)
        {
            MaterialInfo info = new MaterialInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = MaterialService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteMaterial(string key)
        {
            MaterialInfo info = new MaterialInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = MaterialService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveMaterial(MaterialInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = MaterialService.Create(info);
                }
                else
                {
                    opr = MaterialService.Modify(info);

                }

                ViewBag.DicMaterialCatalog = PublicMethod.ListAllMaterialCatalogInfo(MaterialCatalogService, null);
                ViewBag.DicUnit = PublicMethod.ListAllUnitInfo(UnitService, null);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("MaterialForm", info);
        }
        #endregion
        #endregion
    }
}

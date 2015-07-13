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
    public class ProductMgrController : Controller
    {
        /// <summary>
        /// 材料分类
        /// </summary>
        public IProductCatalogService ProductCatalogService = UnitFactory.CreateUnit("ProductCatalogService") as IProductCatalogService;


        /// <summary>
        /// 材料
        /// </summary>
        public IProductService ProductService = UnitFactory.CreateUnit("ProductService") as IProductService;

        /// <summary>
        /// 计量单位
        /// </summary>
        public IUnitService UnitService = UnitFactory.CreateUnit("UnitService") as IUnitService;


        #region ProductCatalog Manage
        #region Form
        public ViewResult ProductCatalogList()
        {
            ViewBag.Title = "ProductCatalogList";
            ViewBag.DicProductCatalog = PublicMethod.ListAllProductCatalogInfo(ProductCatalogService, null);
            return View();
        }

        public ViewResult ProductCatalogForm(string key)
        {
            ViewBag.Title = "ProductCatalogForm";
            ViewBag.DicProductCatalog = PublicMethod.ListAllProductCatalogInfo(ProductCatalogService, key);
            if (string.IsNullOrEmpty(key))
            {
                ProductCatalogInfo info = new ProductCatalogInfo();
                return View(info);
            }
            else
            {
                ProductCatalogInfo info = ProductCatalogService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListProductCatalog(string name, string parentid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("ProductCatalogname", name);
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
            orderby.Add("ProductCatalogname", "asc");
            PageResult<ProductCatalogInfo> pr = ProductCatalogService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<ProductCatalogInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateProductCatalogValid(string key, string validstatus)
        {
            ProductCatalogInfo info = new ProductCatalogInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = ProductCatalogService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteProductCatalog(string key)
        {
            ProductCatalogInfo info = new ProductCatalogInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = ProductCatalogService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveProductCatalog(ProductCatalogInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = ProductCatalogService.Create(info);
                }
                else
                {
                    opr = ProductCatalogService.Modify(info);

                }

                ViewBag.DicProductCatalog = PublicMethod.ListAllProductCatalogInfo(ProductCatalogService, info.Id);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("ProductCatalogForm", info);
        }
        #endregion
        #endregion

        #region Product Manage
        #region Form
        public ViewResult ProductList()
        {
            ViewBag.Title = "ProductList";
            ViewBag.DicProductCatalog = PublicMethod.ListAllProductCatalogInfo(ProductCatalogService, null);
            ViewBag.DicUnit = PublicMethod.ListAllUnitInfo(UnitService, null);
            return View();
        }

        public ViewResult ProductForm(string key)
        {
            ViewBag.Title = "ProductForm";
            ViewBag.DicProductCatalog = PublicMethod.ListAllProductCatalogInfo(ProductCatalogService, null);
            ViewBag.DicUnit = PublicMethod.ListAllUnitInfo(UnitService, null);
            if (string.IsNullOrEmpty(key))
            {
                ProductInfo info = new ProductInfo();
                return View(info);
            }
            else
            {
                ProductInfo info = ProductService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListProduct(string name, string productcatalogid, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("productname", name);
            }
            if (!string.IsNullOrEmpty(productcatalogid))
            {
                nvc.Add("productcatalogidproductcatalogid", productcatalogid);
            }

            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("productname", "asc");
            PageResult<ProductInfo> pr = ProductService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<ProductInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateProductValid(string key, string validstatus)
        {
            ProductInfo info = new ProductInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = ProductService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteProduct(string key)
        {
            ProductInfo info = new ProductInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = ProductService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveProduct(ProductInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = ProductService.Create(info);
                }
                else
                {
                    opr = ProductService.Modify(info);

                }

                ViewBag.DicProductCatalog = PublicMethod.ListAllProductCatalogInfo(ProductCatalogService, null);
                ViewBag.DicUnit = PublicMethod.ListAllUnitInfo(UnitService, null);

                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("ProductForm", info);
        }
        #endregion
        #endregion
    }
}

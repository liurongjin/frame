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
    public class ProductOrderMgrController : Controller
    {
        /// <summary>
        /// 订单分类
        /// </summary>
        public IProductOrderService ProductOrderService = UnitFactory.CreateUnit("ProductOrderService") as IProductOrderService;


        #region ProductOrder Manage
        #region Form
        public ViewResult ProductOrderList()
        {
            ViewBag.Title = "ProductOrderList";
            return View();
        }

        public ViewResult ProductOrderForm(string key)
        {
            ViewBag.Title = "ProductOrderForm";
            if (string.IsNullOrEmpty(key))
            {
                ProductOrderInfo info = new ProductOrderInfo();
                return View(info);
            }
            else
            {
                ProductOrderInfo info = ProductOrderService.Load(key);
                return View(info);
            }
        }
        #endregion

        #region Action
        [HttpPost]
        public JsonResult ListProductOrder(string name, string isvalid, int pagenumber, int pagesize)
        {
            NameValueCollection nvc = new NameValueCollection();
            if (!string.IsNullOrEmpty(name))
            {
                nvc.Add("ProductOrdername", name);
            }


            if (!string.IsNullOrEmpty(isvalid))
            {
                nvc.Add("isvalid", isvalid);
            }
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("ProductOrdername", "asc");
            PageResult<ProductOrderInfo> pr = ProductOrderService.ListByCondition(nvc, orderby, pagenumber, pagesize);

            return Json(new JsonResultHelper(true, new JsonDataGridHelper<ProductOrderInfo>(pr.Data, pr.TotalRecords)));
        }

        [HttpPost]
        public JsonResult UpdateProductOrderValid(string key, string validstatus)
        {
            ProductOrderInfo info = new ProductOrderInfo();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(validstatus))
            {
                info.Id = key;
                info.SYS_IsValid = int.Parse(validstatus);
                OperationResult opr = ProductOrderService.Modify(info);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public JsonResult DeleteProductOrder(string key)
        {
            ProductOrderInfo info = new ProductOrderInfo();
            if (!string.IsNullOrEmpty(key))
            {
                info.Id = key;
                OperationResult opr = ProductOrderService.Remove(key);
                return Json(new JsonResultHelper(opr.Message));
            }
            else
            {
                return Json(new JsonResultHelper(false, "选择的记录无效", ""));
            }
        }

        [HttpPost]
        public ActionResult SaveProductOrder(ProductOrderInfo info)
        {
            OperationResult opr = new OperationResult(OperationResultType.Success);
            try
            {
                if (string.IsNullOrEmpty(info.Id))
                {
                    info.Id = System.Guid.NewGuid().ToString();
                    opr = ProductOrderService.Create(info);
                }
                else
                {
                    opr = ProductOrderService.Modify(info);

                }


                ViewBag.PromptMsg = opr.Message;
            }
            catch (Exception err)
            {
                ViewBag.PromptMsg = err.Message;
            }

            return View("ProductOrderForm", info);
        }
        #endregion
        #endregion

    }
}

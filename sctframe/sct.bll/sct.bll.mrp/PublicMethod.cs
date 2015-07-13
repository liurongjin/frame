using sct.cm.data;
using sct.dto.mrp;
using sct.svc.mrp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sct.bll.mrp
{
    public class PublicMethod
    {

        /// <summary>
        /// 获取物料分类
        /// </summary>
        /// <param name="MaterialCatalogService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllMaterialCatalogInfo(IMaterialCatalogService MaterialCatalogService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("MaterialCatalogname", "asc");
            List<MaterialCatalogInfo> datalist = MaterialCatalogService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicMaterialCatalog = (from slist in datalist
                                      select new ChooseDictionary { Text = slist.MaterialCatalogName, Value = slist.Id, ParentId = slist.ParentId }).ToList();
            return dicMaterialCatalog;
        }


        /// <summary>
        /// 获取成品分类
        /// </summary>
        /// <param name="ProductCatalogService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllProductCatalogInfo(IProductCatalogService ProductCatalogService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("ProductCatalogname", "asc");
            List<ProductCatalogInfo> datalist = ProductCatalogService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicProductCatalog = (from slist in datalist
                                     select new ChooseDictionary { Text = slist.ProductCatalogName, Value = slist.Id, ParentId = slist.ParentId }).ToList();
            return dicProductCatalog;
        }


        /// <summary>
        /// 获取计量单位
        /// </summary>
        /// <param name="UnitService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllUnitInfo(IUnitService UnitService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("unitname", "asc");
            List<UnitInfo> datalist = UnitService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicUnit = (from slist in datalist
                           select new ChooseDictionary { Text = slist.UnitName, Value = slist.Id, ParentId = null }).ToList();
            return dicUnit;
        }
    }
}

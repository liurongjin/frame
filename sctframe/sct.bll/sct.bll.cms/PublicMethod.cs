using sct.cm.data;
using sct.cm.util;
using sct.dto.cms;
using sct.svc.cms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sct.bll.cms
{
    /// <summary>
    /// 资讯模块的公共方法
    /// </summary>
    public static class PublicMethod
    {
        /// <summary>
        /// 获取资讯分类
        /// </summary>
        /// <param name="ArticleCatalogService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllArticleCatalog(IArticleCatalogService ArticleCatalogService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("name", "asc");
            List<ArticleCatalogInfo> datalist = ArticleCatalogService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicArticleCatalog = (from slist in datalist
                                     select new ChooseDictionary { Text = slist.Name, Value = slist.Id, ParentId = slist.ParentId }).ToList();
            return dicArticleCatalog;
        }

        /// <summary>
        /// 获取版块
        /// </summary>
        /// <param name="PlateService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllPlateInfo(IPlateService PlateService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("name", "asc");
            List<PlateInfo> datalist = PlateService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicPlate = (from slist in datalist
                            select new ChooseDictionary { Text = slist.Name + "[" + ((sct.dto.cms.EnumSet.PlateType)slist.PlateType).ToString() + "]", Value = slist.Id, ParentId = slist.ParentId }).ToList();
            return dicPlate;
        }
    }
}

using sct.cm.data;
using sct.cm.util;
using sct.dto.cms;
using sct.svc.cms;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web.Mvc;

namespace sct.bll.cms
{
    public class ComDictionaryController : Controller
    {
        /// <summary>
        /// 页面版块
        /// </summary>
        public IPlateService PlateService = UnitFactory.CreateUnit("PlateService") as IPlateService;

        /// <summary>
        /// 页面版块内容
        /// </summary>
        public IPlateNewsService PlateNewsService = UnitFactory.CreateUnit("PlateNewsService") as IPlateNewsService;

        /// <summary>
        /// 资讯分类
        /// </summary>
        public IArticleCatalogService ArticleCatalogService = UnitFactory.CreateUnit("ArticleCatalogService") as IArticleCatalogService;

        #region Method
        private List<PlateInfo> ListAllPlateInfo(string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("name", "asc");
            PageResult<PlateInfo> pr = PlateService.ListByCondition(nvc, orderby, 1, 100);
            if (!string.IsNullOrEmpty(key))
            {
                pr.Data.Remove(pr.Data.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            return pr.Data;
        }

        private List<ArticleCatalogInfo> ListAllArticleCatalog(string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("name", "asc");
            PageResult<ArticleCatalogInfo> pr = ArticleCatalogService.ListByCondition(nvc, orderby, 1, 100);
            if (!string.IsNullOrEmpty(key))
            {
                pr.Data.Remove(pr.Data.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            return pr.Data;
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace sct.app.admin
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    "Cms",
            //    "ArticleManage/{action}/{id}",
            //    new { controller = "ArticleManage", action = "ArticleCatalogList", id = UrlParameter.Optional },
            //    new string[] { "sct.bll.cms" }
            //    );

            //routes.MapRoute("Cms", 
            //    "Cms/{action}/{id}", 
            //    new { controller = "ArticleManage", action = "ArticleCatalogList", id = UrlParameter.Optional },
            //    new string[] { "sct.bll.cms" });

            routes.MapRoute(
             "Default",
             "{controller}/{action}/{id}",
             new { controller = "Home", action = "Index", id = UrlParameter.Optional }
             );

        }
    }
}
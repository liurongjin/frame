using System.Web.Mvc;
using System.Web.Routing;

namespace sct.bll.cms
{
    public class GlobalRoutesTable
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //default   routes
            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "sct.bll.cms" }
            );
        }

    }
}

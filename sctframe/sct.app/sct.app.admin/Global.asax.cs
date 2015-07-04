using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace sct.app.admin
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            #region 日志
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(Server.MapPath("\\Content\\Config\\log4net.config")));
            #endregion

            #region spring 对象注入
            ContextRegistry.GetContext();
            #endregion
        }
    }
}
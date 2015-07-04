using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace sct.cm.util
{
    public class AdminAuthorize : PermissonAuthorize
    { 

        //public override void OnAuthorization(AuthorizationContext filterContext)
        //{
        //    base.OnAuthorization(filterContext);
        //}


        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext == null)
                return false;

            if (httpContext.User.Identity.IsAuthenticated)
            {
                string strARoleName;
                if (null == httpContext.Session["Permissons"])
                {
                    FormsIdentity formId = (FormsIdentity)httpContext.User.Identity;
                    FormsAuthenticationTicket Ticket = formId.Ticket;
                    strARoleName = Ticket.UserData;
                    httpContext.Session["Permissons"] = Ticket.UserData;
                }
                else
                    strARoleName = httpContext.Session["Permissons"].ToString();


                //if (strARoleName == Permissons)
                    return true;
            }
            return false;
        }
    }
}

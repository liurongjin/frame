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
    public class StaffAuthorize : PermissonAuthorize
    {        
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            if (filterContext.HttpContext.Response.StatusCode == 403)
            {
                filterContext.Result = new RedirectResult("/Home/Login");
            }
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {            
            if (httpContext == null)
            {
                throw new ArgumentNullException("httpContext");
            }
            else
            {
                if (httpContext.User.Identity.IsAuthenticated)
                {
                    string strOwnerPermission;
                    if (httpContext.Session["Permissons"] == null)
                    {
                        FormsIdentity formId = (FormsIdentity)httpContext.User.Identity;
                        FormsAuthenticationTicket Ticket = formId.Ticket;
                        var userdata = Encoding.Default.GetString(Convert.FromBase64String(Ticket.UserData));
                        strOwnerPermission = userdata;
                        httpContext.Session["Permissons"] = Ticket.UserData;
                    }
                    else
                    {
                        strOwnerPermission = httpContext.Session["Permissons"].ToString();
                    }


                    //if (strOwnerPermission == Permissons)
                        return true;
                }
                httpContext.Response.StatusCode = 403;
                return false;
            }
        }
    }
}

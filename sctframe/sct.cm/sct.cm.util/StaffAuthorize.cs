using sct.cm.data;
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
                    /*加载用户信息*/
                    FormsIdentity formId = (FormsIdentity)httpContext.User.Identity;
                    FormsAuthenticationTicket Ticket = formId.Ticket;
                    var strLoginInfo = Encoding.Default.GetString(Convert.FromBase64String(Ticket.UserData));
                    LoginInfo logininfo = JsonHelper.ParseFromJson<LoginInfo>(strLoginInfo);

                    /*加载用户分配的权限*/
                    string baseStrFacilityInfoList = CookieHelper.GetCookieValue(logininfo.Id);
                    string strFacilityInfoList = Encoding.Default.GetString(Convert.FromBase64String(baseStrFacilityInfoList));
                    List<ChooseDictionary> facilityInfoList = JsonHelper.ParseFromJson<List<ChooseDictionary>>(strFacilityInfoList);

                    /*将字符串转为list*/
                    List<string> Permissonslist = new List<string>(Permissons.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries));

                    /*判断是否拥有权限*/
                    if (facilityInfoList != null && facilityInfoList.Count > 0)
                    {
                        var x = (from r in facilityInfoList
                                 join p in Permissonslist on r.Value equals p
                                 select p).Count();
                        if (x > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
                httpContext.Response.StatusCode = 403;
                return false;
            }
        }
    }
}

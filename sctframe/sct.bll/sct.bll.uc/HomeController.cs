using sct.cm.data;
using sct.cm.util;
using sct.dto.uc;
using sct.svc.uc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Linq;

namespace sct.bll.uc
{
    public class HomeController : Controller
    {

        /// <summary>
        /// 资讯分类
        /// </summary>
        public IStaffService StaffService = UnitFactory.CreateUnit("StaffService") as IStaffService;

        public IMenuService MenuService = UnitFactory.CreateUnit("MenuService") as IMenuService;

        [Authorize]
        public ViewResult Index()
        {
            /*加载用户信息*/
            FormsIdentity formId = (FormsIdentity)this.HttpContext.User.Identity;
            FormsAuthenticationTicket Ticket = formId.Ticket;
            var userdata = Encoding.Default.GetString(Convert.FromBase64String(Ticket.UserData));
            LoginInfo logininfo = JsonHelper.ParseFromJson<LoginInfo>(userdata);

            /*加载用户分配的权限*/
            string baseStrFacilityInfoList = CookieHelper.GetCookieValue(logininfo.Id);
            string strFacilityInfoList = Encoding.Default.GetString(Convert.FromBase64String(baseStrFacilityInfoList));
            List<ChooseDictionary> facilityInfoList = JsonHelper.ParseFromJson<List<ChooseDictionary>>(strFacilityInfoList);


            /*获取拥有的菜单*/
            List<MenuInfo> menuInfoList = CacheData.ListAllMenuInfo(MenuService);
            var menuleaf = (from fl in facilityInfoList
                            join ml in menuInfoList on fl.ParentId equals ml.Id
                            select ml).Distinct().ToList();

            var menuroot = (from leaf in menuleaf
                            join ml in menuInfoList on leaf.ParentId equals ml.Id
                            select ml).Distinct().ToList();

            ViewBag.DicMenuRoot = menuroot;
            ViewBag.DicMenuLeaf = menuleaf;
            return View();
        }

        //[StaffAuthorize(Permissons = "rolemgr, facilitymgr")]
        public ViewResult MainPage()
        {

            /*日志测试*/
            //LogHelper.LogInfo("网站应用启动:" + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss"));
            //LogHelper.LogError("错误", new Exception("出错"));
            //LogHelper.LogDebug("调试信息", new Exception("调试信息"));

            ViewBag.Title = "MainPage";
            return View();
        }

        public ViewResult PartialFacility()
        {
            ViewBag.Title = "PartialFacility";
            return View();
        }

        public ActionResult Login(string usercode, string password, string vertifycode, string returnUrl)
        {
            //ModelState.AddModelError("", "提供的用户名或密码不正确。");

            //if (ModelState.IsValid && !string.IsNullOrEmpty(usercode) && !string.IsNullOrEmpty(password))
            if (!string.IsNullOrEmpty(usercode) && !string.IsNullOrEmpty(password))
            {
                string strPass = sct.cm.util.EncryptHelper.Md5(password);
                var adn = usercode;
                if (adn != null)
                {
                    var result = StaffService.Login(usercode, password);
                    if (result.ResultType == cm.data.OperationResultType.Success)
                    {
                        #region data
                        StaffInfo info = result.AppendData as StaffInfo;
                        LoginInfo loginInfo = new LoginInfo();
                        loginInfo.Id = info.Id;
                        loginInfo.Name = info.UserName;
                        loginInfo.StationId = info.DepartmentId;
                        #endregion


                        /*保存用户信息*/
                        string strLoginInfo = JsonHelper.GetJson<LoginInfo>(loginInfo);
                        string baseStrLoginInfo = Convert.ToBase64String(Encoding.Default.GetBytes(strLoginInfo));
                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                           adn,
                           DateTime.Now,
                           DateTime.Now.Add(FormsAuthentication.Timeout),
                           false, baseStrLoginInfo);
                        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                        FormsAuthentication.SetAuthCookie(adn, true, FormsAuthentication.FormsCookiePath);
                        Response.Cookies.Add(cookie);

                        /*保存已分配的功能*/
                        List<ChooseDictionary> FacilityInfoList = new List<ChooseDictionary>();
                        info.FacilityInfoList.ForEach(x =>
                        {
                            FacilityInfoList.Add(new ChooseDictionary() { Text = x.Id, Value = x.FacilityCode, ParentId = x.MenuId, Selected = true });
                        });
                        string strFacilityInfoList = JsonHelper.GetJson<List<ChooseDictionary>>(FacilityInfoList);
                        string baseStrFacilityInfoList = Convert.ToBase64String(Encoding.Default.GetBytes(strFacilityInfoList));
                        CookieHelper.SetCookie(info.Id, baseStrFacilityInfoList);


                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "提供的用户名或密码不正确。");
                }
            }
            return View();
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            if (null != Session["Permissons"])
                Session["Permissons"] = null;
            return RedirectToAction("LogOn", "Account");
        }

    }
}
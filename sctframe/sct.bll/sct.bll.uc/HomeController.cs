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

namespace sct.bll.uc
{
    public class HomeController : Controller
    {

        /// <summary>
        /// 资讯分类
        /// </summary>
        public IStaffService StaffService = UnitFactory.CreateUnit("StaffService") as IStaffService;

        //[StaffAuthorize(Permissons = "rolemgr,User")]
        public ViewResult Index()
        {

            /*日志测试*/
            LogHelper.LogInfo("网站应用启动:" + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss"));
            LogHelper.LogError("错误", new Exception("出错"));
            LogHelper.LogDebug("调试信息", new Exception("调试信息"));

            ViewBag.Title = "Index";
            return View();
        }

        [Authorize]
        public ViewResult MainPage()
        {
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
            ModelState.AddModelError("", "提供的用户名或密码不正确。");

            if (ModelState.IsValid && !string.IsNullOrEmpty(usercode) && !string.IsNullOrEmpty(password))
            {
                string strPass = sct.cm.util.EncryptHelper.Md5(password);
                var adn = usercode;
                if (adn != null)
                {
                    var result = StaffService.Login(usercode, password);
                    if (result.ResultType == cm.data.OperationResultType.Success)
                    {
                        StaffInfo info = result.AppendData as StaffInfo;
                        LoginInfo loginInfo = new LoginInfo();
                        loginInfo.Id = info.Id;
                        loginInfo.Name = info.UserName;
                        loginInfo.StationId = info.DepartmentId;

                        /*获取功能功能*/
                        loginInfo.FacilityFunctionList = new List<ChooseDictionary>();
                        info.FacilityFunctionInfoList.ForEach(x =>
                        {
                            loginInfo.FacilityFunctionList.Add(new ChooseDictionary() { Text = x.FunctionName, Value = x.FunctionId, ParentId = x.FacilityId });
                        });
                        /*获取菜单*/
                        string strLoginInfo = JsonHelper.GetJson<LoginInfo>(loginInfo);
                        string baseStrLoginInfo = Convert.ToBase64String(Encoding.Default.GetBytes(strLoginInfo));
                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                           adn,
                           DateTime.Now,
                           DateTime.Now.Add(FormsAuthentication.Timeout),
                           false, baseStrLoginInfo);
                        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                        Response.Cookies.Add(cookie);


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
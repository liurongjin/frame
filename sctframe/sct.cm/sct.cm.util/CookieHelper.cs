using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace sct.cm.util
{
    public class CookieHelper
    {
        #region Cookie相关

        /// <summary>
        /// 设定Cookie，从配置项[CookieExpiresDays]设定过期时间（天数），配置项无效时默认1天
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="data">数据集合</param>
        public static void SetCookie(string name, IDictionary<string, string> data)
        {
            int expires;
            int.TryParse(ConfigurationManager.AppSettings["CookieExpiresDays"] ?? "0", out expires);

            if (expires <= 0)
            {
                expires = 1;
            }

            SetCookie(name, data, expires);
        }

        /// <summary>
        /// 设定Cookie
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="data">数据集合</param>
        /// <param name="expires">过期时间（天）</param>
        public static void SetCookie(string name, IDictionary<string, string> data, int expires)
        {
            SetCookie(name, data, expires, 3);
        }

        /// <summary>
        /// 设定Cookie
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="data">数据集合</param>
        /// <param name="expires">过期时间</param>
        /// <param name="mode">过期模式: 1:Minute;2:Hour;3:Day;4:Month;5:Year</param>
        public static void SetCookie(string name, IDictionary<string, string> data, int expires, int mode)
        {
            var cookie = new HttpCookie(name);
            if (data != null)
            {
                foreach (KeyValuePair<string, string> pair in data)
                {
                    cookie.Values[pair.Key] = pair.Value;
                }
            }
            switch (mode)
            {
                case 1:
                    cookie.Expires = DateTime.Now.AddMinutes(expires);
                    break;
                case 2:
                    cookie.Expires = DateTime.Now.AddHours(expires);
                    break;
                case 3:
                    cookie.Expires = DateTime.Now.AddDays(expires);
                    break;
                case 4:
                    cookie.Expires = DateTime.Now.AddMonths(expires);
                    break;
                case 5:
                    cookie.Expires = DateTime.Now.AddYears(expires);
                    break;
                default:
                    cookie.Expires = DateTime.Now.AddMinutes(expires);
                    break;
            }
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 设定Cookie，从配置项[CookieExpiresDays]设定过期时间（天数），配置项无效时默认1天
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="value">值</param>
        public static void SetCookie(string name, string value)
        {
            int expires;
            int.TryParse(ConfigurationManager.AppSettings["CookieExpiresDays"] ?? "0", out expires);

            if (expires <= 0)
            {
                expires = 1;
            }

            SetCookie(name, value, expires, 3);
        }

        /// <summary>
        /// 设定Cookie
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="value">值</param>
        /// <param name="expires">过期时间（天）</param>
        public static void SetCookie(string name, string value, int expires)
        {
            SetCookie(name, value, expires, 3);
        }

        /// <summary>
        /// 设定Cookie
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="value">值</param>
        /// <param name="expires">过期时间</param>
        /// <param name="mode">过期模式: 1:Minute;2:Hour;3:Day;4:Month;5:Year</param>
        public static void SetCookie(string name, string value, int expires, int mode)
        {
            var cookie = new HttpCookie(name);
            cookie.Value = value;
            switch (mode)
            {
                case 1:
                    cookie.Expires = DateTime.Now.AddMinutes(expires);
                    break;
                case 2:
                    cookie.Expires = DateTime.Now.AddHours(expires);
                    break;
                case 3:
                    cookie.Expires = DateTime.Now.AddDays(expires);
                    break;
                case 4:
                    cookie.Expires = DateTime.Now.AddMonths(expires);
                    break;
                case 5:
                    cookie.Expires = DateTime.Now.AddYears(expires);
                    break;
                default:
                    cookie.Expires = DateTime.Now.AddMinutes(expires);
                    break;
            }
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 获取Cookie完整的值
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns></returns>
        public static string GetCookieValue(string name)
        {
            var cookie = HttpContext.Current.Request.Cookies[name];
            if (cookie != null)
            {
                return cookie.Value;
            }
            return null;
        }

        /// <summary>
        /// 获取Cookie中的键对应的值
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static string GetCookieValue(string name, string key)
        {
            var cookie = HttpContext.Current.Request.Cookies[name];
            if (cookie != null)
            {
                return cookie.Values[key];
            }
            return null;
        }

        /// <summary>
        /// 修改Cookie的值
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="value">值</param>
        public static void ModifyCookie(string name, string value)
        {
            var cookie = HttpContext.Current.Request.Cookies[name];
            if (cookie != null)
            {
                cookie.Value = value;
                HttpContext.Current.Response.AppendCookie(cookie);
            }
        }

        /// <summary>
        /// 修改Cookie，重新设定键所对应的值
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public static void ModifyCookie(string name, string key, string value)
        {
            var cookie = HttpContext.Current.Request.Cookies[name];
            if (cookie != null)
            {
                cookie.Values[key] = value;
                HttpContext.Current.Response.AppendCookie(cookie);
            }
        }

        /// <summary>
        /// 移除Cookie中指定的键值
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="key">键</param>
        public static void RemoveCookieValue(string name, string key)
        {
            var cookie = HttpContext.Current.Request.Cookies[name];
            if (cookie != null)
            {
                cookie.Values.Remove(key);
            }
        }

        /// <summary>
        /// 移除整个Cookie
        /// </summary>
        /// <param name="name">名称</param>
        public static void RemoveCookie(string name)
        {
            var cookie = HttpContext.Current.Request.Cookies[name];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddHours(-1);
            }
        }

        #endregion Cookie相关
    }
}
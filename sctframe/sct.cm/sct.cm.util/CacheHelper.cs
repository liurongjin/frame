using sct.cm.data;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sct.cm.util
{
    /// <summary>  
    /// .net 本身自带的cache相关方法  
    /// </summary>  
    public static class CacheHelper
    {
        /// <summary>  
        /// fileds  
        /// </summary>  
        private static System.Web.Caching.Cache ObjCache = System.Web.HttpRuntime.Cache;

        #region Exist方法
        /// <summary>  
        /// 判断指定Key的缓存是否存在  
        /// </summary>  
        /// <param name="Key"></param>  
        /// <returns></returns>  
        public static bool Exist(string Key)
        {
            if (ObjCache[Key] == null)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region  Get方法
        /// <summary>  
        /// 获得指定Key的缓存对象  
        /// </summary>  
        /// <param name="Key"></param>  
        /// <returns></returns>  
        public static Object Get(string Key)
        {
            object objkey = null;
            if (ObjCache[Key] != null)
            {
                objkey = ObjCache.Get(Key);
            }
            return objkey;
        }
        #endregion

        #region Set方法
        /// <summary>
        /// 设置缓存 缓存时间默认为系统配置时间
        /// </summary>
        /// <param name="Key">Cache Key</param>
        /// <param name="obj">缓存对象</param>
        public static void Set(string Key, object obj)
        {
            if (ObjCache[Key] != null)
            {
                ObjCache.Remove(Key);
            }
            DateTime expiry = DateTime.Now.AddMinutes(Convert.ToInt16(ConfigurationManager.AppSettings["ExpiryMinutes"]));
            ObjCache.Insert(Key, obj, null, expiry, TimeSpan.Zero);
        }

        /// <summary>  
        /// 设置缓存  
        /// </summary>  
        /// <param name="Key">Cache Key</param>  
        /// <param name="expiry">缓存时间</param>  
        /// <param name="obj">缓存对象</param>  
        public static void Set(string Key, DateTime expiry, object obj)
        {
            if (ObjCache[Key] != null)
            {
                ObjCache.Remove(Key);
            }

            ObjCache.Insert(Key, obj, null, expiry, TimeSpan.Zero);
        }

        /// <summary>  
        /// 设置缓存  
        /// </summary>  
        /// <param name="Key">Cache Key</param>  
        /// <param name="min">缓存时间【分钟】</param>  
        /// <param name="obj">缓存对象</param>  
        public static void Set(string Key, int expiryMinutes, object obj)
        {
            double douNum = double.Parse(expiryMinutes.ToString());
            Set(Key, DateTime.Now.AddMinutes(expiryMinutes), obj);
        }
        #endregion

        #region Del方法
        /// <summary>  
        /// 删除指定Key的缓存  
        /// </summary>  
        /// <param name="Key"></param>  
        public static void Del(string Key)
        {
            if (ObjCache[Key] != null)
            {
                ObjCache.Remove(Key);
            }
        }
        #endregion

        #region 其他
        /// <summary>  
        /// 获取缓存中的项数  
        /// </summary>  
        public static int Count
        {
            get
            {
                return ObjCache.Count;
            }
        }

        /// <summary>  
        /// 获取可用于缓存的千字节数  
        /// </summary>  
        public static long PrivateBytes
        {
            get
            {
                return ObjCache.EffectivePrivateBytesLimit;
            }
        }
        #endregion
    }
}

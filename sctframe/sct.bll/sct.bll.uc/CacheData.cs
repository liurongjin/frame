using sct.cm.data;
using sct.dto.uc;
using sct.svc.uc;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sct.bll.uc
{
    public class CacheData
    {
        /// <summary>
        /// 获取菜单
        /// </summary>
        /// <param name="MenuService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<MenuInfo> ListAllMenuInfo(IMenuService MenuService)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("menuname", "asc");
            List<MenuInfo> datalist = MenuService.ListAllByCondition(nvc, orderby);
            return datalist;
        }
    }
}

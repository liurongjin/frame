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
    /// <summary>
    /// 用户中心的公共方法
    /// </summary>
    public static class PublicMethod
    {
        /// <summary>
        /// 获取区域
        /// </summary>
        /// <param name="RegionService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllRegionInfo(IRegionService RegionService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("regionname", "asc");
            List<RegionInfo> datalist = RegionService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicRegion = (from slist in datalist
                             select new ChooseDictionary { Text = slist.RegionName, Value = slist.Id, ParentId = slist.ParentId }).ToList();
            return dicRegion;
        }


        /// <summary>
        /// 获取区域类型
        /// </summary>
        /// <param name="ClientTypeService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllClientTypeInfo(IClientTypeService ClientTypeService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("clienttypename", "asc");
            List<ClientTypeInfo> datalist = ClientTypeService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicClientType = (from slist in datalist
                                 select new ChooseDictionary { Text = slist.ClientTypeName, Value = slist.Id, ParentId = slist.ParentId }).ToList();
            return dicClientType;
        }

        /// <summary>
        /// 获取应用
        /// </summary>
        /// <param name="AppService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllAppInfo(IAppService AppService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("appname", "asc");
            List<AppInfo> datalist = AppService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicApp = (from slist in datalist
                          select new ChooseDictionary { Text = slist.AppName, Value = slist.Id, ParentId = null }).ToList();
            return dicApp;
        }

        /// <summary>
        /// 获取菜单
        /// </summary>
        /// <param name="MenuService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllMenuInfo(IMenuService MenuService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("menuname", "asc");
            List<MenuInfo> datalist = MenuService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicMenu = (from slist in datalist
                           select new ChooseDictionary { Text = slist.MenuName, Value = slist.Id, ParentId = slist.ParentId }).ToList();
            return dicMenu;
        }



        /// <summary>
        /// 获取公司列表
        /// </summary>
        /// <param name="MenuService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllCompanyInfo(ICompanyService CompanyService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("menuname", "asc");
            List<CompanyInfo> datalist = CompanyService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicMenu = (from slist in datalist
                           select new ChooseDictionary { Text = slist.CompanyName, Value = slist.Id, ParentId = slist.ParentId }).ToList();
            return dicMenu;
        }


        /// <summary>
        /// 获取部门列表
        /// </summary>
        /// <param name="MenuService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllDepartmentInfo(IDepartmentService DepartmentService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("menuname", "asc");
            List<DepartmentInfo> datalist = DepartmentService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicMenu = (from slist in datalist
                           select new ChooseDictionary { Text = slist.DepartmentName, Value = slist.Id, ParentId = slist.ParentId }).ToList();
            return dicMenu;
        }


        /// <summary>
        /// 获取岗位列表
        /// </summary>
        /// <param name="MenuService"></param>
        /// <param name="key">移除当前键,当为""或null不移除</param>
        /// <returns></returns>
        public static List<ChooseDictionary> ListAllStationInfo(IStationService StationService, string key)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("isvalid", "1");
            NameValueCollection orderby = new NameValueCollection();
            orderby.Add("menuname", "asc");
            List<StationInfo> datalist = StationService.ListAllByCondition(nvc, orderby);
            if (!string.IsNullOrEmpty(key))
            {
                datalist.Remove(datalist.Where(x => x.Id.Equals(key)).SingleOrDefault());
            }
            var dicMenu = (from slist in datalist
                           select new ChooseDictionary { Text = slist.StationName, Value = slist.Id, ParentId = slist.ParentId }).ToList();
            return dicMenu;
        }
    }
}

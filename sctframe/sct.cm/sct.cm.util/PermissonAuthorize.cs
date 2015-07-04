using sct.cm.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace sct.cm.util
{
    public class LoginInfo
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string StationId { get; set; }

        public string StationName { get; set; }

        public string DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public string CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string AppId { get; set; }

        public string AppName { get; set; }

        //public Dictionary<string, string> FacilityFunctionList { get; set; }
        public List<ChooseDictionary> FacilityFunctionList { get; set; }

        public List<ChooseDictionary> MenuList { get; set; }
    }

    public class PermissonAuthorize : AuthorizeAttribute
    {
        /*自定义权限验证,格式  facilitycode:functioncode,functioncode|facilitycode:functioncode,functioncode,functioncode*/
        public string Permissons { get; set; }


    }
}

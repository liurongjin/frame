using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace sct.dto.uc
{
    public partial class StaffInfo
    {

        [DataMember]
        [StringLength(36)]
        public string CompanyId { get; set; }

        [DataMember]
        [StringLength(200)]
        public string CompanyName { get; set; }

        [DataMember]
        [StringLength(200)]
        public string DepartmentName { get; set; }

        ///*用户编辑时用到*/
        //[DataMember]
        //public List<MenuInfo> MenuInfoList { get; set; }

        ///*用户编辑时用到*/
        //[DataMember]
        //public List<FacilityFunctionInfo> FacilityFunctionInfoList { get; set; }

        /*用户编辑时用到*/
        [DataMember]
        public List<StaffStationInfo> StaffStationInfoList { get; set; }

        /*登录判断时用到*/
        [DataMember]
        public List<FacilityInfo> FacilityInfoList { get; set; }

    }

}

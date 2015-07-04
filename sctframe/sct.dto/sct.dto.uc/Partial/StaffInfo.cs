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

        public List<MenuInfo> MenuInfoList { get; set; }

        public List<FacilityFunctionInfo> FacilityFunctionInfoList { get; set; }

        [DataMember]
        public List<StaffStationInfo> StaffStationInfoList { get; set; }

    }

}

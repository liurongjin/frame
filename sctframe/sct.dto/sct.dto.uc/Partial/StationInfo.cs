using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace sct.dto.uc
{

    public partial class StationInfo
    {
        [DataMember]
        [StringLength(200)]
        public string ParentName { get; set; }

        [DataMember]
        [StringLength(36)]
        public string CompanyId { get; set; }

        [DataMember]
        [StringLength(200)]
        public string CompanyName { get; set; }

        [DataMember]
        [StringLength(200)]
        public string DepartmentName { get; set; }


        [DataMember]
        public List<StationRoleInfo> StationRoleInfoList { get; set; }
    }

}

using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace sct.dto.uc
{

    public partial class FacilityInfo
    {
        [DataMember]
        [StringLength(200)]
        public string AppName { get; set; }

        [DataMember]
        public List<FacilityFunctionInfo> FacilityFunctionInfoList { get; set; }
    }

}

using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.uc
{

    public partial class RoleFacilityInfo
    {
        [DataMember]
        [StringLength(200)]
        public string FacilityName { get; set; }

        [DataMember]
        [StringLength(200)]
        public string AccessScopeName { get; set; }

        [DataMember]
        public bool Selected { get; set; }
    }

}

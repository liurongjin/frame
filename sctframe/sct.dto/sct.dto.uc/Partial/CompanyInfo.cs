using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.uc
{

    public partial class CompanyInfo
    {
        [DataMember]
        [StringLength(200)]
        public string ParentName { get; set; }

        [DataMember]
        [StringLength(200)]
        public string RegionName { get; set; }

    }

}

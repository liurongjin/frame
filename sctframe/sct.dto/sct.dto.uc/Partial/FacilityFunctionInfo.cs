using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.uc
{

    public partial class FacilityFunctionInfo
    {
        [DataMember]
        [StringLength(200)]
        public string FunctionName { get; set; }

        [DataMember]
        public bool Selected { get; set; }
    }

}

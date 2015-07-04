using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.uc
{

    public partial class StationRoleInfo
    {

        [DataMember]
        [StringLength(200)]
        public string RoleName { get; set; }


        [DataMember]
        public bool Selected { get; set; }
    }

}

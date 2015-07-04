using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.uc
{

    public partial class StaffStationInfo
    {
        [DataMember]
        [StringLength(200)]
        public string StationName { get; set; }


        [DataMember]
        public bool Selected { get; set; }
    }

}

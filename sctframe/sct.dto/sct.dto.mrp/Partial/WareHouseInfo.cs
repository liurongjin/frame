using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.mrp
{

    public partial class WareHouseInfo
    {
        [DataMember]
        [StringLength(200)]
        public string RegionName { get; set; }
    }

}

using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.cms
{

    public partial class PlateInfo
    {
        [DataMember]
        [StringLength(50)]
        public string ParentName { get; set; }
    }

}

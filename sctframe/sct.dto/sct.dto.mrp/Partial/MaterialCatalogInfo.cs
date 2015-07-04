using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.mrp
{

    public partial class MaterialCatalogInfo
    {
        [DataMember]
        [StringLength(200)]
        public string ParentName { get; set; }
    }

}

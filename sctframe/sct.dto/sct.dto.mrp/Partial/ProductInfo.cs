using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.mrp
{

    public partial class ProductInfo
    {
        [DataMember]
        [StringLength(200)]
        public string ProductCatalogName { get; set; }
    }

}

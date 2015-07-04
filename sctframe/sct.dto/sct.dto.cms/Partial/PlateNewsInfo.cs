using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.cms
{

    public partial class PlateNewsInfo
    {
        [DataMember]
        [StringLength(50)]
        public string PlateName { get; set; }

        [DataMember]
        [StringLength(100)]
        public string ArticleCatalogName { get; set; }

    }

}

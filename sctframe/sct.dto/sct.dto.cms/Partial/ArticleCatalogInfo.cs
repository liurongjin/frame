using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.cms
{

    public partial class ArticleCatalogInfo
    {
        [DataMember]
        [StringLength(100)]
        public string ParentName { get; set; }
    }

}

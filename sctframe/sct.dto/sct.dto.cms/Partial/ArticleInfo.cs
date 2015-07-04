using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace sct.dto.cms
{

    public partial class ArticleInfo
    {
        [DataMember]
        [StringLength(100)]
        public string ArticleCatalogName { get; set; }

        [DataMember]
        public ArticleDetailInfo ArticleDetail { get; set; }

        [DataMember]
        public ArticleVideoInfo ArticleVideo { get; set; }

        [DataMember]
        public List<ArticleImageInfo> ArticleImageList { get; set; }
    }

}

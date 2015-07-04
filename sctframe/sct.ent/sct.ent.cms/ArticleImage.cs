using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.cms
{

  public class ArticleImage : Entity
  {
    [StringLength(36)]
    public string ArticleId{ get; set; } 

    [StringLength(100)]
    public string AltText{ get; set; } 

    [StringLength(300)]
    public string Summary{ get; set; } 

    [StringLength(300)]
    public string Path{ get; set; } 

    [StringLength(300)]
    public string ThumbPath{ get; set; } 

  }

}

using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.cms
{

  public class PlateNews : Entity
  {
    [StringLength(36)]
    public string PlateId{ get; set; } 

    [StringLength(36)]
    public string ArticleCatalogId{ get; set; } 

    [StringLength(100)]
    public string Title{ get; set; } 

    [StringLength(300)]
    public string Summary{ get; set; } 

    public string ContentText{ get; set; } 

    [StringLength(100)]
    public string NewsLabel{ get; set; } 

    [StringLength(300)]
    public string ImageUrl{ get; set; } 

    [StringLength(300)]
    public string VideoUrl{ get; set; } 

    [StringLength(300)]
    public string VideoImage{ get; set; } 

    [StringLength(300)]
    public string TargetUrl{ get; set; } 

  }

}

using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class ProductCatalog : Entity
  {
    [StringLength(36)]
    public string ParentId{ get; set; } 

    [StringLength(200)]
    public string ProductCatalogCode{ get; set; } 

    [StringLength(200)]
    public string ProductCatalogName{ get; set; } 

  }

}

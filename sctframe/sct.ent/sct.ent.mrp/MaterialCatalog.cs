using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class MaterialCatalog : Entity
  {
    [StringLength(36)]
    public string ParentId{ get; set; } 

    [StringLength(200)]
    public string MaterialCatalogCode{ get; set; } 

    [StringLength(200)]
    public string MaterialCatalogName{ get; set; } 

  }

}

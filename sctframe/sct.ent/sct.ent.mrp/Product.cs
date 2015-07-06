using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class Product : Entity
  {
    [StringLength(36)]
    public string ProductCatalogId{ get; set; } 

    [StringLength(200)]
    public string ProductCode{ get; set; } 

    [StringLength(200)]
    public string ProductName{ get; set; } 

    [StringLength(20)]
    public string SearchKey{ get; set; } 

    public int UnitId{ get; set; } 

    [StringLength(50)]
    public string Special{ get; set; } 

    [StringLength(50)]
    public string Texture{ get; set; } 

    [StringLength(50)]
    public string Size{ get; set; } 

    [StringLength(50)]
    public string Color{ get; set; } 

    [StringLength(200)]
    public string ImageUrl{ get; set; } 

    public decimal MinStock{ get; set; } 

    public decimal Stock{ get; set; } 

    public decimal MaxStock{ get; set; } 

    [StringLength(500)]
    public string Intro{ get; set; } 

  }

}

using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class MaterialPurchaseItem : Entity
  {
    [StringLength(36)]
    public string MaterialPurchaseId{ get; set; } 

    [StringLength(36)]
    public string MaterialId{ get; set; } 

    [StringLength(200)]
    public string MaterialName{ get; set; } 

    [StringLength(50)]
    public string Special{ get; set; } 

    [StringLength(36)]
    public string UnitId{ get; set; } 

    [StringLength(50)]
    public string UnitName{ get; set; } 

    public decimal Price{ get; set; } 

    public decimal Amount{ get; set; } 

    public decimal SumPrice{ get; set; } 

    [StringLength(200)]
    public string Note{ get; set; } 

  }

}

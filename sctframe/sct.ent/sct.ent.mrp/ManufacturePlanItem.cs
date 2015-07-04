using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class ManufacturePlanItem : Entity
  {
    [StringLength(36)]
    public string ManufacturePlanId{ get; set; } 

    [StringLength(36)]
    public string ProductId{ get; set; } 

    [StringLength(200)]
    public string ProductName{ get; set; } 

    [StringLength(50)]
    public string Special{ get; set; } 

    [StringLength(36)]
    public string UnitId{ get; set; } 

    [StringLength(50)]
    public string UnitName{ get; set; } 

    public decimal Amount{ get; set; } 

    [StringLength(500)]
    public string Note{ get; set; } 

  }

}

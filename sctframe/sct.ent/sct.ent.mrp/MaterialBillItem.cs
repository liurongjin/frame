using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class MaterialBillItem : Entity
  {
    [StringLength(36)]
    public string MaterialBillId{ get; set; } 

    [StringLength(36)]
    public string MaterialId{ get; set; } 

    [StringLength(200)]
    public string MaterialName{ get; set; } 

    [StringLength(50)]
    public string Special{ get; set; } 

    public int Ratio{ get; set; } 

    [StringLength(36)]
    public string UnitId{ get; set; } 

    [StringLength(50)]
    public string UnitName{ get; set; } 

    public decimal Amount{ get; set; } 

    [StringLength(200)]
    public string Note{ get; set; } 

  }

}

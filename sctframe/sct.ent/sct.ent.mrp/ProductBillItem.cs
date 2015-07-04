using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class ProductBillItem : Entity
  {
    [StringLength(36)]
    public string ProductBillId{ get; set; } 

    [StringLength(36)]
    public string ProductId{ get; set; } 

    [StringLength(200)]
    public string ProductName{ get; set; } 

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

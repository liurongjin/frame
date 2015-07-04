using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class ProductOrderItem : Entity
  {
    [StringLength(36)]
    public string ProductOrderId{ get; set; } 

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

    public decimal Price{ get; set; } 

    public decimal SumPrice{ get; set; } 

    [StringLength(200)]
    public string Note{ get; set; } 

  }

}

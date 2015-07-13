using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class ProductWareStock : Entity
  {
    [StringLength(36)]
    public string ProductId{ get; set; } 

    [StringLength(36)]
    public string WareHouseId{ get; set; } 

    public decimal MinStock{ get; set; } 

    public decimal Stock{ get; set; } 

    public decimal MaxStock{ get; set; } 

  }

}

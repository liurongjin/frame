using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class MaterialWareStock : Entity
  {
    [StringLength(36)]
    public string MaterialId{ get; set; } 

    [StringLength(36)]
    public string WareHouseId{ get; set; } 

    public decimal MinStock{ get; set; } 

    public decimal Stock{ get; set; } 

    public decimal MaxStock{ get; set; } 

  }

}

using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class WareHouse : Entity
  {
    [StringLength(200)]
    public string WareHouseCode{ get; set; } 

    [StringLength(200)]
    public string WareHouseName{ get; set; } 

    [StringLength(36)]
    public string RegionId{ get; set; } 

    [StringLength(200)]
    public string Address{ get; set; } 

    [StringLength(500)]
    public string Note{ get; set; } 

  }

}

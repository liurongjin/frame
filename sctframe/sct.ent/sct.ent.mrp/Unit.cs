using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class Unit : Entity
  {
    [StringLength(200)]
    public string UnitCode{ get; set; } 

    [StringLength(200)]
    public string UnitName{ get; set; } 

  }

}

using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class StaffStation : Entity
  {
    [StringLength(36)]
    public string StaffId{ get; set; } 

    [StringLength(36)]
    public string StationId{ get; set; } 

  }

}

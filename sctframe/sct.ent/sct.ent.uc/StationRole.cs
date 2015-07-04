using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class StationRole : Entity
  {
    [StringLength(36)]
    public string StationId{ get; set; } 

    [StringLength(36)]
    public string RoleId{ get; set; } 

  }

}

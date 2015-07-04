using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class RoleFacility : Entity
  {
    [StringLength(36)]
    public string RoleId{ get; set; } 

    [StringLength(36)]
    public string FacilityId{ get; set; } 

    public int AccessScope{ get; set; } 

  }

}

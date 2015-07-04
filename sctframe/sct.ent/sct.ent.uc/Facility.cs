using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class Facility : Entity
  {
    [StringLength(200)]
    public string FacilityCode{ get; set; } 

    [StringLength(200)]
    public string FacilityName{ get; set; } 

    [StringLength(36)]
    public string MenuId{ get; set; } 

    [StringLength(36)]
    public string AppId{ get; set; } 

  }

}

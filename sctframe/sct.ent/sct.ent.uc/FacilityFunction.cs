using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class FacilityFunction : Entity
  {
    [StringLength(36)]
    public string FacilityId{ get; set; } 

    [StringLength(36)]
    public string FunctionId{ get; set; } 

  }

}

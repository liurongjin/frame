using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class Role : Entity
  {
    [StringLength(200)]
    public string RoleCode{ get; set; } 

    [StringLength(200)]
    public string RoleName{ get; set; } 

    [StringLength(36)]
    public string AppId{ get; set; } 

  }

}

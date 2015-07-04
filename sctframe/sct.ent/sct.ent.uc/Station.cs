using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class Station : Entity
  {
    [StringLength(36)]
    public string ParentId{ get; set; } 

    [StringLength(36)]
    public string DepartmentId{ get; set; } 

    [StringLength(200)]
    public string StationName{ get; set; } 

    [StringLength(200)]
    public string TreeNode{ get; set; } 

  }

}

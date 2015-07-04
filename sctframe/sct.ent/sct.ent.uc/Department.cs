using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class Department : Entity
  {
    [StringLength(36)]
    public string ParentId{ get; set; } 

    [StringLength(200)]
    public string DepartmentCode{ get; set; } 

    [StringLength(200)]
    public string DepartmentName{ get; set; } 

    [StringLength(36)]
    public string CompanyId{ get; set; } 

    [StringLength(200)]
    public string TreeNode{ get; set; } 

  }

}

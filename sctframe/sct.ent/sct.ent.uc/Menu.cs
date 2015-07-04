using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class Menu : Entity
  {
    [StringLength(36)]
    public string ParentId{ get; set; } 

    [StringLength(200)]
    public string MenuCode{ get; set; } 

    [StringLength(200)]
    public string MenuName{ get; set; } 

    [StringLength(200)]
    public string MenuIcon{ get; set; } 

    [StringLength(200)]
    public string MenuPath{ get; set; } 

    [StringLength(36)]
    public string AppId{ get; set; } 

    public int IsLeaf{ get; set; } 

    [StringLength(200)]
    public string TreeNode{ get; set; } 

  }

}

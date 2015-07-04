using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class Region : Entity
  {
    [StringLength(36)]
    public string ParentId{ get; set; } 

    [StringLength(200)]
    public string RegionCode{ get; set; } 

    [StringLength(200)]
    public string RegionName{ get; set; } 

    [StringLength(200)]
    public string ZipCode{ get; set; } 

    [StringLength(200)]
    public string TreeNode{ get; set; } 

  }

}

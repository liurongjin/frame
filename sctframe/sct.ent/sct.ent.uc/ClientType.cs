using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class ClientType : Entity
  {
    [StringLength(36)]
    public string ParentId{ get; set; } 

    [StringLength(200)]
    public string ClientTypeCode{ get; set; } 

    [StringLength(200)]
    public string ClientTypeName{ get; set; } 

    [StringLength(200)]
    public string TreeNode{ get; set; } 

  }

}

using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.cms
{

  public class ArticleCatalog : Entity
  {
    public int Language{ get; set; } 

    [StringLength(100)]
    public string Name{ get; set; } 

    public int IsColumn{ get; set; } 

    [StringLength(20)]
    public string Code{ get; set; } 

    [StringLength(200)]
    public string Image{ get; set; } 

    [StringLength(36)]
    public string ParentId{ get; set; } 

    [StringLength(20)]
    public string TreeNode{ get; set; } 

    [StringLength(300)]
    public string LinkUrl{ get; set; } 

  }

}

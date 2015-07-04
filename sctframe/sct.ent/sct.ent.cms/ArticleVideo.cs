using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.cms
{

  public class ArticleVideo : Entity
  {
    [StringLength(36)]
    public string ArticleId{ get; set; } 

    [StringLength(100)]
    public string Title{ get; set; } 

    [StringLength(300)]
    public string FilePath{ get; set; } 

    [StringLength(300)]
    public string FirstImagePath{ get; set; } 

  }

}

using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.cms
{

  public class ArticleDetail : Entity
  {
    [StringLength(36)]
    public string ArticleId{ get; set; } 

    public string Detail{ get; set; } 

  }

}

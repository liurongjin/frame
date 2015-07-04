using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.cms
{

  public class Article : Entity
  {
    [StringLength(36)]
    public string ArticleCatalogId{ get; set; } 

    [StringLength(20)]
    public string TreeNode{ get; set; } 

    public int ArticleType{ get; set; } 

    [StringLength(100)]
    public string Title{ get; set; } 

    [StringLength(200)]
    public string SubTitle{ get; set; } 

    [StringLength(100)]
    public string DataSource{ get; set; } 

    public DateTime FormDate{ get; set; } 

    [StringLength(100)]
    public string Keyword{ get; set; } 

    [StringLength(500)]
    public string Summary{ get; set; } 

    [StringLength(300)]
    public string SignImage{ get; set; } 

    public int Click{ get; set; } 

    public int AuditState{ get; set; } 

    [StringLength(200)]
    public string AuditReason{ get; set; } 

    public long AuditStaff{ get; set; } 

    public DateTime AuditTime{ get; set; } 

  }

}

using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class Company : Entity
  {
    [StringLength(36)]
    public string ParentId{ get; set; } 

    [StringLength(200)]
    public string CompanyCode{ get; set; } 

    [StringLength(200)]
    public string CompanyName{ get; set; } 

    [StringLength(200)]
    public string CompanyAbbreviation{ get; set; } 

    [StringLength(200)]
    public string CodeCertificate{ get; set; } 

    [StringLength(200)]
    public string BusinessCertiticate{ get; set; } 

    public DateTime RegDate{ get; set; } 

    public decimal RegMoney{ get; set; } 

    [StringLength(200)]
    public string Phone{ get; set; } 

    [StringLength(200)]
    public string Fax{ get; set; } 

    [StringLength(200)]
    public string WebSite{ get; set; } 

    [StringLength(36)]
    public string RegionId{ get; set; } 

    [StringLength(500)]
    public string DetailAddress{ get; set; } 

    [StringLength(4000)]
    public string Intro{ get; set; } 

    public int IsOwner{ get; set; } 

  }

}

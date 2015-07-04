using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class ProductOrder : Entity
  {
    [StringLength(50)]
    public string OrderNO{ get; set; } 

    [StringLength(100)]
    public string SourceConstractNo{ get; set; } 

    public DateTime ConstractFormDate{ get; set; } 

    public DateTime FormDate{ get; set; } 

    public DateTime DeliveryDate{ get; set; } 

    public decimal SumPrice{ get; set; } 

    [StringLength(36)]
    public string ClientCompanyId{ get; set; } 

    [StringLength(200)]
    public string ClientCompanyName{ get; set; } 

    [StringLength(50)]
    public string ClientContact{ get; set; } 

    [StringLength(50)]
    public string ClientMobile{ get; set; } 

    [StringLength(50)]
    public string ClientPhone{ get; set; } 

    [StringLength(50)]
    public string ClientFax{ get; set; } 

    [StringLength(200)]
    public string ClientAddress{ get; set; } 

    [StringLength(36)]
    public string HandleStationId{ get; set; } 

    [StringLength(200)]
    public string HandleStationName{ get; set; } 

    [StringLength(36)]
    public string HandleStaffId{ get; set; } 

    [StringLength(200)]
    public string HandleStaffName{ get; set; } 

    public int Status{ get; set; } 

    [StringLength(500)]
    public string Note{ get; set; } 

  }

}

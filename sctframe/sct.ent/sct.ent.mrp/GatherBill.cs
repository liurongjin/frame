using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class GatherBill : Entity
  {
    [StringLength(36)]
    public string RefId{ get; set; } 

    [StringLength(200)]
    public string RefNO{ get; set; } 

    [StringLength(50)]
    public string BillNO{ get; set; } 

    public DateTime FormDate{ get; set; } 

    public int GatherMethod{ get; set; } 

    [StringLength(200)]
    public string GatherAccount{ get; set; } 

    public decimal GatherPrice{ get; set; } 

    public DateTime GatherDate{ get; set; } 

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

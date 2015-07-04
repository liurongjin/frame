using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class MaterialPurchase : Entity
  {
    [StringLength(50)]
    public string PurchaseNO{ get; set; } 

    public DateTime FormDate{ get; set; } 

    public DateTime ReceiveDate{ get; set; } 

    public decimal SumPrice{ get; set; } 

    [StringLength(36)]
    public string SupplyCompanyId{ get; set; } 

    [StringLength(200)]
    public string SupplyCompanyName{ get; set; } 

    [StringLength(50)]
    public string SupplyContact{ get; set; } 

    [StringLength(50)]
    public string SupplyMobile{ get; set; } 

    [StringLength(50)]
    public string SupplyPhone{ get; set; } 

    [StringLength(50)]
    public string SupplyFax{ get; set; } 

    [StringLength(200)]
    public string SupplyAddress{ get; set; } 

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

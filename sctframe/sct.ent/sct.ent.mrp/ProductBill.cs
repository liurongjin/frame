using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class ProductBill : Entity
  {
    public int BillType{ get; set; } 

    [StringLength(36)]
    public string BillClassId{ get; set; } 

    [StringLength(200)]
    public string BillClassName{ get; set; } 

    [StringLength(36)]
    public string RefId{ get; set; } 

    public int RefType{ get; set; } 

    [StringLength(200)]
    public string RefNO{ get; set; } 

    [StringLength(36)]
    public string WareHouseId{ get; set; } 

    [StringLength(50)]
    public string BillNO{ get; set; } 

    public DateTime FormDate{ get; set; } 

    [StringLength(36)]
    public string NeedCompanyId{ get; set; } 

    [StringLength(200)]
    public string NeedCompanyName{ get; set; } 

    [StringLength(36)]
    public string NeedDepartmentId{ get; set; } 

    [StringLength(200)]
    public string NeedDepartmentName{ get; set; } 

    [StringLength(36)]
    public string NeedStationId{ get; set; } 

    [StringLength(200)]
    public string NeedStationName{ get; set; } 

    [StringLength(36)]
    public string NeedStaffId{ get; set; } 

    [StringLength(200)]
    public string NeedStaffName{ get; set; } 

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

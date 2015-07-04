using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class ManufacturePlan : Entity
  {
    [StringLength(36)]
    public string RefId{ get; set; } 

    [StringLength(200)]
    public string RefNO{ get; set; } 

    [StringLength(50)]
    public string BillNO{ get; set; } 

    public DateTime FormDate{ get; set; } 

    [StringLength(36)]
    public string ManfactureCompanyId{ get; set; } 

    [StringLength(200)]
    public string ManfactureCompanyName{ get; set; } 

    [StringLength(36)]
    public string ManfactureDepartmentId{ get; set; } 

    [StringLength(200)]
    public string ManfactureDepartmentName{ get; set; } 

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

using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class Staff : Entity
  {
    [StringLength(20)]
    public string UserCode{ get; set; } 

    [StringLength(200)]
    public string Password{ get; set; } 

    [StringLength(200)]
    public string UserName{ get; set; } 

    public int Sex{ get; set; } 

    public DateTime BrithDate{ get; set; } 

    [StringLength(200)]
    public string Phone{ get; set; } 

    [StringLength(200)]
    public string Fax{ get; set; } 

    [StringLength(200)]
    public string Mobile{ get; set; } 

    [StringLength(200)]
    public string Email{ get; set; } 

    [StringLength(36)]
    public string DepartmentId{ get; set; } 

    [StringLength(36)]
    public string RegionId{ get; set; } 

    [StringLength(500)]
    public string DetailAddress{ get; set; } 

    [StringLength(200)]
    public string ZipCode{ get; set; } 

    public int IsLogin{ get; set; } 

    public int IsVerify{ get; set; } 

  }

}

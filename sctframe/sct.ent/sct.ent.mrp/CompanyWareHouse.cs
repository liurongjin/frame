using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.mrp
{

  public class CompanyWareHouse : Entity
  {
    [StringLength(36)]
    public string CompanyId{ get; set; } 

    [StringLength(36)]
    public string DepartmentId{ get; set; } 

    [StringLength(36)]
    public string WareHouseId{ get; set; } 

  }

}

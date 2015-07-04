using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class CompanyStaff : Entity
  {
    [StringLength(36)]
    public string CompanyId{ get; set; } 

    [StringLength(36)]
    public string StaffId{ get; set; } 

  }

}

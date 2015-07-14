using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.cms
{

  public class Advice : Entity
  {
    public int Language{ get; set; } 

    public decimal X{ get; set; } 

    public decimal Y{ get; set; } 

    public decimal Scale{ get; set; } 

    [StringLength(200)]
    public string Title{ get; set; } 

    [StringLength(2000)]
    public string Desc{ get; set; } 

    [StringLength(50)]
    public string Contact{ get; set; } 

    [StringLength(20)]
    public string ContactMethod{ get; set; } 

    public int State{ get; set; } 

    [StringLength(2000)]
    public string ProgressLog{ get; set; } 

    [StringLength(500)]
    public string Result{ get; set; } 

    public long HandleStaffId{ get; set; } 

    [StringLength(50)]
    public string HandleStaffName{ get; set; } 

    public DateTime HandleTime{ get; set; } 

  }

}

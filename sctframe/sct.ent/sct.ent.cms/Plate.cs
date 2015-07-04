using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.cms
{

  public class Plate : Entity
  {
    [StringLength(36)]
    public string ParentId{ get; set; } 

    [StringLength(50)]
    public string Code{ get; set; } 

    [StringLength(50)]
    public string Name{ get; set; } 

    [StringLength(300)]
    public string ImageUrl{ get; set; } 

    public int PlateType{ get; set; } 

    [StringLength(500)]
    public string Summary{ get; set; } 

    public int LimitNum{ get; set; } 

  }

}

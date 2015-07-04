using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class Function : Entity
  {
    [StringLength(200)]
    public string FunctionCode{ get; set; } 

    [StringLength(200)]
    public string FunctionName{ get; set; } 

    [StringLength(200)]
    public string FunctionIcon{ get; set; } 

  }

}

using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.uc
{

  public class App : Entity
  {
    [StringLength(200)]
    public string AppCode{ get; set; } 

    [StringLength(200)]
    public string AppName{ get; set; } 

    [StringLength(200)]
    public string PublicKey{ get; set; } 

    [StringLength(200)]
    public string PrivateKey{ get; set; } 

  }

}

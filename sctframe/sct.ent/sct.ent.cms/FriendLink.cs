using System;
using sct.cm.data;
using System.ComponentModel.DataAnnotations;


namespace sct.ent.cms
{

  public class FriendLink : Entity
  {
    public int Language{ get; set; } 

    public int FriendType{ get; set; } 

    [StringLength(200)]
    public string Title{ get; set; } 

    [StringLength(200)]
    public string LinkUrl{ get; set; } 

    [StringLength(200)]
    public string LogoImage{ get; set; } 

  }

}

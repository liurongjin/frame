using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace sct.dto.uc
{

  public partial class RoleInfo
  { 
      [DataMember]
      [StringLength(200)]
      public string AppName { get; set; }

      [DataMember]
      public List<RoleFacilityInfo> RoleFacilityInfoList { get; set; }
  }

}

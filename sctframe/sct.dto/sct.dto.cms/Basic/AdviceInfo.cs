using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.cms
{

[DataContract]
  public partial class AdviceInfo
  {
    [DataMember]
    internal int  _IdIsDirty = 0; 

    [DataMember]
    internal string  _Id; 

    [DataMember]
    [StringLength(36)]
    public string  Id
    {
      get{
         return _Id;
      }
      set{
         _Id = value;
         _IdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _XIsDirty = 0; 

    [DataMember]
    internal decimal  _X; 

    [DataMember]
    public decimal  X
    {
      get{
         return _X;
      }
      set{
         _X = value;
         _XIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _YIsDirty = 0; 

    [DataMember]
    internal decimal  _Y; 

    [DataMember]
    public decimal  Y
    {
      get{
         return _Y;
      }
      set{
         _Y = value;
         _YIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ScaleIsDirty = 0; 

    [DataMember]
    internal decimal  _Scale; 

    [DataMember]
    public decimal  Scale
    {
      get{
         return _Scale;
      }
      set{
         _Scale = value;
         _ScaleIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _TitleIsDirty = 0; 

    [DataMember]
    internal string  _Title; 

    [DataMember]
    [StringLength(200)]
    public string  Title
    {
      get{
         return _Title;
      }
      set{
         _Title = value;
         _TitleIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _DescIsDirty = 0; 

    [DataMember]
    internal string  _Desc; 

    [DataMember]
    [StringLength(2000)]
    public string  Desc
    {
      get{
         return _Desc;
      }
      set{
         _Desc = value;
         _DescIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ContactIsDirty = 0; 

    [DataMember]
    internal string  _Contact; 

    [DataMember]
    [StringLength(50)]
    public string  Contact
    {
      get{
         return _Contact;
      }
      set{
         _Contact = value;
         _ContactIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ContactMethodIsDirty = 0; 

    [DataMember]
    internal string  _ContactMethod; 

    [DataMember]
    [StringLength(20)]
    public string  ContactMethod
    {
      get{
         return _ContactMethod;
      }
      set{
         _ContactMethod = value;
         _ContactMethodIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _StateIsDirty = 0; 

    [DataMember]
    internal int  _State; 

    [DataMember]
    public int  State
    {
      get{
         return _State;
      }
      set{
         _State = value;
         _StateIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ProgressLogIsDirty = 0; 

    [DataMember]
    internal string  _ProgressLog; 

    [DataMember]
    [StringLength(2000)]
    public string  ProgressLog
    {
      get{
         return _ProgressLog;
      }
      set{
         _ProgressLog = value;
         _ProgressLogIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ResultIsDirty = 0; 

    [DataMember]
    internal string  _Result; 

    [DataMember]
    [StringLength(500)]
    public string  Result
    {
      get{
         return _Result;
      }
      set{
         _Result = value;
         _ResultIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _HandleStaffIdIsDirty = 0; 

    [DataMember]
    internal long  _HandleStaffId; 

    [DataMember]
    public long  HandleStaffId
    {
      get{
         return _HandleStaffId;
      }
      set{
         _HandleStaffId = value;
         _HandleStaffIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _HandleStaffNameIsDirty = 0; 

    [DataMember]
    internal string  _HandleStaffName; 

    [DataMember]
    [StringLength(50)]
    public string  HandleStaffName
    {
      get{
         return _HandleStaffName;
      }
      set{
         _HandleStaffName = value;
         _HandleStaffNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _HandleTimeIsDirty = 0; 

    [DataMember]
    internal DateTime  _HandleTime; 

    [DataMember]
    public DateTime  HandleTime
    {
      get{
         return _HandleTime;
      }
      set{
         _HandleTime = value;
         _HandleTimeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_OrderSeqIsDirty = 0; 

    [DataMember]
    internal int  _SYS_OrderSeq; 

    [DataMember]
    public int  SYS_OrderSeq
    {
      get{
         return _SYS_OrderSeq;
      }
      set{
         _SYS_OrderSeq = value;
         _SYS_OrderSeqIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_IsValidIsDirty = 0; 

    [DataMember]
    internal int  _SYS_IsValid; 

    [DataMember]
    public int  SYS_IsValid
    {
      get{
         return _SYS_IsValid;
      }
      set{
         _SYS_IsValid = value;
         _SYS_IsValidIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_IsDeletedIsDirty = 0; 

    [DataMember]
    internal int  _SYS_IsDeleted; 

    [DataMember]
    public int  SYS_IsDeleted
    {
      get{
         return _SYS_IsDeleted;
      }
      set{
         _SYS_IsDeleted = value;
         _SYS_IsDeletedIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_RemarkIsDirty = 0; 

    [DataMember]
    internal string  _SYS_Remark; 

    [DataMember]
    [StringLength(500)]
    public string  SYS_Remark
    {
      get{
         return _SYS_Remark;
      }
      set{
         _SYS_Remark = value;
         _SYS_RemarkIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_StaffIdIsDirty = 0; 

    [DataMember]
    internal string  _SYS_StaffId; 

    [DataMember]
    [StringLength(36)]
    public string  SYS_StaffId
    {
      get{
         return _SYS_StaffId;
      }
      set{
         _SYS_StaffId = value;
         _SYS_StaffIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_StationIdIsDirty = 0; 

    [DataMember]
    internal string  _SYS_StationId; 

    [DataMember]
    [StringLength(36)]
    public string  SYS_StationId
    {
      get{
         return _SYS_StationId;
      }
      set{
         _SYS_StationId = value;
         _SYS_StationIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_DepartmentIdIsDirty = 0; 

    [DataMember]
    internal string  _SYS_DepartmentId; 

    [DataMember]
    [StringLength(36)]
    public string  SYS_DepartmentId
    {
      get{
         return _SYS_DepartmentId;
      }
      set{
         _SYS_DepartmentId = value;
         _SYS_DepartmentIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_CompanyIdIsDirty = 0; 

    [DataMember]
    internal string  _SYS_CompanyId; 

    [DataMember]
    [StringLength(36)]
    public string  SYS_CompanyId
    {
      get{
         return _SYS_CompanyId;
      }
      set{
         _SYS_CompanyId = value;
         _SYS_CompanyIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_AppIdIsDirty = 0; 

    [DataMember]
    internal string  _SYS_AppId; 

    [DataMember]
    [StringLength(36)]
    public string  SYS_AppId
    {
      get{
         return _SYS_AppId;
      }
      set{
         _SYS_AppId = value;
         _SYS_AppIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_CreateTimeIsDirty = 0; 

    [DataMember]
    internal DateTime  _SYS_CreateTime; 

    [DataMember]
    public DateTime  SYS_CreateTime
    {
      get{
         return _SYS_CreateTime;
      }
      set{
         _SYS_CreateTime = value;
         _SYS_CreateTimeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_ModifyTimeIsDirty = 0; 

    [DataMember]
    internal DateTime  _SYS_ModifyTime; 

    [DataMember]
    public DateTime  SYS_ModifyTime
    {
      get{
         return _SYS_ModifyTime;
      }
      set{
         _SYS_ModifyTime = value;
         _SYS_ModifyTimeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SYS_DeleteTimeIsDirty = 0; 

    [DataMember]
    internal DateTime  _SYS_DeleteTime; 

    [DataMember]
    public DateTime  SYS_DeleteTime
    {
      get{
         return _SYS_DeleteTime;
      }
      set{
         _SYS_DeleteTime = value;
         _SYS_DeleteTimeIsDirty = 1;
      }
    }

  }

}

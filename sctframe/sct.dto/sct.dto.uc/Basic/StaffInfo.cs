using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.uc
{

[DataContract]
  public partial class StaffInfo
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
    internal int  _UserCodeIsDirty = 0; 

    [DataMember]
    internal string  _UserCode; 

    [DataMember]
    [StringLength(20)]
    public string  UserCode
    {
      get{
         return _UserCode;
      }
      set{
         _UserCode = value;
         _UserCodeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _PasswordIsDirty = 0; 

    [DataMember]
    internal string  _Password; 

    [DataMember]
    [StringLength(200)]
    public string  Password
    {
      get{
         return _Password;
      }
      set{
         _Password = value;
         _PasswordIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _UserNameIsDirty = 0; 

    [DataMember]
    internal string  _UserName; 

    [DataMember]
    [StringLength(200)]
    public string  UserName
    {
      get{
         return _UserName;
      }
      set{
         _UserName = value;
         _UserNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SexIsDirty = 0; 

    [DataMember]
    internal int  _Sex; 

    [DataMember]
    public int  Sex
    {
      get{
         return _Sex;
      }
      set{
         _Sex = value;
         _SexIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _BrithDateIsDirty = 0; 

    [DataMember]
    internal DateTime  _BrithDate; 

    [DataMember]
    public DateTime  BrithDate
    {
      get{
         return _BrithDate;
      }
      set{
         _BrithDate = value;
         _BrithDateIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _PhoneIsDirty = 0; 

    [DataMember]
    internal string  _Phone; 

    [DataMember]
    [StringLength(200)]
    public string  Phone
    {
      get{
         return _Phone;
      }
      set{
         _Phone = value;
         _PhoneIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _FaxIsDirty = 0; 

    [DataMember]
    internal string  _Fax; 

    [DataMember]
    [StringLength(200)]
    public string  Fax
    {
      get{
         return _Fax;
      }
      set{
         _Fax = value;
         _FaxIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _MobileIsDirty = 0; 

    [DataMember]
    internal string  _Mobile; 

    [DataMember]
    [StringLength(200)]
    public string  Mobile
    {
      get{
         return _Mobile;
      }
      set{
         _Mobile = value;
         _MobileIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _EmailIsDirty = 0; 

    [DataMember]
    internal string  _Email; 

    [DataMember]
    [StringLength(200)]
    public string  Email
    {
      get{
         return _Email;
      }
      set{
         _Email = value;
         _EmailIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _DepartmentIdIsDirty = 0; 

    [DataMember]
    internal string  _DepartmentId; 

    [DataMember]
    [StringLength(36)]
    public string  DepartmentId
    {
      get{
         return _DepartmentId;
      }
      set{
         _DepartmentId = value;
         _DepartmentIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _RegionIdIsDirty = 0; 

    [DataMember]
    internal string  _RegionId; 

    [DataMember]
    [StringLength(36)]
    public string  RegionId
    {
      get{
         return _RegionId;
      }
      set{
         _RegionId = value;
         _RegionIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _DetailAddressIsDirty = 0; 

    [DataMember]
    internal string  _DetailAddress; 

    [DataMember]
    [StringLength(500)]
    public string  DetailAddress
    {
      get{
         return _DetailAddress;
      }
      set{
         _DetailAddress = value;
         _DetailAddressIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ZipCodeIsDirty = 0; 

    [DataMember]
    internal string  _ZipCode; 

    [DataMember]
    [StringLength(200)]
    public string  ZipCode
    {
      get{
         return _ZipCode;
      }
      set{
         _ZipCode = value;
         _ZipCodeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _IsLoginIsDirty = 0; 

    [DataMember]
    internal int  _IsLogin; 

    [DataMember]
    public int  IsLogin
    {
      get{
         return _IsLogin;
      }
      set{
         _IsLogin = value;
         _IsLoginIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _IsVerifyIsDirty = 0; 

    [DataMember]
    internal int  _IsVerify; 

    [DataMember]
    public int  IsVerify
    {
      get{
         return _IsVerify;
      }
      set{
         _IsVerify = value;
         _IsVerifyIsDirty = 1;
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

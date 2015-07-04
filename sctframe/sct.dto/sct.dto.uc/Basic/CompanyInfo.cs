using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.uc
{

[DataContract]
  public partial class CompanyInfo
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
    internal int  _ParentIdIsDirty = 0; 

    [DataMember]
    internal string  _ParentId; 

    [DataMember]
    [StringLength(36)]
    public string  ParentId
    {
      get{
         return _ParentId;
      }
      set{
         _ParentId = value;
         _ParentIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _CompanyCodeIsDirty = 0; 

    [DataMember]
    internal string  _CompanyCode; 

    [DataMember]
    [StringLength(200)]
    public string  CompanyCode
    {
      get{
         return _CompanyCode;
      }
      set{
         _CompanyCode = value;
         _CompanyCodeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _CompanyNameIsDirty = 0; 

    [DataMember]
    internal string  _CompanyName; 

    [DataMember]
    [StringLength(200)]
    public string  CompanyName
    {
      get{
         return _CompanyName;
      }
      set{
         _CompanyName = value;
         _CompanyNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _CompanyAbbreviationIsDirty = 0; 

    [DataMember]
    internal string  _CompanyAbbreviation; 

    [DataMember]
    [StringLength(200)]
    public string  CompanyAbbreviation
    {
      get{
         return _CompanyAbbreviation;
      }
      set{
         _CompanyAbbreviation = value;
         _CompanyAbbreviationIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _CodeCertificateIsDirty = 0; 

    [DataMember]
    internal string  _CodeCertificate; 

    [DataMember]
    [StringLength(200)]
    public string  CodeCertificate
    {
      get{
         return _CodeCertificate;
      }
      set{
         _CodeCertificate = value;
         _CodeCertificateIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _BusinessCertiticateIsDirty = 0; 

    [DataMember]
    internal string  _BusinessCertiticate; 

    [DataMember]
    [StringLength(200)]
    public string  BusinessCertiticate
    {
      get{
         return _BusinessCertiticate;
      }
      set{
         _BusinessCertiticate = value;
         _BusinessCertiticateIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _RegDateIsDirty = 0; 

    [DataMember]
    internal DateTime  _RegDate; 

    [DataMember]
    public DateTime  RegDate
    {
      get{
         return _RegDate;
      }
      set{
         _RegDate = value;
         _RegDateIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _RegMoneyIsDirty = 0; 

    [DataMember]
    internal decimal  _RegMoney; 

    [DataMember]
    public decimal  RegMoney
    {
      get{
         return _RegMoney;
      }
      set{
         _RegMoney = value;
         _RegMoneyIsDirty = 1;
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
    internal int  _WebSiteIsDirty = 0; 

    [DataMember]
    internal string  _WebSite; 

    [DataMember]
    [StringLength(200)]
    public string  WebSite
    {
      get{
         return _WebSite;
      }
      set{
         _WebSite = value;
         _WebSiteIsDirty = 1;
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
    internal int  _IntroIsDirty = 0; 

    [DataMember]
    internal string  _Intro; 

    [DataMember]
    [StringLength(4000)]
    public string  Intro
    {
      get{
         return _Intro;
      }
      set{
         _Intro = value;
         _IntroIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _IsOwnerIsDirty = 0; 

    [DataMember]
    internal int  _IsOwner; 

    [DataMember]
    public int  IsOwner
    {
      get{
         return _IsOwner;
      }
      set{
         _IsOwner = value;
         _IsOwnerIsDirty = 1;
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

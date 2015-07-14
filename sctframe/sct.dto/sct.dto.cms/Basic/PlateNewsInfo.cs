using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.cms
{

[DataContract]
  public partial class PlateNewsInfo
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
    internal int  _LanguageIsDirty = 0; 

    [DataMember]
    internal int  _Language; 

    [DataMember]
    public int  Language
    {
      get{
         return _Language;
      }
      set{
         _Language = value;
         _LanguageIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _PlateIdIsDirty = 0; 

    [DataMember]
    internal string  _PlateId; 

    [DataMember]
    [StringLength(36)]
    public string  PlateId
    {
      get{
         return _PlateId;
      }
      set{
         _PlateId = value;
         _PlateIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ArticleCatalogIdIsDirty = 0; 

    [DataMember]
    internal string  _ArticleCatalogId; 

    [DataMember]
    [StringLength(36)]
    public string  ArticleCatalogId
    {
      get{
         return _ArticleCatalogId;
      }
      set{
         _ArticleCatalogId = value;
         _ArticleCatalogIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _TitleIsDirty = 0; 

    [DataMember]
    internal string  _Title; 

    [DataMember]
    [StringLength(100)]
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
    internal int  _SummaryIsDirty = 0; 

    [DataMember]
    internal string  _Summary; 

    [DataMember]
    [StringLength(300)]
    public string  Summary
    {
      get{
         return _Summary;
      }
      set{
         _Summary = value;
         _SummaryIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ContentTextIsDirty = 0; 

    [DataMember]
    internal string  _ContentText; 

    [DataMember]
    public string  ContentText
    {
      get{
         return _ContentText;
      }
      set{
         _ContentText = value;
         _ContentTextIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _NewsLabelIsDirty = 0; 

    [DataMember]
    internal string  _NewsLabel; 

    [DataMember]
    [StringLength(100)]
    public string  NewsLabel
    {
      get{
         return _NewsLabel;
      }
      set{
         _NewsLabel = value;
         _NewsLabelIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ImageUrlIsDirty = 0; 

    [DataMember]
    internal string  _ImageUrl; 

    [DataMember]
    [StringLength(300)]
    public string  ImageUrl
    {
      get{
         return _ImageUrl;
      }
      set{
         _ImageUrl = value;
         _ImageUrlIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _VideoUrlIsDirty = 0; 

    [DataMember]
    internal string  _VideoUrl; 

    [DataMember]
    [StringLength(300)]
    public string  VideoUrl
    {
      get{
         return _VideoUrl;
      }
      set{
         _VideoUrl = value;
         _VideoUrlIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _VideoImageIsDirty = 0; 

    [DataMember]
    internal string  _VideoImage; 

    [DataMember]
    [StringLength(300)]
    public string  VideoImage
    {
      get{
         return _VideoImage;
      }
      set{
         _VideoImage = value;
         _VideoImageIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _TargetUrlIsDirty = 0; 

    [DataMember]
    internal string  _TargetUrl; 

    [DataMember]
    [StringLength(300)]
    public string  TargetUrl
    {
      get{
         return _TargetUrl;
      }
      set{
         _TargetUrl = value;
         _TargetUrlIsDirty = 1;
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

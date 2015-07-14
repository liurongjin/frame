using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.cms
{

[DataContract]
  public partial class ArticleInfo
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
    internal int  _TreeNodeIsDirty = 0; 

    [DataMember]
    internal string  _TreeNode; 

    [DataMember]
    [StringLength(20)]
    public string  TreeNode
    {
      get{
         return _TreeNode;
      }
      set{
         _TreeNode = value;
         _TreeNodeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ArticleTypeIsDirty = 0; 

    [DataMember]
    internal int  _ArticleType; 

    [DataMember]
    public int  ArticleType
    {
      get{
         return _ArticleType;
      }
      set{
         _ArticleType = value;
         _ArticleTypeIsDirty = 1;
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
    internal int  _SubTitleIsDirty = 0; 

    [DataMember]
    internal string  _SubTitle; 

    [DataMember]
    [StringLength(200)]
    public string  SubTitle
    {
      get{
         return _SubTitle;
      }
      set{
         _SubTitle = value;
         _SubTitleIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _DataSourceIsDirty = 0; 

    [DataMember]
    internal string  _DataSource; 

    [DataMember]
    [StringLength(100)]
    public string  DataSource
    {
      get{
         return _DataSource;
      }
      set{
         _DataSource = value;
         _DataSourceIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _FormDateIsDirty = 0; 

    [DataMember]
    internal DateTime  _FormDate; 

    [DataMember]
    public DateTime  FormDate
    {
      get{
         return _FormDate;
      }
      set{
         _FormDate = value;
         _FormDateIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _KeywordIsDirty = 0; 

    [DataMember]
    internal string  _Keyword; 

    [DataMember]
    [StringLength(100)]
    public string  Keyword
    {
      get{
         return _Keyword;
      }
      set{
         _Keyword = value;
         _KeywordIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SummaryIsDirty = 0; 

    [DataMember]
    internal string  _Summary; 

    [DataMember]
    [StringLength(500)]
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
    internal int  _SignImageIsDirty = 0; 

    [DataMember]
    internal string  _SignImage; 

    [DataMember]
    [StringLength(300)]
    public string  SignImage
    {
      get{
         return _SignImage;
      }
      set{
         _SignImage = value;
         _SignImageIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ClickIsDirty = 0; 

    [DataMember]
    internal int  _Click; 

    [DataMember]
    public int  Click
    {
      get{
         return _Click;
      }
      set{
         _Click = value;
         _ClickIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _AuditStateIsDirty = 0; 

    [DataMember]
    internal int  _AuditState; 

    [DataMember]
    public int  AuditState
    {
      get{
         return _AuditState;
      }
      set{
         _AuditState = value;
         _AuditStateIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _AuditReasonIsDirty = 0; 

    [DataMember]
    internal string  _AuditReason; 

    [DataMember]
    [StringLength(200)]
    public string  AuditReason
    {
      get{
         return _AuditReason;
      }
      set{
         _AuditReason = value;
         _AuditReasonIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _AuditStaffIsDirty = 0; 

    [DataMember]
    internal long  _AuditStaff; 

    [DataMember]
    public long  AuditStaff
    {
      get{
         return _AuditStaff;
      }
      set{
         _AuditStaff = value;
         _AuditStaffIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _AuditTimeIsDirty = 0; 

    [DataMember]
    internal DateTime  _AuditTime; 

    [DataMember]
    public DateTime  AuditTime
    {
      get{
         return _AuditTime;
      }
      set{
         _AuditTime = value;
         _AuditTimeIsDirty = 1;
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

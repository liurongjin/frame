using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.cms
{

[DataContract]
  public partial class ArticleCatalogInfo
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
    internal int  _NameIsDirty = 0; 

    [DataMember]
    internal string  _Name; 

    [DataMember]
    [StringLength(100)]
    public string  Name
    {
      get{
         return _Name;
      }
      set{
         _Name = value;
         _NameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _IsColumnIsDirty = 0; 

    [DataMember]
    internal int  _IsColumn; 

    [DataMember]
    public int  IsColumn
    {
      get{
         return _IsColumn;
      }
      set{
         _IsColumn = value;
         _IsColumnIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _CodeIsDirty = 0; 

    [DataMember]
    internal string  _Code; 

    [DataMember]
    [StringLength(20)]
    public string  Code
    {
      get{
         return _Code;
      }
      set{
         _Code = value;
         _CodeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ImageIsDirty = 0; 

    [DataMember]
    internal string  _Image; 

    [DataMember]
    [StringLength(200)]
    public string  Image
    {
      get{
         return _Image;
      }
      set{
         _Image = value;
         _ImageIsDirty = 1;
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
    internal int  _LinkUrlIsDirty = 0; 

    [DataMember]
    internal string  _LinkUrl; 

    [DataMember]
    [StringLength(300)]
    public string  LinkUrl
    {
      get{
         return _LinkUrl;
      }
      set{
         _LinkUrl = value;
         _LinkUrlIsDirty = 1;
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

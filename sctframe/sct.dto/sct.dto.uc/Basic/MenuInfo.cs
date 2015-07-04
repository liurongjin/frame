using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.uc
{

[DataContract]
  public partial class MenuInfo
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
    internal int  _MenuCodeIsDirty = 0; 

    [DataMember]
    internal string  _MenuCode; 

    [DataMember]
    [StringLength(200)]
    public string  MenuCode
    {
      get{
         return _MenuCode;
      }
      set{
         _MenuCode = value;
         _MenuCodeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _MenuNameIsDirty = 0; 

    [DataMember]
    internal string  _MenuName; 

    [DataMember]
    [StringLength(200)]
    public string  MenuName
    {
      get{
         return _MenuName;
      }
      set{
         _MenuName = value;
         _MenuNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _MenuIconIsDirty = 0; 

    [DataMember]
    internal string  _MenuIcon; 

    [DataMember]
    [StringLength(200)]
    public string  MenuIcon
    {
      get{
         return _MenuIcon;
      }
      set{
         _MenuIcon = value;
         _MenuIconIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _MenuPathIsDirty = 0; 

    [DataMember]
    internal string  _MenuPath; 

    [DataMember]
    [StringLength(200)]
    public string  MenuPath
    {
      get{
         return _MenuPath;
      }
      set{
         _MenuPath = value;
         _MenuPathIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _AppIdIsDirty = 0; 

    [DataMember]
    internal string  _AppId; 

    [DataMember]
    [StringLength(36)]
    public string  AppId
    {
      get{
         return _AppId;
      }
      set{
         _AppId = value;
         _AppIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _IsLeafIsDirty = 0; 

    [DataMember]
    internal int  _IsLeaf; 

    [DataMember]
    public int  IsLeaf
    {
      get{
         return _IsLeaf;
      }
      set{
         _IsLeaf = value;
         _IsLeafIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _TreeNodeIsDirty = 0; 

    [DataMember]
    internal string  _TreeNode; 

    [DataMember]
    [StringLength(200)]
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

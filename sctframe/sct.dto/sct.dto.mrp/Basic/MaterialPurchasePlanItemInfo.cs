using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.mrp
{

[DataContract]
  public partial class MaterialPurchasePlanItemInfo
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
    internal int  _MaterialPurchasePlanIdIsDirty = 0; 

    [DataMember]
    internal string  _MaterialPurchasePlanId; 

    [DataMember]
    [StringLength(36)]
    public string  MaterialPurchasePlanId
    {
      get{
         return _MaterialPurchasePlanId;
      }
      set{
         _MaterialPurchasePlanId = value;
         _MaterialPurchasePlanIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _MaterialIdIsDirty = 0; 

    [DataMember]
    internal string  _MaterialId; 

    [DataMember]
    [StringLength(36)]
    public string  MaterialId
    {
      get{
         return _MaterialId;
      }
      set{
         _MaterialId = value;
         _MaterialIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _MaterialNameIsDirty = 0; 

    [DataMember]
    internal string  _MaterialName; 

    [DataMember]
    [StringLength(200)]
    public string  MaterialName
    {
      get{
         return _MaterialName;
      }
      set{
         _MaterialName = value;
         _MaterialNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SpecialIsDirty = 0; 

    [DataMember]
    internal string  _Special; 

    [DataMember]
    [StringLength(50)]
    public string  Special
    {
      get{
         return _Special;
      }
      set{
         _Special = value;
         _SpecialIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _UnitIdIsDirty = 0; 

    [DataMember]
    internal string  _UnitId; 

    [DataMember]
    [StringLength(36)]
    public string  UnitId
    {
      get{
         return _UnitId;
      }
      set{
         _UnitId = value;
         _UnitIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _UnitNameIsDirty = 0; 

    [DataMember]
    internal string  _UnitName; 

    [DataMember]
    [StringLength(50)]
    public string  UnitName
    {
      get{
         return _UnitName;
      }
      set{
         _UnitName = value;
         _UnitNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _AmountIsDirty = 0; 

    [DataMember]
    internal decimal  _Amount; 

    [DataMember]
    public decimal  Amount
    {
      get{
         return _Amount;
      }
      set{
         _Amount = value;
         _AmountIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _NoteIsDirty = 0; 

    [DataMember]
    internal string  _Note; 

    [DataMember]
    [StringLength(200)]
    public string  Note
    {
      get{
         return _Note;
      }
      set{
         _Note = value;
         _NoteIsDirty = 1;
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

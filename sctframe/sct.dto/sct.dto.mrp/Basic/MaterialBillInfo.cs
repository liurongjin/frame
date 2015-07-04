using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.mrp
{

[DataContract]
  public partial class MaterialBillInfo
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
    internal int  _BillTypeIsDirty = 0; 

    [DataMember]
    internal int  _BillType; 

    [DataMember]
    public int  BillType
    {
      get{
         return _BillType;
      }
      set{
         _BillType = value;
         _BillTypeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _BillClassIdIsDirty = 0; 

    [DataMember]
    internal string  _BillClassId; 

    [DataMember]
    [StringLength(36)]
    public string  BillClassId
    {
      get{
         return _BillClassId;
      }
      set{
         _BillClassId = value;
         _BillClassIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _RefTypeIsDirty = 0; 

    [DataMember]
    internal int  _RefType; 

    [DataMember]
    public int  RefType
    {
      get{
         return _RefType;
      }
      set{
         _RefType = value;
         _RefTypeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _BillClassNameIsDirty = 0; 

    [DataMember]
    internal string  _BillClassName; 

    [DataMember]
    [StringLength(200)]
    public string  BillClassName
    {
      get{
         return _BillClassName;
      }
      set{
         _BillClassName = value;
         _BillClassNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _RefIdIsDirty = 0; 

    [DataMember]
    internal string  _RefId; 

    [DataMember]
    [StringLength(36)]
    public string  RefId
    {
      get{
         return _RefId;
      }
      set{
         _RefId = value;
         _RefIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _RefNOIsDirty = 0; 

    [DataMember]
    internal string  _RefNO; 

    [DataMember]
    [StringLength(200)]
    public string  RefNO
    {
      get{
         return _RefNO;
      }
      set{
         _RefNO = value;
         _RefNOIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _BillNOIsDirty = 0; 

    [DataMember]
    internal string  _BillNO; 

    [DataMember]
    [StringLength(50)]
    public string  BillNO
    {
      get{
         return _BillNO;
      }
      set{
         _BillNO = value;
         _BillNOIsDirty = 1;
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
    internal int  _NeedCompanyIdIsDirty = 0; 

    [DataMember]
    internal string  _NeedCompanyId; 

    [DataMember]
    [StringLength(36)]
    public string  NeedCompanyId
    {
      get{
         return _NeedCompanyId;
      }
      set{
         _NeedCompanyId = value;
         _NeedCompanyIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _NeedCompanyNameIsDirty = 0; 

    [DataMember]
    internal string  _NeedCompanyName; 

    [DataMember]
    [StringLength(200)]
    public string  NeedCompanyName
    {
      get{
         return _NeedCompanyName;
      }
      set{
         _NeedCompanyName = value;
         _NeedCompanyNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _NeedDepartmentIdIsDirty = 0; 

    [DataMember]
    internal string  _NeedDepartmentId; 

    [DataMember]
    [StringLength(36)]
    public string  NeedDepartmentId
    {
      get{
         return _NeedDepartmentId;
      }
      set{
         _NeedDepartmentId = value;
         _NeedDepartmentIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _NeedDepartmentNameIsDirty = 0; 

    [DataMember]
    internal string  _NeedDepartmentName; 

    [DataMember]
    [StringLength(200)]
    public string  NeedDepartmentName
    {
      get{
         return _NeedDepartmentName;
      }
      set{
         _NeedDepartmentName = value;
         _NeedDepartmentNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _NeedStationIdIsDirty = 0; 

    [DataMember]
    internal string  _NeedStationId; 

    [DataMember]
    [StringLength(36)]
    public string  NeedStationId
    {
      get{
         return _NeedStationId;
      }
      set{
         _NeedStationId = value;
         _NeedStationIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _NeedStationNameIsDirty = 0; 

    [DataMember]
    internal string  _NeedStationName; 

    [DataMember]
    [StringLength(200)]
    public string  NeedStationName
    {
      get{
         return _NeedStationName;
      }
      set{
         _NeedStationName = value;
         _NeedStationNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _NeedStaffIdIsDirty = 0; 

    [DataMember]
    internal string  _NeedStaffId; 

    [DataMember]
    [StringLength(36)]
    public string  NeedStaffId
    {
      get{
         return _NeedStaffId;
      }
      set{
         _NeedStaffId = value;
         _NeedStaffIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _NeedStaffNameIsDirty = 0; 

    [DataMember]
    internal string  _NeedStaffName; 

    [DataMember]
    [StringLength(200)]
    public string  NeedStaffName
    {
      get{
         return _NeedStaffName;
      }
      set{
         _NeedStaffName = value;
         _NeedStaffNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _HandleStationIdIsDirty = 0; 

    [DataMember]
    internal string  _HandleStationId; 

    [DataMember]
    [StringLength(36)]
    public string  HandleStationId
    {
      get{
         return _HandleStationId;
      }
      set{
         _HandleStationId = value;
         _HandleStationIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _HandleStationNameIsDirty = 0; 

    [DataMember]
    internal string  _HandleStationName; 

    [DataMember]
    [StringLength(200)]
    public string  HandleStationName
    {
      get{
         return _HandleStationName;
      }
      set{
         _HandleStationName = value;
         _HandleStationNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _HandleStaffIdIsDirty = 0; 

    [DataMember]
    internal string  _HandleStaffId; 

    [DataMember]
    [StringLength(36)]
    public string  HandleStaffId
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
    [StringLength(200)]
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
    internal int  _StatusIsDirty = 0; 

    [DataMember]
    internal int  _Status; 

    [DataMember]
    public int  Status
    {
      get{
         return _Status;
      }
      set{
         _Status = value;
         _StatusIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _NoteIsDirty = 0; 

    [DataMember]
    internal string  _Note; 

    [DataMember]
    [StringLength(500)]
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

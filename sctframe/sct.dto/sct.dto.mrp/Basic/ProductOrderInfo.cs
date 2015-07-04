using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.mrp
{

[DataContract]
  public partial class ProductOrderInfo
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
    internal int  _OrderNOIsDirty = 0; 

    [DataMember]
    internal string  _OrderNO; 

    [DataMember]
    [StringLength(50)]
    public string  OrderNO
    {
      get{
         return _OrderNO;
      }
      set{
         _OrderNO = value;
         _OrderNOIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SourceConstractNoIsDirty = 0; 

    [DataMember]
    internal string  _SourceConstractNo; 

    [DataMember]
    [StringLength(100)]
    public string  SourceConstractNo
    {
      get{
         return _SourceConstractNo;
      }
      set{
         _SourceConstractNo = value;
         _SourceConstractNoIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ConstractFormDateIsDirty = 0; 

    [DataMember]
    internal DateTime  _ConstractFormDate; 

    [DataMember]
    public DateTime  ConstractFormDate
    {
      get{
         return _ConstractFormDate;
      }
      set{
         _ConstractFormDate = value;
         _ConstractFormDateIsDirty = 1;
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
    internal int  _DeliveryDateIsDirty = 0; 

    [DataMember]
    internal DateTime  _DeliveryDate; 

    [DataMember]
    public DateTime  DeliveryDate
    {
      get{
         return _DeliveryDate;
      }
      set{
         _DeliveryDate = value;
         _DeliveryDateIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SumPriceIsDirty = 0; 

    [DataMember]
    internal decimal  _SumPrice; 

    [DataMember]
    public decimal  SumPrice
    {
      get{
         return _SumPrice;
      }
      set{
         _SumPrice = value;
         _SumPriceIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ClientCompanyIdIsDirty = 0; 

    [DataMember]
    internal string  _ClientCompanyId; 

    [DataMember]
    [StringLength(36)]
    public string  ClientCompanyId
    {
      get{
         return _ClientCompanyId;
      }
      set{
         _ClientCompanyId = value;
         _ClientCompanyIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ClientCompanyNameIsDirty = 0; 

    [DataMember]
    internal string  _ClientCompanyName; 

    [DataMember]
    [StringLength(200)]
    public string  ClientCompanyName
    {
      get{
         return _ClientCompanyName;
      }
      set{
         _ClientCompanyName = value;
         _ClientCompanyNameIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ClientContactIsDirty = 0; 

    [DataMember]
    internal string  _ClientContact; 

    [DataMember]
    [StringLength(50)]
    public string  ClientContact
    {
      get{
         return _ClientContact;
      }
      set{
         _ClientContact = value;
         _ClientContactIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ClientMobileIsDirty = 0; 

    [DataMember]
    internal string  _ClientMobile; 

    [DataMember]
    [StringLength(50)]
    public string  ClientMobile
    {
      get{
         return _ClientMobile;
      }
      set{
         _ClientMobile = value;
         _ClientMobileIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ClientPhoneIsDirty = 0; 

    [DataMember]
    internal string  _ClientPhone; 

    [DataMember]
    [StringLength(50)]
    public string  ClientPhone
    {
      get{
         return _ClientPhone;
      }
      set{
         _ClientPhone = value;
         _ClientPhoneIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ClientFaxIsDirty = 0; 

    [DataMember]
    internal string  _ClientFax; 

    [DataMember]
    [StringLength(50)]
    public string  ClientFax
    {
      get{
         return _ClientFax;
      }
      set{
         _ClientFax = value;
         _ClientFaxIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ClientAddressIsDirty = 0; 

    [DataMember]
    internal string  _ClientAddress; 

    [DataMember]
    [StringLength(200)]
    public string  ClientAddress
    {
      get{
         return _ClientAddress;
      }
      set{
         _ClientAddress = value;
         _ClientAddressIsDirty = 1;
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

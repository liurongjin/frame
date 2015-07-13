using sct.ent.mrp;


namespace sct.dto.mrp
{

  public class DESwap
  {

    public static void CompanyWareHouseDTE(CompanyWareHouseInfo info, CompanyWareHouse entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._CompanyIdIsDirty == 1)
        {
           entity.CompanyId = info.CompanyId;
           info._CompanyIdIsDirty = 0;
        }

       if (info._DepartmentIdIsDirty == 1)
        {
           entity.DepartmentId = info.DepartmentId;
           info._DepartmentIdIsDirty = 0;
        }

       if (info._WareHouseIdIsDirty == 1)
        {
           entity.WareHouseId = info.WareHouseId;
           info._WareHouseIdIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void CompanyWareHouseETD(CompanyWareHouse entity, CompanyWareHouseInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.CompanyId = entity.CompanyId;
       info._CompanyIdIsDirty = 0;

       info.DepartmentId = entity.DepartmentId;
       info._DepartmentIdIsDirty = 0;

       info.WareHouseId = entity.WareHouseId;
       info._WareHouseIdIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void GatherBillDTE(GatherBillInfo info, GatherBill entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._RefIdIsDirty == 1)
        {
           entity.RefId = info.RefId;
           info._RefIdIsDirty = 0;
        }

       if (info._RefNOIsDirty == 1)
        {
           entity.RefNO = info.RefNO;
           info._RefNOIsDirty = 0;
        }

       if (info._BillNOIsDirty == 1)
        {
           entity.BillNO = info.BillNO;
           info._BillNOIsDirty = 0;
        }

       if (info._FormDateIsDirty == 1)
        {
           entity.FormDate = info.FormDate;
           info._FormDateIsDirty = 0;
        }

       if (info._GatherMethodIsDirty == 1)
        {
           entity.GatherMethod = info.GatherMethod;
           info._GatherMethodIsDirty = 0;
        }

       if (info._GatherAccountIsDirty == 1)
        {
           entity.GatherAccount = info.GatherAccount;
           info._GatherAccountIsDirty = 0;
        }

       if (info._GatherPriceIsDirty == 1)
        {
           entity.GatherPrice = info.GatherPrice;
           info._GatherPriceIsDirty = 0;
        }

       if (info._GatherDateIsDirty == 1)
        {
           entity.GatherDate = info.GatherDate;
           info._GatherDateIsDirty = 0;
        }

       if (info._ClientCompanyIdIsDirty == 1)
        {
           entity.ClientCompanyId = info.ClientCompanyId;
           info._ClientCompanyIdIsDirty = 0;
        }

       if (info._ClientCompanyNameIsDirty == 1)
        {
           entity.ClientCompanyName = info.ClientCompanyName;
           info._ClientCompanyNameIsDirty = 0;
        }

       if (info._ClientContactIsDirty == 1)
        {
           entity.ClientContact = info.ClientContact;
           info._ClientContactIsDirty = 0;
        }

       if (info._ClientMobileIsDirty == 1)
        {
           entity.ClientMobile = info.ClientMobile;
           info._ClientMobileIsDirty = 0;
        }

       if (info._ClientPhoneIsDirty == 1)
        {
           entity.ClientPhone = info.ClientPhone;
           info._ClientPhoneIsDirty = 0;
        }

       if (info._ClientFaxIsDirty == 1)
        {
           entity.ClientFax = info.ClientFax;
           info._ClientFaxIsDirty = 0;
        }

       if (info._ClientAddressIsDirty == 1)
        {
           entity.ClientAddress = info.ClientAddress;
           info._ClientAddressIsDirty = 0;
        }

       if (info._HandleStationIdIsDirty == 1)
        {
           entity.HandleStationId = info.HandleStationId;
           info._HandleStationIdIsDirty = 0;
        }

       if (info._HandleStationNameIsDirty == 1)
        {
           entity.HandleStationName = info.HandleStationName;
           info._HandleStationNameIsDirty = 0;
        }

       if (info._HandleStaffIdIsDirty == 1)
        {
           entity.HandleStaffId = info.HandleStaffId;
           info._HandleStaffIdIsDirty = 0;
        }

       if (info._HandleStaffNameIsDirty == 1)
        {
           entity.HandleStaffName = info.HandleStaffName;
           info._HandleStaffNameIsDirty = 0;
        }

       if (info._StatusIsDirty == 1)
        {
           entity.Status = info.Status;
           info._StatusIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void GatherBillETD(GatherBill entity, GatherBillInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.RefId = entity.RefId;
       info._RefIdIsDirty = 0;

       info.RefNO = entity.RefNO;
       info._RefNOIsDirty = 0;

       info.BillNO = entity.BillNO;
       info._BillNOIsDirty = 0;

       info.FormDate = entity.FormDate;
       info._FormDateIsDirty = 0;

       info.GatherMethod = entity.GatherMethod;
       info._GatherMethodIsDirty = 0;

       info.GatherAccount = entity.GatherAccount;
       info._GatherAccountIsDirty = 0;

       info.GatherPrice = entity.GatherPrice;
       info._GatherPriceIsDirty = 0;

       info.GatherDate = entity.GatherDate;
       info._GatherDateIsDirty = 0;

       info.ClientCompanyId = entity.ClientCompanyId;
       info._ClientCompanyIdIsDirty = 0;

       info.ClientCompanyName = entity.ClientCompanyName;
       info._ClientCompanyNameIsDirty = 0;

       info.ClientContact = entity.ClientContact;
       info._ClientContactIsDirty = 0;

       info.ClientMobile = entity.ClientMobile;
       info._ClientMobileIsDirty = 0;

       info.ClientPhone = entity.ClientPhone;
       info._ClientPhoneIsDirty = 0;

       info.ClientFax = entity.ClientFax;
       info._ClientFaxIsDirty = 0;

       info.ClientAddress = entity.ClientAddress;
       info._ClientAddressIsDirty = 0;

       info.HandleStationId = entity.HandleStationId;
       info._HandleStationIdIsDirty = 0;

       info.HandleStationName = entity.HandleStationName;
       info._HandleStationNameIsDirty = 0;

       info.HandleStaffId = entity.HandleStaffId;
       info._HandleStaffIdIsDirty = 0;

       info.HandleStaffName = entity.HandleStaffName;
       info._HandleStaffNameIsDirty = 0;

       info.Status = entity.Status;
       info._StatusIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void ManufacturePlanDTE(ManufacturePlanInfo info, ManufacturePlan entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._RefIdIsDirty == 1)
        {
           entity.RefId = info.RefId;
           info._RefIdIsDirty = 0;
        }

       if (info._RefNOIsDirty == 1)
        {
           entity.RefNO = info.RefNO;
           info._RefNOIsDirty = 0;
        }

       if (info._BillNOIsDirty == 1)
        {
           entity.BillNO = info.BillNO;
           info._BillNOIsDirty = 0;
        }

       if (info._FormDateIsDirty == 1)
        {
           entity.FormDate = info.FormDate;
           info._FormDateIsDirty = 0;
        }

       if (info._ManfactureCompanyIdIsDirty == 1)
        {
           entity.ManfactureCompanyId = info.ManfactureCompanyId;
           info._ManfactureCompanyIdIsDirty = 0;
        }

       if (info._ManfactureCompanyNameIsDirty == 1)
        {
           entity.ManfactureCompanyName = info.ManfactureCompanyName;
           info._ManfactureCompanyNameIsDirty = 0;
        }

       if (info._ManfactureDepartmentIdIsDirty == 1)
        {
           entity.ManfactureDepartmentId = info.ManfactureDepartmentId;
           info._ManfactureDepartmentIdIsDirty = 0;
        }

       if (info._ManfactureDepartmentNameIsDirty == 1)
        {
           entity.ManfactureDepartmentName = info.ManfactureDepartmentName;
           info._ManfactureDepartmentNameIsDirty = 0;
        }

       if (info._HandleStationIdIsDirty == 1)
        {
           entity.HandleStationId = info.HandleStationId;
           info._HandleStationIdIsDirty = 0;
        }

       if (info._HandleStationNameIsDirty == 1)
        {
           entity.HandleStationName = info.HandleStationName;
           info._HandleStationNameIsDirty = 0;
        }

       if (info._HandleStaffIdIsDirty == 1)
        {
           entity.HandleStaffId = info.HandleStaffId;
           info._HandleStaffIdIsDirty = 0;
        }

       if (info._HandleStaffNameIsDirty == 1)
        {
           entity.HandleStaffName = info.HandleStaffName;
           info._HandleStaffNameIsDirty = 0;
        }

       if (info._StatusIsDirty == 1)
        {
           entity.Status = info.Status;
           info._StatusIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void ManufacturePlanETD(ManufacturePlan entity, ManufacturePlanInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.RefId = entity.RefId;
       info._RefIdIsDirty = 0;

       info.RefNO = entity.RefNO;
       info._RefNOIsDirty = 0;

       info.BillNO = entity.BillNO;
       info._BillNOIsDirty = 0;

       info.FormDate = entity.FormDate;
       info._FormDateIsDirty = 0;

       info.ManfactureCompanyId = entity.ManfactureCompanyId;
       info._ManfactureCompanyIdIsDirty = 0;

       info.ManfactureCompanyName = entity.ManfactureCompanyName;
       info._ManfactureCompanyNameIsDirty = 0;

       info.ManfactureDepartmentId = entity.ManfactureDepartmentId;
       info._ManfactureDepartmentIdIsDirty = 0;

       info.ManfactureDepartmentName = entity.ManfactureDepartmentName;
       info._ManfactureDepartmentNameIsDirty = 0;

       info.HandleStationId = entity.HandleStationId;
       info._HandleStationIdIsDirty = 0;

       info.HandleStationName = entity.HandleStationName;
       info._HandleStationNameIsDirty = 0;

       info.HandleStaffId = entity.HandleStaffId;
       info._HandleStaffIdIsDirty = 0;

       info.HandleStaffName = entity.HandleStaffName;
       info._HandleStaffNameIsDirty = 0;

       info.Status = entity.Status;
       info._StatusIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void ManufacturePlanItemDTE(ManufacturePlanItemInfo info, ManufacturePlanItem entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ManufacturePlanIdIsDirty == 1)
        {
           entity.ManufacturePlanId = info.ManufacturePlanId;
           info._ManufacturePlanIdIsDirty = 0;
        }

       if (info._ProductIdIsDirty == 1)
        {
           entity.ProductId = info.ProductId;
           info._ProductIdIsDirty = 0;
        }

       if (info._ProductNameIsDirty == 1)
        {
           entity.ProductName = info.ProductName;
           info._ProductNameIsDirty = 0;
        }

       if (info._SpecialIsDirty == 1)
        {
           entity.Special = info.Special;
           info._SpecialIsDirty = 0;
        }

       if (info._UnitIdIsDirty == 1)
        {
           entity.UnitId = info.UnitId;
           info._UnitIdIsDirty = 0;
        }

       if (info._UnitNameIsDirty == 1)
        {
           entity.UnitName = info.UnitName;
           info._UnitNameIsDirty = 0;
        }

       if (info._AmountIsDirty == 1)
        {
           entity.Amount = info.Amount;
           info._AmountIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void ManufacturePlanItemETD(ManufacturePlanItem entity, ManufacturePlanItemInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ManufacturePlanId = entity.ManufacturePlanId;
       info._ManufacturePlanIdIsDirty = 0;

       info.ProductId = entity.ProductId;
       info._ProductIdIsDirty = 0;

       info.ProductName = entity.ProductName;
       info._ProductNameIsDirty = 0;

       info.Special = entity.Special;
       info._SpecialIsDirty = 0;

       info.UnitId = entity.UnitId;
       info._UnitIdIsDirty = 0;

       info.UnitName = entity.UnitName;
       info._UnitNameIsDirty = 0;

       info.Amount = entity.Amount;
       info._AmountIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void MaterialDTE(MaterialInfo info, Material entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._MaterialCatalogIdIsDirty == 1)
        {
           entity.MaterialCatalogId = info.MaterialCatalogId;
           info._MaterialCatalogIdIsDirty = 0;
        }

       if (info._MaterialCodeIsDirty == 1)
        {
           entity.MaterialCode = info.MaterialCode;
           info._MaterialCodeIsDirty = 0;
        }

       if (info._MaterialNameIsDirty == 1)
        {
           entity.MaterialName = info.MaterialName;
           info._MaterialNameIsDirty = 0;
        }

       if (info._SearchKeyIsDirty == 1)
        {
           entity.SearchKey = info.SearchKey;
           info._SearchKeyIsDirty = 0;
        }

       if (info._UnitIdIsDirty == 1)
        {
           entity.UnitId = info.UnitId;
           info._UnitIdIsDirty = 0;
        }

       if (info._SpecialIsDirty == 1)
        {
           entity.Special = info.Special;
           info._SpecialIsDirty = 0;
        }

       if (info._TextureIsDirty == 1)
        {
           entity.Texture = info.Texture;
           info._TextureIsDirty = 0;
        }

       if (info._SizeIsDirty == 1)
        {
           entity.Size = info.Size;
           info._SizeIsDirty = 0;
        }

       if (info._ColorIsDirty == 1)
        {
           entity.Color = info.Color;
           info._ColorIsDirty = 0;
        }

       if (info._ImageUrlIsDirty == 1)
        {
           entity.ImageUrl = info.ImageUrl;
           info._ImageUrlIsDirty = 0;
        }

       if (info._MinStockIsDirty == 1)
        {
           entity.MinStock = info.MinStock;
           info._MinStockIsDirty = 0;
        }

       if (info._StockIsDirty == 1)
        {
           entity.Stock = info.Stock;
           info._StockIsDirty = 0;
        }

       if (info._MaxStockIsDirty == 1)
        {
           entity.MaxStock = info.MaxStock;
           info._MaxStockIsDirty = 0;
        }

       if (info._IntroIsDirty == 1)
        {
           entity.Intro = info.Intro;
           info._IntroIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void MaterialETD(Material entity, MaterialInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.MaterialCatalogId = entity.MaterialCatalogId;
       info._MaterialCatalogIdIsDirty = 0;

       info.MaterialCode = entity.MaterialCode;
       info._MaterialCodeIsDirty = 0;

       info.MaterialName = entity.MaterialName;
       info._MaterialNameIsDirty = 0;

       info.SearchKey = entity.SearchKey;
       info._SearchKeyIsDirty = 0;

       info.UnitId = entity.UnitId;
       info._UnitIdIsDirty = 0;

       info.Special = entity.Special;
       info._SpecialIsDirty = 0;

       info.Texture = entity.Texture;
       info._TextureIsDirty = 0;

       info.Size = entity.Size;
       info._SizeIsDirty = 0;

       info.Color = entity.Color;
       info._ColorIsDirty = 0;

       info.ImageUrl = entity.ImageUrl;
       info._ImageUrlIsDirty = 0;

       info.MinStock = entity.MinStock;
       info._MinStockIsDirty = 0;

       info.Stock = entity.Stock;
       info._StockIsDirty = 0;

       info.MaxStock = entity.MaxStock;
       info._MaxStockIsDirty = 0;

       info.Intro = entity.Intro;
       info._IntroIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void MaterialBillDTE(MaterialBillInfo info, MaterialBill entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._BillTypeIsDirty == 1)
        {
           entity.BillType = info.BillType;
           info._BillTypeIsDirty = 0;
        }

       if (info._BillClassIdIsDirty == 1)
        {
           entity.BillClassId = info.BillClassId;
           info._BillClassIdIsDirty = 0;
        }

       if (info._RefTypeIsDirty == 1)
        {
           entity.RefType = info.RefType;
           info._RefTypeIsDirty = 0;
        }

       if (info._BillClassNameIsDirty == 1)
        {
           entity.BillClassName = info.BillClassName;
           info._BillClassNameIsDirty = 0;
        }

       if (info._RefIdIsDirty == 1)
        {
           entity.RefId = info.RefId;
           info._RefIdIsDirty = 0;
        }

       if (info._RefNOIsDirty == 1)
        {
           entity.RefNO = info.RefNO;
           info._RefNOIsDirty = 0;
        }

       if (info._WareHouseIdIsDirty == 1)
        {
           entity.WareHouseId = info.WareHouseId;
           info._WareHouseIdIsDirty = 0;
        }

       if (info._BillNOIsDirty == 1)
        {
           entity.BillNO = info.BillNO;
           info._BillNOIsDirty = 0;
        }

       if (info._FormDateIsDirty == 1)
        {
           entity.FormDate = info.FormDate;
           info._FormDateIsDirty = 0;
        }

       if (info._NeedCompanyIdIsDirty == 1)
        {
           entity.NeedCompanyId = info.NeedCompanyId;
           info._NeedCompanyIdIsDirty = 0;
        }

       if (info._NeedCompanyNameIsDirty == 1)
        {
           entity.NeedCompanyName = info.NeedCompanyName;
           info._NeedCompanyNameIsDirty = 0;
        }

       if (info._NeedDepartmentIdIsDirty == 1)
        {
           entity.NeedDepartmentId = info.NeedDepartmentId;
           info._NeedDepartmentIdIsDirty = 0;
        }

       if (info._NeedDepartmentNameIsDirty == 1)
        {
           entity.NeedDepartmentName = info.NeedDepartmentName;
           info._NeedDepartmentNameIsDirty = 0;
        }

       if (info._NeedStationIdIsDirty == 1)
        {
           entity.NeedStationId = info.NeedStationId;
           info._NeedStationIdIsDirty = 0;
        }

       if (info._NeedStationNameIsDirty == 1)
        {
           entity.NeedStationName = info.NeedStationName;
           info._NeedStationNameIsDirty = 0;
        }

       if (info._NeedStaffIdIsDirty == 1)
        {
           entity.NeedStaffId = info.NeedStaffId;
           info._NeedStaffIdIsDirty = 0;
        }

       if (info._NeedStaffNameIsDirty == 1)
        {
           entity.NeedStaffName = info.NeedStaffName;
           info._NeedStaffNameIsDirty = 0;
        }

       if (info._HandleStationIdIsDirty == 1)
        {
           entity.HandleStationId = info.HandleStationId;
           info._HandleStationIdIsDirty = 0;
        }

       if (info._HandleStationNameIsDirty == 1)
        {
           entity.HandleStationName = info.HandleStationName;
           info._HandleStationNameIsDirty = 0;
        }

       if (info._HandleStaffIdIsDirty == 1)
        {
           entity.HandleStaffId = info.HandleStaffId;
           info._HandleStaffIdIsDirty = 0;
        }

       if (info._HandleStaffNameIsDirty == 1)
        {
           entity.HandleStaffName = info.HandleStaffName;
           info._HandleStaffNameIsDirty = 0;
        }

       if (info._StatusIsDirty == 1)
        {
           entity.Status = info.Status;
           info._StatusIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void MaterialBillETD(MaterialBill entity, MaterialBillInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.BillType = entity.BillType;
       info._BillTypeIsDirty = 0;

       info.BillClassId = entity.BillClassId;
       info._BillClassIdIsDirty = 0;

       info.RefType = entity.RefType;
       info._RefTypeIsDirty = 0;

       info.BillClassName = entity.BillClassName;
       info._BillClassNameIsDirty = 0;

       info.RefId = entity.RefId;
       info._RefIdIsDirty = 0;

       info.RefNO = entity.RefNO;
       info._RefNOIsDirty = 0;

       info.WareHouseId = entity.WareHouseId;
       info._WareHouseIdIsDirty = 0;

       info.BillNO = entity.BillNO;
       info._BillNOIsDirty = 0;

       info.FormDate = entity.FormDate;
       info._FormDateIsDirty = 0;

       info.NeedCompanyId = entity.NeedCompanyId;
       info._NeedCompanyIdIsDirty = 0;

       info.NeedCompanyName = entity.NeedCompanyName;
       info._NeedCompanyNameIsDirty = 0;

       info.NeedDepartmentId = entity.NeedDepartmentId;
       info._NeedDepartmentIdIsDirty = 0;

       info.NeedDepartmentName = entity.NeedDepartmentName;
       info._NeedDepartmentNameIsDirty = 0;

       info.NeedStationId = entity.NeedStationId;
       info._NeedStationIdIsDirty = 0;

       info.NeedStationName = entity.NeedStationName;
       info._NeedStationNameIsDirty = 0;

       info.NeedStaffId = entity.NeedStaffId;
       info._NeedStaffIdIsDirty = 0;

       info.NeedStaffName = entity.NeedStaffName;
       info._NeedStaffNameIsDirty = 0;

       info.HandleStationId = entity.HandleStationId;
       info._HandleStationIdIsDirty = 0;

       info.HandleStationName = entity.HandleStationName;
       info._HandleStationNameIsDirty = 0;

       info.HandleStaffId = entity.HandleStaffId;
       info._HandleStaffIdIsDirty = 0;

       info.HandleStaffName = entity.HandleStaffName;
       info._HandleStaffNameIsDirty = 0;

       info.Status = entity.Status;
       info._StatusIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void MaterialBillItemDTE(MaterialBillItemInfo info, MaterialBillItem entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._MaterialBillIdIsDirty == 1)
        {
           entity.MaterialBillId = info.MaterialBillId;
           info._MaterialBillIdIsDirty = 0;
        }

       if (info._MaterialIdIsDirty == 1)
        {
           entity.MaterialId = info.MaterialId;
           info._MaterialIdIsDirty = 0;
        }

       if (info._MaterialNameIsDirty == 1)
        {
           entity.MaterialName = info.MaterialName;
           info._MaterialNameIsDirty = 0;
        }

       if (info._SpecialIsDirty == 1)
        {
           entity.Special = info.Special;
           info._SpecialIsDirty = 0;
        }

       if (info._RatioIsDirty == 1)
        {
           entity.Ratio = info.Ratio;
           info._RatioIsDirty = 0;
        }

       if (info._UnitIdIsDirty == 1)
        {
           entity.UnitId = info.UnitId;
           info._UnitIdIsDirty = 0;
        }

       if (info._UnitNameIsDirty == 1)
        {
           entity.UnitName = info.UnitName;
           info._UnitNameIsDirty = 0;
        }

       if (info._AmountIsDirty == 1)
        {
           entity.Amount = info.Amount;
           info._AmountIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void MaterialBillItemETD(MaterialBillItem entity, MaterialBillItemInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.MaterialBillId = entity.MaterialBillId;
       info._MaterialBillIdIsDirty = 0;

       info.MaterialId = entity.MaterialId;
       info._MaterialIdIsDirty = 0;

       info.MaterialName = entity.MaterialName;
       info._MaterialNameIsDirty = 0;

       info.Special = entity.Special;
       info._SpecialIsDirty = 0;

       info.Ratio = entity.Ratio;
       info._RatioIsDirty = 0;

       info.UnitId = entity.UnitId;
       info._UnitIdIsDirty = 0;

       info.UnitName = entity.UnitName;
       info._UnitNameIsDirty = 0;

       info.Amount = entity.Amount;
       info._AmountIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void MaterialCatalogDTE(MaterialCatalogInfo info, MaterialCatalog entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ParentIdIsDirty == 1)
        {
           entity.ParentId = info.ParentId;
           info._ParentIdIsDirty = 0;
        }

       if (info._MaterialCatalogCodeIsDirty == 1)
        {
           entity.MaterialCatalogCode = info.MaterialCatalogCode;
           info._MaterialCatalogCodeIsDirty = 0;
        }

       if (info._MaterialCatalogNameIsDirty == 1)
        {
           entity.MaterialCatalogName = info.MaterialCatalogName;
           info._MaterialCatalogNameIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void MaterialCatalogETD(MaterialCatalog entity, MaterialCatalogInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ParentId = entity.ParentId;
       info._ParentIdIsDirty = 0;

       info.MaterialCatalogCode = entity.MaterialCatalogCode;
       info._MaterialCatalogCodeIsDirty = 0;

       info.MaterialCatalogName = entity.MaterialCatalogName;
       info._MaterialCatalogNameIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void MaterialPurchaseDTE(MaterialPurchaseInfo info, MaterialPurchase entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._PurchaseNOIsDirty == 1)
        {
           entity.PurchaseNO = info.PurchaseNO;
           info._PurchaseNOIsDirty = 0;
        }

       if (info._FormDateIsDirty == 1)
        {
           entity.FormDate = info.FormDate;
           info._FormDateIsDirty = 0;
        }

       if (info._ReceiveDateIsDirty == 1)
        {
           entity.ReceiveDate = info.ReceiveDate;
           info._ReceiveDateIsDirty = 0;
        }

       if (info._SumPriceIsDirty == 1)
        {
           entity.SumPrice = info.SumPrice;
           info._SumPriceIsDirty = 0;
        }

       if (info._SupplyCompanyIdIsDirty == 1)
        {
           entity.SupplyCompanyId = info.SupplyCompanyId;
           info._SupplyCompanyIdIsDirty = 0;
        }

       if (info._SupplyCompanyNameIsDirty == 1)
        {
           entity.SupplyCompanyName = info.SupplyCompanyName;
           info._SupplyCompanyNameIsDirty = 0;
        }

       if (info._SupplyContactIsDirty == 1)
        {
           entity.SupplyContact = info.SupplyContact;
           info._SupplyContactIsDirty = 0;
        }

       if (info._SupplyMobileIsDirty == 1)
        {
           entity.SupplyMobile = info.SupplyMobile;
           info._SupplyMobileIsDirty = 0;
        }

       if (info._SupplyPhoneIsDirty == 1)
        {
           entity.SupplyPhone = info.SupplyPhone;
           info._SupplyPhoneIsDirty = 0;
        }

       if (info._SupplyFaxIsDirty == 1)
        {
           entity.SupplyFax = info.SupplyFax;
           info._SupplyFaxIsDirty = 0;
        }

       if (info._SupplyAddressIsDirty == 1)
        {
           entity.SupplyAddress = info.SupplyAddress;
           info._SupplyAddressIsDirty = 0;
        }

       if (info._HandleStationIdIsDirty == 1)
        {
           entity.HandleStationId = info.HandleStationId;
           info._HandleStationIdIsDirty = 0;
        }

       if (info._HandleStationNameIsDirty == 1)
        {
           entity.HandleStationName = info.HandleStationName;
           info._HandleStationNameIsDirty = 0;
        }

       if (info._HandleStaffIdIsDirty == 1)
        {
           entity.HandleStaffId = info.HandleStaffId;
           info._HandleStaffIdIsDirty = 0;
        }

       if (info._HandleStaffNameIsDirty == 1)
        {
           entity.HandleStaffName = info.HandleStaffName;
           info._HandleStaffNameIsDirty = 0;
        }

       if (info._StatusIsDirty == 1)
        {
           entity.Status = info.Status;
           info._StatusIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void MaterialPurchaseETD(MaterialPurchase entity, MaterialPurchaseInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.PurchaseNO = entity.PurchaseNO;
       info._PurchaseNOIsDirty = 0;

       info.FormDate = entity.FormDate;
       info._FormDateIsDirty = 0;

       info.ReceiveDate = entity.ReceiveDate;
       info._ReceiveDateIsDirty = 0;

       info.SumPrice = entity.SumPrice;
       info._SumPriceIsDirty = 0;

       info.SupplyCompanyId = entity.SupplyCompanyId;
       info._SupplyCompanyIdIsDirty = 0;

       info.SupplyCompanyName = entity.SupplyCompanyName;
       info._SupplyCompanyNameIsDirty = 0;

       info.SupplyContact = entity.SupplyContact;
       info._SupplyContactIsDirty = 0;

       info.SupplyMobile = entity.SupplyMobile;
       info._SupplyMobileIsDirty = 0;

       info.SupplyPhone = entity.SupplyPhone;
       info._SupplyPhoneIsDirty = 0;

       info.SupplyFax = entity.SupplyFax;
       info._SupplyFaxIsDirty = 0;

       info.SupplyAddress = entity.SupplyAddress;
       info._SupplyAddressIsDirty = 0;

       info.HandleStationId = entity.HandleStationId;
       info._HandleStationIdIsDirty = 0;

       info.HandleStationName = entity.HandleStationName;
       info._HandleStationNameIsDirty = 0;

       info.HandleStaffId = entity.HandleStaffId;
       info._HandleStaffIdIsDirty = 0;

       info.HandleStaffName = entity.HandleStaffName;
       info._HandleStaffNameIsDirty = 0;

       info.Status = entity.Status;
       info._StatusIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void MaterialPurchaseItemDTE(MaterialPurchaseItemInfo info, MaterialPurchaseItem entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._MaterialPurchaseIdIsDirty == 1)
        {
           entity.MaterialPurchaseId = info.MaterialPurchaseId;
           info._MaterialPurchaseIdIsDirty = 0;
        }

       if (info._MaterialIdIsDirty == 1)
        {
           entity.MaterialId = info.MaterialId;
           info._MaterialIdIsDirty = 0;
        }

       if (info._MaterialNameIsDirty == 1)
        {
           entity.MaterialName = info.MaterialName;
           info._MaterialNameIsDirty = 0;
        }

       if (info._SpecialIsDirty == 1)
        {
           entity.Special = info.Special;
           info._SpecialIsDirty = 0;
        }

       if (info._UnitIdIsDirty == 1)
        {
           entity.UnitId = info.UnitId;
           info._UnitIdIsDirty = 0;
        }

       if (info._UnitNameIsDirty == 1)
        {
           entity.UnitName = info.UnitName;
           info._UnitNameIsDirty = 0;
        }

       if (info._PriceIsDirty == 1)
        {
           entity.Price = info.Price;
           info._PriceIsDirty = 0;
        }

       if (info._AmountIsDirty == 1)
        {
           entity.Amount = info.Amount;
           info._AmountIsDirty = 0;
        }

       if (info._SumPriceIsDirty == 1)
        {
           entity.SumPrice = info.SumPrice;
           info._SumPriceIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void MaterialPurchaseItemETD(MaterialPurchaseItem entity, MaterialPurchaseItemInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.MaterialPurchaseId = entity.MaterialPurchaseId;
       info._MaterialPurchaseIdIsDirty = 0;

       info.MaterialId = entity.MaterialId;
       info._MaterialIdIsDirty = 0;

       info.MaterialName = entity.MaterialName;
       info._MaterialNameIsDirty = 0;

       info.Special = entity.Special;
       info._SpecialIsDirty = 0;

       info.UnitId = entity.UnitId;
       info._UnitIdIsDirty = 0;

       info.UnitName = entity.UnitName;
       info._UnitNameIsDirty = 0;

       info.Price = entity.Price;
       info._PriceIsDirty = 0;

       info.Amount = entity.Amount;
       info._AmountIsDirty = 0;

       info.SumPrice = entity.SumPrice;
       info._SumPriceIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void MaterialPurchasePlanDTE(MaterialPurchasePlanInfo info, MaterialPurchasePlan entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._RefIdIsDirty == 1)
        {
           entity.RefId = info.RefId;
           info._RefIdIsDirty = 0;
        }

       if (info._RefNOIsDirty == 1)
        {
           entity.RefNO = info.RefNO;
           info._RefNOIsDirty = 0;
        }

       if (info._BillNOIsDirty == 1)
        {
           entity.BillNO = info.BillNO;
           info._BillNOIsDirty = 0;
        }

       if (info._FormDateIsDirty == 1)
        {
           entity.FormDate = info.FormDate;
           info._FormDateIsDirty = 0;
        }

       if (info._NeedCompanyIdIsDirty == 1)
        {
           entity.NeedCompanyId = info.NeedCompanyId;
           info._NeedCompanyIdIsDirty = 0;
        }

       if (info._NeedCompanyNameIsDirty == 1)
        {
           entity.NeedCompanyName = info.NeedCompanyName;
           info._NeedCompanyNameIsDirty = 0;
        }

       if (info._NeedDepartmentIdIsDirty == 1)
        {
           entity.NeedDepartmentId = info.NeedDepartmentId;
           info._NeedDepartmentIdIsDirty = 0;
        }

       if (info._NeedDepartmentNameIsDirty == 1)
        {
           entity.NeedDepartmentName = info.NeedDepartmentName;
           info._NeedDepartmentNameIsDirty = 0;
        }

       if (info._NeedStationIdIsDirty == 1)
        {
           entity.NeedStationId = info.NeedStationId;
           info._NeedStationIdIsDirty = 0;
        }

       if (info._NeedStationNameIsDirty == 1)
        {
           entity.NeedStationName = info.NeedStationName;
           info._NeedStationNameIsDirty = 0;
        }

       if (info._NeedStaffIdIsDirty == 1)
        {
           entity.NeedStaffId = info.NeedStaffId;
           info._NeedStaffIdIsDirty = 0;
        }

       if (info._NeedStaffNameIsDirty == 1)
        {
           entity.NeedStaffName = info.NeedStaffName;
           info._NeedStaffNameIsDirty = 0;
        }

       if (info._HandleStationIdIsDirty == 1)
        {
           entity.HandleStationId = info.HandleStationId;
           info._HandleStationIdIsDirty = 0;
        }

       if (info._HandleStationNameIsDirty == 1)
        {
           entity.HandleStationName = info.HandleStationName;
           info._HandleStationNameIsDirty = 0;
        }

       if (info._HandleStaffIdIsDirty == 1)
        {
           entity.HandleStaffId = info.HandleStaffId;
           info._HandleStaffIdIsDirty = 0;
        }

       if (info._HandleStaffNameIsDirty == 1)
        {
           entity.HandleStaffName = info.HandleStaffName;
           info._HandleStaffNameIsDirty = 0;
        }

       if (info._StatusIsDirty == 1)
        {
           entity.Status = info.Status;
           info._StatusIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void MaterialPurchasePlanETD(MaterialPurchasePlan entity, MaterialPurchasePlanInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.RefId = entity.RefId;
       info._RefIdIsDirty = 0;

       info.RefNO = entity.RefNO;
       info._RefNOIsDirty = 0;

       info.BillNO = entity.BillNO;
       info._BillNOIsDirty = 0;

       info.FormDate = entity.FormDate;
       info._FormDateIsDirty = 0;

       info.NeedCompanyId = entity.NeedCompanyId;
       info._NeedCompanyIdIsDirty = 0;

       info.NeedCompanyName = entity.NeedCompanyName;
       info._NeedCompanyNameIsDirty = 0;

       info.NeedDepartmentId = entity.NeedDepartmentId;
       info._NeedDepartmentIdIsDirty = 0;

       info.NeedDepartmentName = entity.NeedDepartmentName;
       info._NeedDepartmentNameIsDirty = 0;

       info.NeedStationId = entity.NeedStationId;
       info._NeedStationIdIsDirty = 0;

       info.NeedStationName = entity.NeedStationName;
       info._NeedStationNameIsDirty = 0;

       info.NeedStaffId = entity.NeedStaffId;
       info._NeedStaffIdIsDirty = 0;

       info.NeedStaffName = entity.NeedStaffName;
       info._NeedStaffNameIsDirty = 0;

       info.HandleStationId = entity.HandleStationId;
       info._HandleStationIdIsDirty = 0;

       info.HandleStationName = entity.HandleStationName;
       info._HandleStationNameIsDirty = 0;

       info.HandleStaffId = entity.HandleStaffId;
       info._HandleStaffIdIsDirty = 0;

       info.HandleStaffName = entity.HandleStaffName;
       info._HandleStaffNameIsDirty = 0;

       info.Status = entity.Status;
       info._StatusIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void MaterialPurchasePlanItemDTE(MaterialPurchasePlanItemInfo info, MaterialPurchasePlanItem entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._MaterialPurchasePlanIdIsDirty == 1)
        {
           entity.MaterialPurchasePlanId = info.MaterialPurchasePlanId;
           info._MaterialPurchasePlanIdIsDirty = 0;
        }

       if (info._MaterialIdIsDirty == 1)
        {
           entity.MaterialId = info.MaterialId;
           info._MaterialIdIsDirty = 0;
        }

       if (info._MaterialNameIsDirty == 1)
        {
           entity.MaterialName = info.MaterialName;
           info._MaterialNameIsDirty = 0;
        }

       if (info._SpecialIsDirty == 1)
        {
           entity.Special = info.Special;
           info._SpecialIsDirty = 0;
        }

       if (info._UnitIdIsDirty == 1)
        {
           entity.UnitId = info.UnitId;
           info._UnitIdIsDirty = 0;
        }

       if (info._UnitNameIsDirty == 1)
        {
           entity.UnitName = info.UnitName;
           info._UnitNameIsDirty = 0;
        }

       if (info._AmountIsDirty == 1)
        {
           entity.Amount = info.Amount;
           info._AmountIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void MaterialPurchasePlanItemETD(MaterialPurchasePlanItem entity, MaterialPurchasePlanItemInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.MaterialPurchasePlanId = entity.MaterialPurchasePlanId;
       info._MaterialPurchasePlanIdIsDirty = 0;

       info.MaterialId = entity.MaterialId;
       info._MaterialIdIsDirty = 0;

       info.MaterialName = entity.MaterialName;
       info._MaterialNameIsDirty = 0;

       info.Special = entity.Special;
       info._SpecialIsDirty = 0;

       info.UnitId = entity.UnitId;
       info._UnitIdIsDirty = 0;

       info.UnitName = entity.UnitName;
       info._UnitNameIsDirty = 0;

       info.Amount = entity.Amount;
       info._AmountIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void MaterialWareStockDTE(MaterialWareStockInfo info, MaterialWareStock entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._MaterialIdIsDirty == 1)
        {
           entity.MaterialId = info.MaterialId;
           info._MaterialIdIsDirty = 0;
        }

       if (info._WareHouseIdIsDirty == 1)
        {
           entity.WareHouseId = info.WareHouseId;
           info._WareHouseIdIsDirty = 0;
        }

       if (info._MinStockIsDirty == 1)
        {
           entity.MinStock = info.MinStock;
           info._MinStockIsDirty = 0;
        }

       if (info._StockIsDirty == 1)
        {
           entity.Stock = info.Stock;
           info._StockIsDirty = 0;
        }

       if (info._MaxStockIsDirty == 1)
        {
           entity.MaxStock = info.MaxStock;
           info._MaxStockIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void MaterialWareStockETD(MaterialWareStock entity, MaterialWareStockInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.MaterialId = entity.MaterialId;
       info._MaterialIdIsDirty = 0;

       info.WareHouseId = entity.WareHouseId;
       info._WareHouseIdIsDirty = 0;

       info.MinStock = entity.MinStock;
       info._MinStockIsDirty = 0;

       info.Stock = entity.Stock;
       info._StockIsDirty = 0;

       info.MaxStock = entity.MaxStock;
       info._MaxStockIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void ProductDTE(ProductInfo info, Product entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ProductCatalogIdIsDirty == 1)
        {
           entity.ProductCatalogId = info.ProductCatalogId;
           info._ProductCatalogIdIsDirty = 0;
        }

       if (info._ProductCodeIsDirty == 1)
        {
           entity.ProductCode = info.ProductCode;
           info._ProductCodeIsDirty = 0;
        }

       if (info._ProductNameIsDirty == 1)
        {
           entity.ProductName = info.ProductName;
           info._ProductNameIsDirty = 0;
        }

       if (info._SearchKeyIsDirty == 1)
        {
           entity.SearchKey = info.SearchKey;
           info._SearchKeyIsDirty = 0;
        }

       if (info._UnitIdIsDirty == 1)
        {
           entity.UnitId = info.UnitId;
           info._UnitIdIsDirty = 0;
        }

       if (info._SpecialIsDirty == 1)
        {
           entity.Special = info.Special;
           info._SpecialIsDirty = 0;
        }

       if (info._TextureIsDirty == 1)
        {
           entity.Texture = info.Texture;
           info._TextureIsDirty = 0;
        }

       if (info._SizeIsDirty == 1)
        {
           entity.Size = info.Size;
           info._SizeIsDirty = 0;
        }

       if (info._ColorIsDirty == 1)
        {
           entity.Color = info.Color;
           info._ColorIsDirty = 0;
        }

       if (info._ImageUrlIsDirty == 1)
        {
           entity.ImageUrl = info.ImageUrl;
           info._ImageUrlIsDirty = 0;
        }

       if (info._MinStockIsDirty == 1)
        {
           entity.MinStock = info.MinStock;
           info._MinStockIsDirty = 0;
        }

       if (info._StockIsDirty == 1)
        {
           entity.Stock = info.Stock;
           info._StockIsDirty = 0;
        }

       if (info._MaxStockIsDirty == 1)
        {
           entity.MaxStock = info.MaxStock;
           info._MaxStockIsDirty = 0;
        }

       if (info._IntroIsDirty == 1)
        {
           entity.Intro = info.Intro;
           info._IntroIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void ProductETD(Product entity, ProductInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ProductCatalogId = entity.ProductCatalogId;
       info._ProductCatalogIdIsDirty = 0;

       info.ProductCode = entity.ProductCode;
       info._ProductCodeIsDirty = 0;

       info.ProductName = entity.ProductName;
       info._ProductNameIsDirty = 0;

       info.SearchKey = entity.SearchKey;
       info._SearchKeyIsDirty = 0;

       info.UnitId = entity.UnitId;
       info._UnitIdIsDirty = 0;

       info.Special = entity.Special;
       info._SpecialIsDirty = 0;

       info.Texture = entity.Texture;
       info._TextureIsDirty = 0;

       info.Size = entity.Size;
       info._SizeIsDirty = 0;

       info.Color = entity.Color;
       info._ColorIsDirty = 0;

       info.ImageUrl = entity.ImageUrl;
       info._ImageUrlIsDirty = 0;

       info.MinStock = entity.MinStock;
       info._MinStockIsDirty = 0;

       info.Stock = entity.Stock;
       info._StockIsDirty = 0;

       info.MaxStock = entity.MaxStock;
       info._MaxStockIsDirty = 0;

       info.Intro = entity.Intro;
       info._IntroIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void ProductBillDTE(ProductBillInfo info, ProductBill entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._BillTypeIsDirty == 1)
        {
           entity.BillType = info.BillType;
           info._BillTypeIsDirty = 0;
        }

       if (info._BillClassIdIsDirty == 1)
        {
           entity.BillClassId = info.BillClassId;
           info._BillClassIdIsDirty = 0;
        }

       if (info._BillClassNameIsDirty == 1)
        {
           entity.BillClassName = info.BillClassName;
           info._BillClassNameIsDirty = 0;
        }

       if (info._RefIdIsDirty == 1)
        {
           entity.RefId = info.RefId;
           info._RefIdIsDirty = 0;
        }

       if (info._RefTypeIsDirty == 1)
        {
           entity.RefType = info.RefType;
           info._RefTypeIsDirty = 0;
        }

       if (info._RefNOIsDirty == 1)
        {
           entity.RefNO = info.RefNO;
           info._RefNOIsDirty = 0;
        }

       if (info._WareHouseIdIsDirty == 1)
        {
           entity.WareHouseId = info.WareHouseId;
           info._WareHouseIdIsDirty = 0;
        }

       if (info._BillNOIsDirty == 1)
        {
           entity.BillNO = info.BillNO;
           info._BillNOIsDirty = 0;
        }

       if (info._FormDateIsDirty == 1)
        {
           entity.FormDate = info.FormDate;
           info._FormDateIsDirty = 0;
        }

       if (info._NeedCompanyIdIsDirty == 1)
        {
           entity.NeedCompanyId = info.NeedCompanyId;
           info._NeedCompanyIdIsDirty = 0;
        }

       if (info._NeedCompanyNameIsDirty == 1)
        {
           entity.NeedCompanyName = info.NeedCompanyName;
           info._NeedCompanyNameIsDirty = 0;
        }

       if (info._NeedDepartmentIdIsDirty == 1)
        {
           entity.NeedDepartmentId = info.NeedDepartmentId;
           info._NeedDepartmentIdIsDirty = 0;
        }

       if (info._NeedDepartmentNameIsDirty == 1)
        {
           entity.NeedDepartmentName = info.NeedDepartmentName;
           info._NeedDepartmentNameIsDirty = 0;
        }

       if (info._NeedStationIdIsDirty == 1)
        {
           entity.NeedStationId = info.NeedStationId;
           info._NeedStationIdIsDirty = 0;
        }

       if (info._NeedStationNameIsDirty == 1)
        {
           entity.NeedStationName = info.NeedStationName;
           info._NeedStationNameIsDirty = 0;
        }

       if (info._NeedStaffIdIsDirty == 1)
        {
           entity.NeedStaffId = info.NeedStaffId;
           info._NeedStaffIdIsDirty = 0;
        }

       if (info._NeedStaffNameIsDirty == 1)
        {
           entity.NeedStaffName = info.NeedStaffName;
           info._NeedStaffNameIsDirty = 0;
        }

       if (info._HandleStationIdIsDirty == 1)
        {
           entity.HandleStationId = info.HandleStationId;
           info._HandleStationIdIsDirty = 0;
        }

       if (info._HandleStationNameIsDirty == 1)
        {
           entity.HandleStationName = info.HandleStationName;
           info._HandleStationNameIsDirty = 0;
        }

       if (info._HandleStaffIdIsDirty == 1)
        {
           entity.HandleStaffId = info.HandleStaffId;
           info._HandleStaffIdIsDirty = 0;
        }

       if (info._HandleStaffNameIsDirty == 1)
        {
           entity.HandleStaffName = info.HandleStaffName;
           info._HandleStaffNameIsDirty = 0;
        }

       if (info._StatusIsDirty == 1)
        {
           entity.Status = info.Status;
           info._StatusIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void ProductBillETD(ProductBill entity, ProductBillInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.BillType = entity.BillType;
       info._BillTypeIsDirty = 0;

       info.BillClassId = entity.BillClassId;
       info._BillClassIdIsDirty = 0;

       info.BillClassName = entity.BillClassName;
       info._BillClassNameIsDirty = 0;

       info.RefId = entity.RefId;
       info._RefIdIsDirty = 0;

       info.RefType = entity.RefType;
       info._RefTypeIsDirty = 0;

       info.RefNO = entity.RefNO;
       info._RefNOIsDirty = 0;

       info.WareHouseId = entity.WareHouseId;
       info._WareHouseIdIsDirty = 0;

       info.BillNO = entity.BillNO;
       info._BillNOIsDirty = 0;

       info.FormDate = entity.FormDate;
       info._FormDateIsDirty = 0;

       info.NeedCompanyId = entity.NeedCompanyId;
       info._NeedCompanyIdIsDirty = 0;

       info.NeedCompanyName = entity.NeedCompanyName;
       info._NeedCompanyNameIsDirty = 0;

       info.NeedDepartmentId = entity.NeedDepartmentId;
       info._NeedDepartmentIdIsDirty = 0;

       info.NeedDepartmentName = entity.NeedDepartmentName;
       info._NeedDepartmentNameIsDirty = 0;

       info.NeedStationId = entity.NeedStationId;
       info._NeedStationIdIsDirty = 0;

       info.NeedStationName = entity.NeedStationName;
       info._NeedStationNameIsDirty = 0;

       info.NeedStaffId = entity.NeedStaffId;
       info._NeedStaffIdIsDirty = 0;

       info.NeedStaffName = entity.NeedStaffName;
       info._NeedStaffNameIsDirty = 0;

       info.HandleStationId = entity.HandleStationId;
       info._HandleStationIdIsDirty = 0;

       info.HandleStationName = entity.HandleStationName;
       info._HandleStationNameIsDirty = 0;

       info.HandleStaffId = entity.HandleStaffId;
       info._HandleStaffIdIsDirty = 0;

       info.HandleStaffName = entity.HandleStaffName;
       info._HandleStaffNameIsDirty = 0;

       info.Status = entity.Status;
       info._StatusIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void ProductBillItemDTE(ProductBillItemInfo info, ProductBillItem entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ProductBillIdIsDirty == 1)
        {
           entity.ProductBillId = info.ProductBillId;
           info._ProductBillIdIsDirty = 0;
        }

       if (info._ProductIdIsDirty == 1)
        {
           entity.ProductId = info.ProductId;
           info._ProductIdIsDirty = 0;
        }

       if (info._ProductNameIsDirty == 1)
        {
           entity.ProductName = info.ProductName;
           info._ProductNameIsDirty = 0;
        }

       if (info._SpecialIsDirty == 1)
        {
           entity.Special = info.Special;
           info._SpecialIsDirty = 0;
        }

       if (info._RatioIsDirty == 1)
        {
           entity.Ratio = info.Ratio;
           info._RatioIsDirty = 0;
        }

       if (info._UnitIdIsDirty == 1)
        {
           entity.UnitId = info.UnitId;
           info._UnitIdIsDirty = 0;
        }

       if (info._UnitNameIsDirty == 1)
        {
           entity.UnitName = info.UnitName;
           info._UnitNameIsDirty = 0;
        }

       if (info._AmountIsDirty == 1)
        {
           entity.Amount = info.Amount;
           info._AmountIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void ProductBillItemETD(ProductBillItem entity, ProductBillItemInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ProductBillId = entity.ProductBillId;
       info._ProductBillIdIsDirty = 0;

       info.ProductId = entity.ProductId;
       info._ProductIdIsDirty = 0;

       info.ProductName = entity.ProductName;
       info._ProductNameIsDirty = 0;

       info.Special = entity.Special;
       info._SpecialIsDirty = 0;

       info.Ratio = entity.Ratio;
       info._RatioIsDirty = 0;

       info.UnitId = entity.UnitId;
       info._UnitIdIsDirty = 0;

       info.UnitName = entity.UnitName;
       info._UnitNameIsDirty = 0;

       info.Amount = entity.Amount;
       info._AmountIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void ProductCatalogDTE(ProductCatalogInfo info, ProductCatalog entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ParentIdIsDirty == 1)
        {
           entity.ParentId = info.ParentId;
           info._ParentIdIsDirty = 0;
        }

       if (info._ProductCatalogCodeIsDirty == 1)
        {
           entity.ProductCatalogCode = info.ProductCatalogCode;
           info._ProductCatalogCodeIsDirty = 0;
        }

       if (info._ProductCatalogNameIsDirty == 1)
        {
           entity.ProductCatalogName = info.ProductCatalogName;
           info._ProductCatalogNameIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void ProductCatalogETD(ProductCatalog entity, ProductCatalogInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ParentId = entity.ParentId;
       info._ParentIdIsDirty = 0;

       info.ProductCatalogCode = entity.ProductCatalogCode;
       info._ProductCatalogCodeIsDirty = 0;

       info.ProductCatalogName = entity.ProductCatalogName;
       info._ProductCatalogNameIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void ProductOrderDTE(ProductOrderInfo info, ProductOrder entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._OrderNOIsDirty == 1)
        {
           entity.OrderNO = info.OrderNO;
           info._OrderNOIsDirty = 0;
        }

       if (info._SourceConstractNoIsDirty == 1)
        {
           entity.SourceConstractNo = info.SourceConstractNo;
           info._SourceConstractNoIsDirty = 0;
        }

       if (info._ConstractFormDateIsDirty == 1)
        {
           entity.ConstractFormDate = info.ConstractFormDate;
           info._ConstractFormDateIsDirty = 0;
        }

       if (info._FormDateIsDirty == 1)
        {
           entity.FormDate = info.FormDate;
           info._FormDateIsDirty = 0;
        }

       if (info._DeliveryDateIsDirty == 1)
        {
           entity.DeliveryDate = info.DeliveryDate;
           info._DeliveryDateIsDirty = 0;
        }

       if (info._SumPriceIsDirty == 1)
        {
           entity.SumPrice = info.SumPrice;
           info._SumPriceIsDirty = 0;
        }

       if (info._ClientCompanyIdIsDirty == 1)
        {
           entity.ClientCompanyId = info.ClientCompanyId;
           info._ClientCompanyIdIsDirty = 0;
        }

       if (info._ClientCompanyNameIsDirty == 1)
        {
           entity.ClientCompanyName = info.ClientCompanyName;
           info._ClientCompanyNameIsDirty = 0;
        }

       if (info._ClientContactIsDirty == 1)
        {
           entity.ClientContact = info.ClientContact;
           info._ClientContactIsDirty = 0;
        }

       if (info._ClientMobileIsDirty == 1)
        {
           entity.ClientMobile = info.ClientMobile;
           info._ClientMobileIsDirty = 0;
        }

       if (info._ClientPhoneIsDirty == 1)
        {
           entity.ClientPhone = info.ClientPhone;
           info._ClientPhoneIsDirty = 0;
        }

       if (info._ClientFaxIsDirty == 1)
        {
           entity.ClientFax = info.ClientFax;
           info._ClientFaxIsDirty = 0;
        }

       if (info._ClientAddressIsDirty == 1)
        {
           entity.ClientAddress = info.ClientAddress;
           info._ClientAddressIsDirty = 0;
        }

       if (info._HandleStationIdIsDirty == 1)
        {
           entity.HandleStationId = info.HandleStationId;
           info._HandleStationIdIsDirty = 0;
        }

       if (info._HandleStationNameIsDirty == 1)
        {
           entity.HandleStationName = info.HandleStationName;
           info._HandleStationNameIsDirty = 0;
        }

       if (info._HandleStaffIdIsDirty == 1)
        {
           entity.HandleStaffId = info.HandleStaffId;
           info._HandleStaffIdIsDirty = 0;
        }

       if (info._HandleStaffNameIsDirty == 1)
        {
           entity.HandleStaffName = info.HandleStaffName;
           info._HandleStaffNameIsDirty = 0;
        }

       if (info._StatusIsDirty == 1)
        {
           entity.Status = info.Status;
           info._StatusIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void ProductOrderETD(ProductOrder entity, ProductOrderInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.OrderNO = entity.OrderNO;
       info._OrderNOIsDirty = 0;

       info.SourceConstractNo = entity.SourceConstractNo;
       info._SourceConstractNoIsDirty = 0;

       info.ConstractFormDate = entity.ConstractFormDate;
       info._ConstractFormDateIsDirty = 0;

       info.FormDate = entity.FormDate;
       info._FormDateIsDirty = 0;

       info.DeliveryDate = entity.DeliveryDate;
       info._DeliveryDateIsDirty = 0;

       info.SumPrice = entity.SumPrice;
       info._SumPriceIsDirty = 0;

       info.ClientCompanyId = entity.ClientCompanyId;
       info._ClientCompanyIdIsDirty = 0;

       info.ClientCompanyName = entity.ClientCompanyName;
       info._ClientCompanyNameIsDirty = 0;

       info.ClientContact = entity.ClientContact;
       info._ClientContactIsDirty = 0;

       info.ClientMobile = entity.ClientMobile;
       info._ClientMobileIsDirty = 0;

       info.ClientPhone = entity.ClientPhone;
       info._ClientPhoneIsDirty = 0;

       info.ClientFax = entity.ClientFax;
       info._ClientFaxIsDirty = 0;

       info.ClientAddress = entity.ClientAddress;
       info._ClientAddressIsDirty = 0;

       info.HandleStationId = entity.HandleStationId;
       info._HandleStationIdIsDirty = 0;

       info.HandleStationName = entity.HandleStationName;
       info._HandleStationNameIsDirty = 0;

       info.HandleStaffId = entity.HandleStaffId;
       info._HandleStaffIdIsDirty = 0;

       info.HandleStaffName = entity.HandleStaffName;
       info._HandleStaffNameIsDirty = 0;

       info.Status = entity.Status;
       info._StatusIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void ProductOrderItemDTE(ProductOrderItemInfo info, ProductOrderItem entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ProductOrderIdIsDirty == 1)
        {
           entity.ProductOrderId = info.ProductOrderId;
           info._ProductOrderIdIsDirty = 0;
        }

       if (info._ProductIdIsDirty == 1)
        {
           entity.ProductId = info.ProductId;
           info._ProductIdIsDirty = 0;
        }

       if (info._ProductNameIsDirty == 1)
        {
           entity.ProductName = info.ProductName;
           info._ProductNameIsDirty = 0;
        }

       if (info._SpecialIsDirty == 1)
        {
           entity.Special = info.Special;
           info._SpecialIsDirty = 0;
        }

       if (info._UnitIdIsDirty == 1)
        {
           entity.UnitId = info.UnitId;
           info._UnitIdIsDirty = 0;
        }

       if (info._UnitNameIsDirty == 1)
        {
           entity.UnitName = info.UnitName;
           info._UnitNameIsDirty = 0;
        }

       if (info._AmountIsDirty == 1)
        {
           entity.Amount = info.Amount;
           info._AmountIsDirty = 0;
        }

       if (info._PriceIsDirty == 1)
        {
           entity.Price = info.Price;
           info._PriceIsDirty = 0;
        }

       if (info._SumPriceIsDirty == 1)
        {
           entity.SumPrice = info.SumPrice;
           info._SumPriceIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void ProductOrderItemETD(ProductOrderItem entity, ProductOrderItemInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ProductOrderId = entity.ProductOrderId;
       info._ProductOrderIdIsDirty = 0;

       info.ProductId = entity.ProductId;
       info._ProductIdIsDirty = 0;

       info.ProductName = entity.ProductName;
       info._ProductNameIsDirty = 0;

       info.Special = entity.Special;
       info._SpecialIsDirty = 0;

       info.UnitId = entity.UnitId;
       info._UnitIdIsDirty = 0;

       info.UnitName = entity.UnitName;
       info._UnitNameIsDirty = 0;

       info.Amount = entity.Amount;
       info._AmountIsDirty = 0;

       info.Price = entity.Price;
       info._PriceIsDirty = 0;

       info.SumPrice = entity.SumPrice;
       info._SumPriceIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void ProductWareStockDTE(ProductWareStockInfo info, ProductWareStock entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ProductIdIsDirty == 1)
        {
           entity.ProductId = info.ProductId;
           info._ProductIdIsDirty = 0;
        }

       if (info._WareHouseIdIsDirty == 1)
        {
           entity.WareHouseId = info.WareHouseId;
           info._WareHouseIdIsDirty = 0;
        }

       if (info._MinStockIsDirty == 1)
        {
           entity.MinStock = info.MinStock;
           info._MinStockIsDirty = 0;
        }

       if (info._StockIsDirty == 1)
        {
           entity.Stock = info.Stock;
           info._StockIsDirty = 0;
        }

       if (info._MaxStockIsDirty == 1)
        {
           entity.MaxStock = info.MaxStock;
           info._MaxStockIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void ProductWareStockETD(ProductWareStock entity, ProductWareStockInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ProductId = entity.ProductId;
       info._ProductIdIsDirty = 0;

       info.WareHouseId = entity.WareHouseId;
       info._WareHouseIdIsDirty = 0;

       info.MinStock = entity.MinStock;
       info._MinStockIsDirty = 0;

       info.Stock = entity.Stock;
       info._StockIsDirty = 0;

       info.MaxStock = entity.MaxStock;
       info._MaxStockIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void UnitDTE(UnitInfo info, Unit entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._UnitCodeIsDirty == 1)
        {
           entity.UnitCode = info.UnitCode;
           info._UnitCodeIsDirty = 0;
        }

       if (info._UnitNameIsDirty == 1)
        {
           entity.UnitName = info.UnitName;
           info._UnitNameIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void UnitETD(Unit entity, UnitInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.UnitCode = entity.UnitCode;
       info._UnitCodeIsDirty = 0;

       info.UnitName = entity.UnitName;
       info._UnitNameIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }

    public static void WareHouseDTE(WareHouseInfo info, WareHouse entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._WareHouseCodeIsDirty == 1)
        {
           entity.WareHouseCode = info.WareHouseCode;
           info._WareHouseCodeIsDirty = 0;
        }

       if (info._WareHouseNameIsDirty == 1)
        {
           entity.WareHouseName = info.WareHouseName;
           info._WareHouseNameIsDirty = 0;
        }

       if (info._RegionIdIsDirty == 1)
        {
           entity.RegionId = info.RegionId;
           info._RegionIdIsDirty = 0;
        }

       if (info._AddressIsDirty == 1)
        {
           entity.Address = info.Address;
           info._AddressIsDirty = 0;
        }

       if (info._NoteIsDirty == 1)
        {
           entity.Note = info.Note;
           info._NoteIsDirty = 0;
        }

       if (info._SYS_OrderSeqIsDirty == 1)
        {
           entity.SYS_OrderSeq = info.SYS_OrderSeq;
           info._SYS_OrderSeqIsDirty = 0;
        }

       if (info._SYS_IsValidIsDirty == 1)
        {
           entity.SYS_IsValid = info.SYS_IsValid;
           info._SYS_IsValidIsDirty = 0;
        }

       if (info._SYS_IsDeletedIsDirty == 1)
        {
           entity.SYS_IsDeleted = info.SYS_IsDeleted;
           info._SYS_IsDeletedIsDirty = 0;
        }

       if (info._SYS_RemarkIsDirty == 1)
        {
           entity.SYS_Remark = info.SYS_Remark;
           info._SYS_RemarkIsDirty = 0;
        }

       if (info._SYS_StaffIdIsDirty == 1)
        {
           entity.SYS_StaffId = info.SYS_StaffId;
           info._SYS_StaffIdIsDirty = 0;
        }

       if (info._SYS_StationIdIsDirty == 1)
        {
           entity.SYS_StationId = info.SYS_StationId;
           info._SYS_StationIdIsDirty = 0;
        }

       if (info._SYS_DepartmentIdIsDirty == 1)
        {
           entity.SYS_DepartmentId = info.SYS_DepartmentId;
           info._SYS_DepartmentIdIsDirty = 0;
        }

       if (info._SYS_CompanyIdIsDirty == 1)
        {
           entity.SYS_CompanyId = info.SYS_CompanyId;
           info._SYS_CompanyIdIsDirty = 0;
        }

       if (info._SYS_AppIdIsDirty == 1)
        {
           entity.SYS_AppId = info.SYS_AppId;
           info._SYS_AppIdIsDirty = 0;
        }

       if (info._SYS_CreateTimeIsDirty == 1)
        {
           entity.SYS_CreateTime = info.SYS_CreateTime;
           info._SYS_CreateTimeIsDirty = 0;
        }

       if (info._SYS_ModifyTimeIsDirty == 1)
        {
           entity.SYS_ModifyTime = info.SYS_ModifyTime;
           info._SYS_ModifyTimeIsDirty = 0;
        }

       if (info._SYS_DeleteTimeIsDirty == 1)
        {
           entity.SYS_DeleteTime = info.SYS_DeleteTime;
           info._SYS_DeleteTimeIsDirty = 0;
        }

    }

    public static void WareHouseETD(WareHouse entity, WareHouseInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.WareHouseCode = entity.WareHouseCode;
       info._WareHouseCodeIsDirty = 0;

       info.WareHouseName = entity.WareHouseName;
       info._WareHouseNameIsDirty = 0;

       info.RegionId = entity.RegionId;
       info._RegionIdIsDirty = 0;

       info.Address = entity.Address;
       info._AddressIsDirty = 0;

       info.Note = entity.Note;
       info._NoteIsDirty = 0;

       info.SYS_OrderSeq = entity.SYS_OrderSeq;
       info._SYS_OrderSeqIsDirty = 0;

       info.SYS_IsValid = entity.SYS_IsValid;
       info._SYS_IsValidIsDirty = 0;

       info.SYS_IsDeleted = entity.SYS_IsDeleted;
       info._SYS_IsDeletedIsDirty = 0;

       info.SYS_Remark = entity.SYS_Remark;
       info._SYS_RemarkIsDirty = 0;

       info.SYS_StaffId = entity.SYS_StaffId;
       info._SYS_StaffIdIsDirty = 0;

       info.SYS_StationId = entity.SYS_StationId;
       info._SYS_StationIdIsDirty = 0;

       info.SYS_DepartmentId = entity.SYS_DepartmentId;
       info._SYS_DepartmentIdIsDirty = 0;

       info.SYS_CompanyId = entity.SYS_CompanyId;
       info._SYS_CompanyIdIsDirty = 0;

       info.SYS_AppId = entity.SYS_AppId;
       info._SYS_AppIdIsDirty = 0;

       info.SYS_CreateTime = entity.SYS_CreateTime;
       info._SYS_CreateTimeIsDirty = 0;

       info.SYS_ModifyTime = entity.SYS_ModifyTime;
       info._SYS_ModifyTimeIsDirty = 0;

       info.SYS_DeleteTime = entity.SYS_DeleteTime;
       info._SYS_DeleteTimeIsDirty = 0;

    }



  }

}

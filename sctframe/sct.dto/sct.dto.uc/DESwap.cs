using sct.ent.uc;


namespace sct.dto.uc
{

  public class DESwap
  {

    public static void AppDTE(AppInfo info, App entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._AppCodeIsDirty == 1)
        {
           entity.AppCode = info.AppCode;
           info._AppCodeIsDirty = 0;
        }

       if (info._AppNameIsDirty == 1)
        {
           entity.AppName = info.AppName;
           info._AppNameIsDirty = 0;
        }

       if (info._PublicKeyIsDirty == 1)
        {
           entity.PublicKey = info.PublicKey;
           info._PublicKeyIsDirty = 0;
        }

       if (info._PrivateKeyIsDirty == 1)
        {
           entity.PrivateKey = info.PrivateKey;
           info._PrivateKeyIsDirty = 0;
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

    public static void AppETD(App entity, AppInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.AppCode = entity.AppCode;
       info._AppCodeIsDirty = 0;

       info.AppName = entity.AppName;
       info._AppNameIsDirty = 0;

       info.PublicKey = entity.PublicKey;
       info._PublicKeyIsDirty = 0;

       info.PrivateKey = entity.PrivateKey;
       info._PrivateKeyIsDirty = 0;

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

    public static void ClientTypeDTE(ClientTypeInfo info, ClientType entity)
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

       if (info._ClientTypeCodeIsDirty == 1)
        {
           entity.ClientTypeCode = info.ClientTypeCode;
           info._ClientTypeCodeIsDirty = 0;
        }

       if (info._ClientTypeNameIsDirty == 1)
        {
           entity.ClientTypeName = info.ClientTypeName;
           info._ClientTypeNameIsDirty = 0;
        }

       if (info._TreeNodeIsDirty == 1)
        {
           entity.TreeNode = info.TreeNode;
           info._TreeNodeIsDirty = 0;
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

    public static void ClientTypeETD(ClientType entity, ClientTypeInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ParentId = entity.ParentId;
       info._ParentIdIsDirty = 0;

       info.ClientTypeCode = entity.ClientTypeCode;
       info._ClientTypeCodeIsDirty = 0;

       info.ClientTypeName = entity.ClientTypeName;
       info._ClientTypeNameIsDirty = 0;

       info.TreeNode = entity.TreeNode;
       info._TreeNodeIsDirty = 0;

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

    public static void CompanyDTE(CompanyInfo info, Company entity)
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

       if (info._CompanyCodeIsDirty == 1)
        {
           entity.CompanyCode = info.CompanyCode;
           info._CompanyCodeIsDirty = 0;
        }

       if (info._CompanyNameIsDirty == 1)
        {
           entity.CompanyName = info.CompanyName;
           info._CompanyNameIsDirty = 0;
        }

       if (info._CompanyAbbreviationIsDirty == 1)
        {
           entity.CompanyAbbreviation = info.CompanyAbbreviation;
           info._CompanyAbbreviationIsDirty = 0;
        }

       if (info._CodeCertificateIsDirty == 1)
        {
           entity.CodeCertificate = info.CodeCertificate;
           info._CodeCertificateIsDirty = 0;
        }

       if (info._BusinessCertiticateIsDirty == 1)
        {
           entity.BusinessCertiticate = info.BusinessCertiticate;
           info._BusinessCertiticateIsDirty = 0;
        }

       if (info._RegDateIsDirty == 1)
        {
           entity.RegDate = info.RegDate;
           info._RegDateIsDirty = 0;
        }

       if (info._RegMoneyIsDirty == 1)
        {
           entity.RegMoney = info.RegMoney;
           info._RegMoneyIsDirty = 0;
        }

       if (info._PhoneIsDirty == 1)
        {
           entity.Phone = info.Phone;
           info._PhoneIsDirty = 0;
        }

       if (info._FaxIsDirty == 1)
        {
           entity.Fax = info.Fax;
           info._FaxIsDirty = 0;
        }

       if (info._WebSiteIsDirty == 1)
        {
           entity.WebSite = info.WebSite;
           info._WebSiteIsDirty = 0;
        }

       if (info._RegionIdIsDirty == 1)
        {
           entity.RegionId = info.RegionId;
           info._RegionIdIsDirty = 0;
        }

       if (info._DetailAddressIsDirty == 1)
        {
           entity.DetailAddress = info.DetailAddress;
           info._DetailAddressIsDirty = 0;
        }

       if (info._IntroIsDirty == 1)
        {
           entity.Intro = info.Intro;
           info._IntroIsDirty = 0;
        }

       if (info._IsOwnerIsDirty == 1)
        {
           entity.IsOwner = info.IsOwner;
           info._IsOwnerIsDirty = 0;
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

    public static void CompanyETD(Company entity, CompanyInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ParentId = entity.ParentId;
       info._ParentIdIsDirty = 0;

       info.CompanyCode = entity.CompanyCode;
       info._CompanyCodeIsDirty = 0;

       info.CompanyName = entity.CompanyName;
       info._CompanyNameIsDirty = 0;

       info.CompanyAbbreviation = entity.CompanyAbbreviation;
       info._CompanyAbbreviationIsDirty = 0;

       info.CodeCertificate = entity.CodeCertificate;
       info._CodeCertificateIsDirty = 0;

       info.BusinessCertiticate = entity.BusinessCertiticate;
       info._BusinessCertiticateIsDirty = 0;

       info.RegDate = entity.RegDate;
       info._RegDateIsDirty = 0;

       info.RegMoney = entity.RegMoney;
       info._RegMoneyIsDirty = 0;

       info.Phone = entity.Phone;
       info._PhoneIsDirty = 0;

       info.Fax = entity.Fax;
       info._FaxIsDirty = 0;

       info.WebSite = entity.WebSite;
       info._WebSiteIsDirty = 0;

       info.RegionId = entity.RegionId;
       info._RegionIdIsDirty = 0;

       info.DetailAddress = entity.DetailAddress;
       info._DetailAddressIsDirty = 0;

       info.Intro = entity.Intro;
       info._IntroIsDirty = 0;

       info.IsOwner = entity.IsOwner;
       info._IsOwnerIsDirty = 0;

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

    public static void CompanyClientTypeDTE(CompanyClientTypeInfo info, CompanyClientType entity)
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

       if (info._ClientTypeIdIsDirty == 1)
        {
           entity.ClientTypeId = info.ClientTypeId;
           info._ClientTypeIdIsDirty = 0;
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

    public static void CompanyClientTypeETD(CompanyClientType entity, CompanyClientTypeInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.CompanyId = entity.CompanyId;
       info._CompanyIdIsDirty = 0;

       info.ClientTypeId = entity.ClientTypeId;
       info._ClientTypeIdIsDirty = 0;

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

    public static void CompanyStaffDTE(CompanyStaffInfo info, CompanyStaff entity)
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

       if (info._StaffIdIsDirty == 1)
        {
           entity.StaffId = info.StaffId;
           info._StaffIdIsDirty = 0;
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

    public static void CompanyStaffETD(CompanyStaff entity, CompanyStaffInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.CompanyId = entity.CompanyId;
       info._CompanyIdIsDirty = 0;

       info.StaffId = entity.StaffId;
       info._StaffIdIsDirty = 0;

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

    public static void DepartmentDTE(DepartmentInfo info, Department entity)
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

       if (info._DepartmentCodeIsDirty == 1)
        {
           entity.DepartmentCode = info.DepartmentCode;
           info._DepartmentCodeIsDirty = 0;
        }

       if (info._DepartmentNameIsDirty == 1)
        {
           entity.DepartmentName = info.DepartmentName;
           info._DepartmentNameIsDirty = 0;
        }

       if (info._CompanyIdIsDirty == 1)
        {
           entity.CompanyId = info.CompanyId;
           info._CompanyIdIsDirty = 0;
        }

       if (info._TreeNodeIsDirty == 1)
        {
           entity.TreeNode = info.TreeNode;
           info._TreeNodeIsDirty = 0;
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

    public static void DepartmentETD(Department entity, DepartmentInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ParentId = entity.ParentId;
       info._ParentIdIsDirty = 0;

       info.DepartmentCode = entity.DepartmentCode;
       info._DepartmentCodeIsDirty = 0;

       info.DepartmentName = entity.DepartmentName;
       info._DepartmentNameIsDirty = 0;

       info.CompanyId = entity.CompanyId;
       info._CompanyIdIsDirty = 0;

       info.TreeNode = entity.TreeNode;
       info._TreeNodeIsDirty = 0;

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

    public static void FacilityDTE(FacilityInfo info, Facility entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._FacilityCodeIsDirty == 1)
        {
           entity.FacilityCode = info.FacilityCode;
           info._FacilityCodeIsDirty = 0;
        }

       if (info._FacilityNameIsDirty == 1)
        {
           entity.FacilityName = info.FacilityName;
           info._FacilityNameIsDirty = 0;
        }

       if (info._MenuIdIsDirty == 1)
        {
           entity.MenuId = info.MenuId;
           info._MenuIdIsDirty = 0;
        }

       if (info._AppIdIsDirty == 1)
        {
           entity.AppId = info.AppId;
           info._AppIdIsDirty = 0;
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

    public static void FacilityETD(Facility entity, FacilityInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.FacilityCode = entity.FacilityCode;
       info._FacilityCodeIsDirty = 0;

       info.FacilityName = entity.FacilityName;
       info._FacilityNameIsDirty = 0;

       info.MenuId = entity.MenuId;
       info._MenuIdIsDirty = 0;

       info.AppId = entity.AppId;
       info._AppIdIsDirty = 0;

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

    public static void FacilityFunctionDTE(FacilityFunctionInfo info, FacilityFunction entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._FacilityIdIsDirty == 1)
        {
           entity.FacilityId = info.FacilityId;
           info._FacilityIdIsDirty = 0;
        }

       if (info._FunctionIdIsDirty == 1)
        {
           entity.FunctionId = info.FunctionId;
           info._FunctionIdIsDirty = 0;
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

    public static void FacilityFunctionETD(FacilityFunction entity, FacilityFunctionInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.FacilityId = entity.FacilityId;
       info._FacilityIdIsDirty = 0;

       info.FunctionId = entity.FunctionId;
       info._FunctionIdIsDirty = 0;

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

    public static void FunctionDTE(FunctionInfo info, Function entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._FunctionCodeIsDirty == 1)
        {
           entity.FunctionCode = info.FunctionCode;
           info._FunctionCodeIsDirty = 0;
        }

       if (info._FunctionNameIsDirty == 1)
        {
           entity.FunctionName = info.FunctionName;
           info._FunctionNameIsDirty = 0;
        }

       if (info._FunctionIconIsDirty == 1)
        {
           entity.FunctionIcon = info.FunctionIcon;
           info._FunctionIconIsDirty = 0;
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

    public static void FunctionETD(Function entity, FunctionInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.FunctionCode = entity.FunctionCode;
       info._FunctionCodeIsDirty = 0;

       info.FunctionName = entity.FunctionName;
       info._FunctionNameIsDirty = 0;

       info.FunctionIcon = entity.FunctionIcon;
       info._FunctionIconIsDirty = 0;

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

    public static void MenuDTE(MenuInfo info, Menu entity)
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

       if (info._MenuCodeIsDirty == 1)
        {
           entity.MenuCode = info.MenuCode;
           info._MenuCodeIsDirty = 0;
        }

       if (info._MenuNameIsDirty == 1)
        {
           entity.MenuName = info.MenuName;
           info._MenuNameIsDirty = 0;
        }

       if (info._MenuIconIsDirty == 1)
        {
           entity.MenuIcon = info.MenuIcon;
           info._MenuIconIsDirty = 0;
        }

       if (info._MenuPathIsDirty == 1)
        {
           entity.MenuPath = info.MenuPath;
           info._MenuPathIsDirty = 0;
        }

       if (info._AppIdIsDirty == 1)
        {
           entity.AppId = info.AppId;
           info._AppIdIsDirty = 0;
        }

       if (info._IsLeafIsDirty == 1)
        {
           entity.IsLeaf = info.IsLeaf;
           info._IsLeafIsDirty = 0;
        }

       if (info._TreeNodeIsDirty == 1)
        {
           entity.TreeNode = info.TreeNode;
           info._TreeNodeIsDirty = 0;
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

    public static void MenuETD(Menu entity, MenuInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ParentId = entity.ParentId;
       info._ParentIdIsDirty = 0;

       info.MenuCode = entity.MenuCode;
       info._MenuCodeIsDirty = 0;

       info.MenuName = entity.MenuName;
       info._MenuNameIsDirty = 0;

       info.MenuIcon = entity.MenuIcon;
       info._MenuIconIsDirty = 0;

       info.MenuPath = entity.MenuPath;
       info._MenuPathIsDirty = 0;

       info.AppId = entity.AppId;
       info._AppIdIsDirty = 0;

       info.IsLeaf = entity.IsLeaf;
       info._IsLeafIsDirty = 0;

       info.TreeNode = entity.TreeNode;
       info._TreeNodeIsDirty = 0;

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

    public static void RegionDTE(RegionInfo info, Region entity)
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

       if (info._RegionCodeIsDirty == 1)
        {
           entity.RegionCode = info.RegionCode;
           info._RegionCodeIsDirty = 0;
        }

       if (info._RegionNameIsDirty == 1)
        {
           entity.RegionName = info.RegionName;
           info._RegionNameIsDirty = 0;
        }

       if (info._ZipCodeIsDirty == 1)
        {
           entity.ZipCode = info.ZipCode;
           info._ZipCodeIsDirty = 0;
        }

       if (info._TreeNodeIsDirty == 1)
        {
           entity.TreeNode = info.TreeNode;
           info._TreeNodeIsDirty = 0;
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

    public static void RegionETD(Region entity, RegionInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ParentId = entity.ParentId;
       info._ParentIdIsDirty = 0;

       info.RegionCode = entity.RegionCode;
       info._RegionCodeIsDirty = 0;

       info.RegionName = entity.RegionName;
       info._RegionNameIsDirty = 0;

       info.ZipCode = entity.ZipCode;
       info._ZipCodeIsDirty = 0;

       info.TreeNode = entity.TreeNode;
       info._TreeNodeIsDirty = 0;

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

    public static void RoleDTE(RoleInfo info, Role entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._RoleCodeIsDirty == 1)
        {
           entity.RoleCode = info.RoleCode;
           info._RoleCodeIsDirty = 0;
        }

       if (info._RoleNameIsDirty == 1)
        {
           entity.RoleName = info.RoleName;
           info._RoleNameIsDirty = 0;
        }

       if (info._AppIdIsDirty == 1)
        {
           entity.AppId = info.AppId;
           info._AppIdIsDirty = 0;
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

    public static void RoleETD(Role entity, RoleInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.RoleCode = entity.RoleCode;
       info._RoleCodeIsDirty = 0;

       info.RoleName = entity.RoleName;
       info._RoleNameIsDirty = 0;

       info.AppId = entity.AppId;
       info._AppIdIsDirty = 0;

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

    public static void RoleFacilityDTE(RoleFacilityInfo info, RoleFacility entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._RoleIdIsDirty == 1)
        {
           entity.RoleId = info.RoleId;
           info._RoleIdIsDirty = 0;
        }

       if (info._FacilityIdIsDirty == 1)
        {
           entity.FacilityId = info.FacilityId;
           info._FacilityIdIsDirty = 0;
        }

       if (info._AccessScopeIsDirty == 1)
        {
           entity.AccessScope = info.AccessScope;
           info._AccessScopeIsDirty = 0;
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

    public static void RoleFacilityETD(RoleFacility entity, RoleFacilityInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.RoleId = entity.RoleId;
       info._RoleIdIsDirty = 0;

       info.FacilityId = entity.FacilityId;
       info._FacilityIdIsDirty = 0;

       info.AccessScope = entity.AccessScope;
       info._AccessScopeIsDirty = 0;

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

    public static void StaffDTE(StaffInfo info, Staff entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._UserCodeIsDirty == 1)
        {
           entity.UserCode = info.UserCode;
           info._UserCodeIsDirty = 0;
        }

       if (info._PasswordIsDirty == 1)
        {
           entity.Password = info.Password;
           info._PasswordIsDirty = 0;
        }

       if (info._UserNameIsDirty == 1)
        {
           entity.UserName = info.UserName;
           info._UserNameIsDirty = 0;
        }

       if (info._SexIsDirty == 1)
        {
           entity.Sex = info.Sex;
           info._SexIsDirty = 0;
        }

       if (info._BrithDateIsDirty == 1)
        {
           entity.BrithDate = info.BrithDate;
           info._BrithDateIsDirty = 0;
        }

       if (info._PhoneIsDirty == 1)
        {
           entity.Phone = info.Phone;
           info._PhoneIsDirty = 0;
        }

       if (info._FaxIsDirty == 1)
        {
           entity.Fax = info.Fax;
           info._FaxIsDirty = 0;
        }

       if (info._MobileIsDirty == 1)
        {
           entity.Mobile = info.Mobile;
           info._MobileIsDirty = 0;
        }

       if (info._EmailIsDirty == 1)
        {
           entity.Email = info.Email;
           info._EmailIsDirty = 0;
        }

       if (info._DepartmentIdIsDirty == 1)
        {
           entity.DepartmentId = info.DepartmentId;
           info._DepartmentIdIsDirty = 0;
        }

       if (info._RegionIdIsDirty == 1)
        {
           entity.RegionId = info.RegionId;
           info._RegionIdIsDirty = 0;
        }

       if (info._DetailAddressIsDirty == 1)
        {
           entity.DetailAddress = info.DetailAddress;
           info._DetailAddressIsDirty = 0;
        }

       if (info._ZipCodeIsDirty == 1)
        {
           entity.ZipCode = info.ZipCode;
           info._ZipCodeIsDirty = 0;
        }

       if (info._IsLoginIsDirty == 1)
        {
           entity.IsLogin = info.IsLogin;
           info._IsLoginIsDirty = 0;
        }

       if (info._IsVerifyIsDirty == 1)
        {
           entity.IsVerify = info.IsVerify;
           info._IsVerifyIsDirty = 0;
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

    public static void StaffETD(Staff entity, StaffInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.UserCode = entity.UserCode;
       info._UserCodeIsDirty = 0;

       info.Password = entity.Password;
       info._PasswordIsDirty = 0;

       info.UserName = entity.UserName;
       info._UserNameIsDirty = 0;

       info.Sex = entity.Sex;
       info._SexIsDirty = 0;

       info.BrithDate = entity.BrithDate;
       info._BrithDateIsDirty = 0;

       info.Phone = entity.Phone;
       info._PhoneIsDirty = 0;

       info.Fax = entity.Fax;
       info._FaxIsDirty = 0;

       info.Mobile = entity.Mobile;
       info._MobileIsDirty = 0;

       info.Email = entity.Email;
       info._EmailIsDirty = 0;

       info.DepartmentId = entity.DepartmentId;
       info._DepartmentIdIsDirty = 0;

       info.RegionId = entity.RegionId;
       info._RegionIdIsDirty = 0;

       info.DetailAddress = entity.DetailAddress;
       info._DetailAddressIsDirty = 0;

       info.ZipCode = entity.ZipCode;
       info._ZipCodeIsDirty = 0;

       info.IsLogin = entity.IsLogin;
       info._IsLoginIsDirty = 0;

       info.IsVerify = entity.IsVerify;
       info._IsVerifyIsDirty = 0;

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

    public static void StaffStationDTE(StaffStationInfo info, StaffStation entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._StaffIdIsDirty == 1)
        {
           entity.StaffId = info.StaffId;
           info._StaffIdIsDirty = 0;
        }

       if (info._StationIdIsDirty == 1)
        {
           entity.StationId = info.StationId;
           info._StationIdIsDirty = 0;
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

    public static void StaffStationETD(StaffStation entity, StaffStationInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.StaffId = entity.StaffId;
       info._StaffIdIsDirty = 0;

       info.StationId = entity.StationId;
       info._StationIdIsDirty = 0;

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

    public static void StationDTE(StationInfo info, Station entity)
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

       if (info._DepartmentIdIsDirty == 1)
        {
           entity.DepartmentId = info.DepartmentId;
           info._DepartmentIdIsDirty = 0;
        }

       if (info._StationNameIsDirty == 1)
        {
           entity.StationName = info.StationName;
           info._StationNameIsDirty = 0;
        }

       if (info._TreeNodeIsDirty == 1)
        {
           entity.TreeNode = info.TreeNode;
           info._TreeNodeIsDirty = 0;
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

    public static void StationETD(Station entity, StationInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ParentId = entity.ParentId;
       info._ParentIdIsDirty = 0;

       info.DepartmentId = entity.DepartmentId;
       info._DepartmentIdIsDirty = 0;

       info.StationName = entity.StationName;
       info._StationNameIsDirty = 0;

       info.TreeNode = entity.TreeNode;
       info._TreeNodeIsDirty = 0;

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

    public static void StationRoleDTE(StationRoleInfo info, StationRole entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._StationIdIsDirty == 1)
        {
           entity.StationId = info.StationId;
           info._StationIdIsDirty = 0;
        }

       if (info._RoleIdIsDirty == 1)
        {
           entity.RoleId = info.RoleId;
           info._RoleIdIsDirty = 0;
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

    public static void StationRoleETD(StationRole entity, StationRoleInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.StationId = entity.StationId;
       info._StationIdIsDirty = 0;

       info.RoleId = entity.RoleId;
       info._RoleIdIsDirty = 0;

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

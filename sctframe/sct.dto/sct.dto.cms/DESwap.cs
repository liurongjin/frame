using sct.ent.cms;


namespace sct.dto.cms
{

  public class DESwap
  {

    public static void AdviceDTE(AdviceInfo info, Advice entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._XIsDirty == 1)
        {
           entity.X = info.X;
           info._XIsDirty = 0;
        }

       if (info._YIsDirty == 1)
        {
           entity.Y = info.Y;
           info._YIsDirty = 0;
        }

       if (info._ScaleIsDirty == 1)
        {
           entity.Scale = info.Scale;
           info._ScaleIsDirty = 0;
        }

       if (info._TitleIsDirty == 1)
        {
           entity.Title = info.Title;
           info._TitleIsDirty = 0;
        }

       if (info._DescIsDirty == 1)
        {
           entity.Desc = info.Desc;
           info._DescIsDirty = 0;
        }

       if (info._ContactIsDirty == 1)
        {
           entity.Contact = info.Contact;
           info._ContactIsDirty = 0;
        }

       if (info._ContactMethodIsDirty == 1)
        {
           entity.ContactMethod = info.ContactMethod;
           info._ContactMethodIsDirty = 0;
        }

       if (info._StateIsDirty == 1)
        {
           entity.State = info.State;
           info._StateIsDirty = 0;
        }

       if (info._ProgressLogIsDirty == 1)
        {
           entity.ProgressLog = info.ProgressLog;
           info._ProgressLogIsDirty = 0;
        }

       if (info._ResultIsDirty == 1)
        {
           entity.Result = info.Result;
           info._ResultIsDirty = 0;
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

       if (info._HandleTimeIsDirty == 1)
        {
           entity.HandleTime = info.HandleTime;
           info._HandleTimeIsDirty = 0;
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

    public static void AdviceETD(Advice entity, AdviceInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.X = entity.X;
       info._XIsDirty = 0;

       info.Y = entity.Y;
       info._YIsDirty = 0;

       info.Scale = entity.Scale;
       info._ScaleIsDirty = 0;

       info.Title = entity.Title;
       info._TitleIsDirty = 0;

       info.Desc = entity.Desc;
       info._DescIsDirty = 0;

       info.Contact = entity.Contact;
       info._ContactIsDirty = 0;

       info.ContactMethod = entity.ContactMethod;
       info._ContactMethodIsDirty = 0;

       info.State = entity.State;
       info._StateIsDirty = 0;

       info.ProgressLog = entity.ProgressLog;
       info._ProgressLogIsDirty = 0;

       info.Result = entity.Result;
       info._ResultIsDirty = 0;

       info.HandleStaffId = entity.HandleStaffId;
       info._HandleStaffIdIsDirty = 0;

       info.HandleStaffName = entity.HandleStaffName;
       info._HandleStaffNameIsDirty = 0;

       info.HandleTime = entity.HandleTime;
       info._HandleTimeIsDirty = 0;

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

    public static void ArticleDTE(ArticleInfo info, Article entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ArticleCatalogIdIsDirty == 1)
        {
           entity.ArticleCatalogId = info.ArticleCatalogId;
           info._ArticleCatalogIdIsDirty = 0;
        }

       if (info._TreeNodeIsDirty == 1)
        {
           entity.TreeNode = info.TreeNode;
           info._TreeNodeIsDirty = 0;
        }

       if (info._ArticleTypeIsDirty == 1)
        {
           entity.ArticleType = info.ArticleType;
           info._ArticleTypeIsDirty = 0;
        }

       if (info._TitleIsDirty == 1)
        {
           entity.Title = info.Title;
           info._TitleIsDirty = 0;
        }

       if (info._SubTitleIsDirty == 1)
        {
           entity.SubTitle = info.SubTitle;
           info._SubTitleIsDirty = 0;
        }

       if (info._DataSourceIsDirty == 1)
        {
           entity.DataSource = info.DataSource;
           info._DataSourceIsDirty = 0;
        }

       if (info._FormDateIsDirty == 1)
        {
           entity.FormDate = info.FormDate;
           info._FormDateIsDirty = 0;
        }

       if (info._KeywordIsDirty == 1)
        {
           entity.Keyword = info.Keyword;
           info._KeywordIsDirty = 0;
        }

       if (info._SummaryIsDirty == 1)
        {
           entity.Summary = info.Summary;
           info._SummaryIsDirty = 0;
        }

       if (info._SignImageIsDirty == 1)
        {
           entity.SignImage = info.SignImage;
           info._SignImageIsDirty = 0;
        }

       if (info._ClickIsDirty == 1)
        {
           entity.Click = info.Click;
           info._ClickIsDirty = 0;
        }

       if (info._AuditStateIsDirty == 1)
        {
           entity.AuditState = info.AuditState;
           info._AuditStateIsDirty = 0;
        }

       if (info._AuditReasonIsDirty == 1)
        {
           entity.AuditReason = info.AuditReason;
           info._AuditReasonIsDirty = 0;
        }

       if (info._AuditStaffIsDirty == 1)
        {
           entity.AuditStaff = info.AuditStaff;
           info._AuditStaffIsDirty = 0;
        }

       if (info._AuditTimeIsDirty == 1)
        {
           entity.AuditTime = info.AuditTime;
           info._AuditTimeIsDirty = 0;
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

    public static void ArticleETD(Article entity, ArticleInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ArticleCatalogId = entity.ArticleCatalogId;
       info._ArticleCatalogIdIsDirty = 0;

       info.TreeNode = entity.TreeNode;
       info._TreeNodeIsDirty = 0;

       info.ArticleType = entity.ArticleType;
       info._ArticleTypeIsDirty = 0;

       info.Title = entity.Title;
       info._TitleIsDirty = 0;

       info.SubTitle = entity.SubTitle;
       info._SubTitleIsDirty = 0;

       info.DataSource = entity.DataSource;
       info._DataSourceIsDirty = 0;

       info.FormDate = entity.FormDate;
       info._FormDateIsDirty = 0;

       info.Keyword = entity.Keyword;
       info._KeywordIsDirty = 0;

       info.Summary = entity.Summary;
       info._SummaryIsDirty = 0;

       info.SignImage = entity.SignImage;
       info._SignImageIsDirty = 0;

       info.Click = entity.Click;
       info._ClickIsDirty = 0;

       info.AuditState = entity.AuditState;
       info._AuditStateIsDirty = 0;

       info.AuditReason = entity.AuditReason;
       info._AuditReasonIsDirty = 0;

       info.AuditStaff = entity.AuditStaff;
       info._AuditStaffIsDirty = 0;

       info.AuditTime = entity.AuditTime;
       info._AuditTimeIsDirty = 0;

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

    public static void ArticleAnnexDTE(ArticleAnnexInfo info, ArticleAnnex entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ArticleIdIsDirty == 1)
        {
           entity.ArticleId = info.ArticleId;
           info._ArticleIdIsDirty = 0;
        }

       if (info._TitleIsDirty == 1)
        {
           entity.Title = info.Title;
           info._TitleIsDirty = 0;
        }

       if (info._SummaryIsDirty == 1)
        {
           entity.Summary = info.Summary;
           info._SummaryIsDirty = 0;
        }

       if (info._PathIsDirty == 1)
        {
           entity.Path = info.Path;
           info._PathIsDirty = 0;
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

    public static void ArticleAnnexETD(ArticleAnnex entity, ArticleAnnexInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ArticleId = entity.ArticleId;
       info._ArticleIdIsDirty = 0;

       info.Title = entity.Title;
       info._TitleIsDirty = 0;

       info.Summary = entity.Summary;
       info._SummaryIsDirty = 0;

       info.Path = entity.Path;
       info._PathIsDirty = 0;

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

    public static void ArticleCatalogDTE(ArticleCatalogInfo info, ArticleCatalog entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._NameIsDirty == 1)
        {
           entity.Name = info.Name;
           info._NameIsDirty = 0;
        }

       if (info._IsColumnIsDirty == 1)
        {
           entity.IsColumn = info.IsColumn;
           info._IsColumnIsDirty = 0;
        }

       if (info._CodeIsDirty == 1)
        {
           entity.Code = info.Code;
           info._CodeIsDirty = 0;
        }

       if (info._ImageIsDirty == 1)
        {
           entity.Image = info.Image;
           info._ImageIsDirty = 0;
        }

       if (info._ParentIdIsDirty == 1)
        {
           entity.ParentId = info.ParentId;
           info._ParentIdIsDirty = 0;
        }

       if (info._TreeNodeIsDirty == 1)
        {
           entity.TreeNode = info.TreeNode;
           info._TreeNodeIsDirty = 0;
        }

       if (info._LinkUrlIsDirty == 1)
        {
           entity.LinkUrl = info.LinkUrl;
           info._LinkUrlIsDirty = 0;
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

    public static void ArticleCatalogETD(ArticleCatalog entity, ArticleCatalogInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.Name = entity.Name;
       info._NameIsDirty = 0;

       info.IsColumn = entity.IsColumn;
       info._IsColumnIsDirty = 0;

       info.Code = entity.Code;
       info._CodeIsDirty = 0;

       info.Image = entity.Image;
       info._ImageIsDirty = 0;

       info.ParentId = entity.ParentId;
       info._ParentIdIsDirty = 0;

       info.TreeNode = entity.TreeNode;
       info._TreeNodeIsDirty = 0;

       info.LinkUrl = entity.LinkUrl;
       info._LinkUrlIsDirty = 0;

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

    public static void ArticleDetailDTE(ArticleDetailInfo info, ArticleDetail entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ArticleIdIsDirty == 1)
        {
           entity.ArticleId = info.ArticleId;
           info._ArticleIdIsDirty = 0;
        }

       if (info._DetailIsDirty == 1)
        {
           entity.Detail = info.Detail;
           info._DetailIsDirty = 0;
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

    public static void ArticleDetailETD(ArticleDetail entity, ArticleDetailInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ArticleId = entity.ArticleId;
       info._ArticleIdIsDirty = 0;

       info.Detail = entity.Detail;
       info._DetailIsDirty = 0;

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

    public static void ArticleImageDTE(ArticleImageInfo info, ArticleImage entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ArticleIdIsDirty == 1)
        {
           entity.ArticleId = info.ArticleId;
           info._ArticleIdIsDirty = 0;
        }

       if (info._AltTextIsDirty == 1)
        {
           entity.AltText = info.AltText;
           info._AltTextIsDirty = 0;
        }

       if (info._SummaryIsDirty == 1)
        {
           entity.Summary = info.Summary;
           info._SummaryIsDirty = 0;
        }

       if (info._PathIsDirty == 1)
        {
           entity.Path = info.Path;
           info._PathIsDirty = 0;
        }

       if (info._ThumbPathIsDirty == 1)
        {
           entity.ThumbPath = info.ThumbPath;
           info._ThumbPathIsDirty = 0;
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

    public static void ArticleImageETD(ArticleImage entity, ArticleImageInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ArticleId = entity.ArticleId;
       info._ArticleIdIsDirty = 0;

       info.AltText = entity.AltText;
       info._AltTextIsDirty = 0;

       info.Summary = entity.Summary;
       info._SummaryIsDirty = 0;

       info.Path = entity.Path;
       info._PathIsDirty = 0;

       info.ThumbPath = entity.ThumbPath;
       info._ThumbPathIsDirty = 0;

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

    public static void ArticleVideoDTE(ArticleVideoInfo info, ArticleVideo entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._ArticleIdIsDirty == 1)
        {
           entity.ArticleId = info.ArticleId;
           info._ArticleIdIsDirty = 0;
        }

       if (info._TitleIsDirty == 1)
        {
           entity.Title = info.Title;
           info._TitleIsDirty = 0;
        }

       if (info._FilePathIsDirty == 1)
        {
           entity.FilePath = info.FilePath;
           info._FilePathIsDirty = 0;
        }

       if (info._FirstImagePathIsDirty == 1)
        {
           entity.FirstImagePath = info.FirstImagePath;
           info._FirstImagePathIsDirty = 0;
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

    public static void ArticleVideoETD(ArticleVideo entity, ArticleVideoInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ArticleId = entity.ArticleId;
       info._ArticleIdIsDirty = 0;

       info.Title = entity.Title;
       info._TitleIsDirty = 0;

       info.FilePath = entity.FilePath;
       info._FilePathIsDirty = 0;

       info.FirstImagePath = entity.FirstImagePath;
       info._FirstImagePathIsDirty = 0;

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

    public static void FriendLinkDTE(FriendLinkInfo info, FriendLink entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._FriendTypeIsDirty == 1)
        {
           entity.FriendType = info.FriendType;
           info._FriendTypeIsDirty = 0;
        }

       if (info._TitleIsDirty == 1)
        {
           entity.Title = info.Title;
           info._TitleIsDirty = 0;
        }

       if (info._LinkUrlIsDirty == 1)
        {
           entity.LinkUrl = info.LinkUrl;
           info._LinkUrlIsDirty = 0;
        }

       if (info._LogoImageIsDirty == 1)
        {
           entity.LogoImage = info.LogoImage;
           info._LogoImageIsDirty = 0;
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

    public static void FriendLinkETD(FriendLink entity, FriendLinkInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.FriendType = entity.FriendType;
       info._FriendTypeIsDirty = 0;

       info.Title = entity.Title;
       info._TitleIsDirty = 0;

       info.LinkUrl = entity.LinkUrl;
       info._LinkUrlIsDirty = 0;

       info.LogoImage = entity.LogoImage;
       info._LogoImageIsDirty = 0;

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

    public static void PlateDTE(PlateInfo info, Plate entity)
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

       if (info._CodeIsDirty == 1)
        {
           entity.Code = info.Code;
           info._CodeIsDirty = 0;
        }

       if (info._NameIsDirty == 1)
        {
           entity.Name = info.Name;
           info._NameIsDirty = 0;
        }

       if (info._ImageUrlIsDirty == 1)
        {
           entity.ImageUrl = info.ImageUrl;
           info._ImageUrlIsDirty = 0;
        }

       if (info._PlateTypeIsDirty == 1)
        {
           entity.PlateType = info.PlateType;
           info._PlateTypeIsDirty = 0;
        }

       if (info._SummaryIsDirty == 1)
        {
           entity.Summary = info.Summary;
           info._SummaryIsDirty = 0;
        }

       if (info._LimitNumIsDirty == 1)
        {
           entity.LimitNum = info.LimitNum;
           info._LimitNumIsDirty = 0;
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

    public static void PlateETD(Plate entity, PlateInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.ParentId = entity.ParentId;
       info._ParentIdIsDirty = 0;

       info.Code = entity.Code;
       info._CodeIsDirty = 0;

       info.Name = entity.Name;
       info._NameIsDirty = 0;

       info.ImageUrl = entity.ImageUrl;
       info._ImageUrlIsDirty = 0;

       info.PlateType = entity.PlateType;
       info._PlateTypeIsDirty = 0;

       info.Summary = entity.Summary;
       info._SummaryIsDirty = 0;

       info.LimitNum = entity.LimitNum;
       info._LimitNumIsDirty = 0;

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

    public static void PlateNewsDTE(PlateNewsInfo info, PlateNews entity)
    {
       if (info._IdIsDirty == 1)
        {
           entity.Id = info.Id;
           info._IdIsDirty = 0;
        }

       if (info._PlateIdIsDirty == 1)
        {
           entity.PlateId = info.PlateId;
           info._PlateIdIsDirty = 0;
        }

       if (info._ArticleCatalogIdIsDirty == 1)
        {
           entity.ArticleCatalogId = info.ArticleCatalogId;
           info._ArticleCatalogIdIsDirty = 0;
        }

       if (info._TitleIsDirty == 1)
        {
           entity.Title = info.Title;
           info._TitleIsDirty = 0;
        }

       if (info._SummaryIsDirty == 1)
        {
           entity.Summary = info.Summary;
           info._SummaryIsDirty = 0;
        }

       if (info._ContentTextIsDirty == 1)
        {
           entity.ContentText = info.ContentText;
           info._ContentTextIsDirty = 0;
        }

       if (info._NewsLabelIsDirty == 1)
        {
           entity.NewsLabel = info.NewsLabel;
           info._NewsLabelIsDirty = 0;
        }

       if (info._ImageUrlIsDirty == 1)
        {
           entity.ImageUrl = info.ImageUrl;
           info._ImageUrlIsDirty = 0;
        }

       if (info._VideoUrlIsDirty == 1)
        {
           entity.VideoUrl = info.VideoUrl;
           info._VideoUrlIsDirty = 0;
        }

       if (info._VideoImageIsDirty == 1)
        {
           entity.VideoImage = info.VideoImage;
           info._VideoImageIsDirty = 0;
        }

       if (info._TargetUrlIsDirty == 1)
        {
           entity.TargetUrl = info.TargetUrl;
           info._TargetUrlIsDirty = 0;
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

    public static void PlateNewsETD(PlateNews entity, PlateNewsInfo info)
    {
       info.Id = entity.Id;
       info._IdIsDirty = 0;

       info.PlateId = entity.PlateId;
       info._PlateIdIsDirty = 0;

       info.ArticleCatalogId = entity.ArticleCatalogId;
       info._ArticleCatalogIdIsDirty = 0;

       info.Title = entity.Title;
       info._TitleIsDirty = 0;

       info.Summary = entity.Summary;
       info._SummaryIsDirty = 0;

       info.ContentText = entity.ContentText;
       info._ContentTextIsDirty = 0;

       info.NewsLabel = entity.NewsLabel;
       info._NewsLabelIsDirty = 0;

       info.ImageUrl = entity.ImageUrl;
       info._ImageUrlIsDirty = 0;

       info.VideoUrl = entity.VideoUrl;
       info._VideoUrlIsDirty = 0;

       info.VideoImage = entity.VideoImage;
       info._VideoImageIsDirty = 0;

       info.TargetUrl = entity.TargetUrl;
       info._TargetUrlIsDirty = 0;

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

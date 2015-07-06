using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace sct.dto.mrp
{

[DataContract]
  public partial class MaterialInfo
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
    internal int  _MaterialCatalogIdIsDirty = 0; 

    [DataMember]
    internal string  _MaterialCatalogId; 

    [DataMember]
    [StringLength(36)]
    public string  MaterialCatalogId
    {
      get{
         return _MaterialCatalogId;
      }
      set{
         _MaterialCatalogId = value;
         _MaterialCatalogIdIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _MaterialCodeIsDirty = 0; 

    [DataMember]
    internal string  _MaterialCode; 

    [DataMember]
    [StringLength(200)]
    public string  MaterialCode
    {
      get{
         return _MaterialCode;
      }
      set{
         _MaterialCode = value;
         _MaterialCodeIsDirty = 1;
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
    internal int  _SearchKeyIsDirty = 0; 

    [DataMember]
    internal string  _SearchKey; 

    [DataMember]
    [StringLength(20)]
    public string  SearchKey
    {
      get{
         return _SearchKey;
      }
      set{
         _SearchKey = value;
         _SearchKeyIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _UnitIdIsDirty = 0; 

    [DataMember]
    internal int  _UnitId; 

    [DataMember]
    public int  UnitId
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
    internal int  _TextureIsDirty = 0; 

    [DataMember]
    internal string  _Texture; 

    [DataMember]
    [StringLength(50)]
    public string  Texture
    {
      get{
         return _Texture;
      }
      set{
         _Texture = value;
         _TextureIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _SizeIsDirty = 0; 

    [DataMember]
    internal string  _Size; 

    [DataMember]
    [StringLength(50)]
    public string  Size
    {
      get{
         return _Size;
      }
      set{
         _Size = value;
         _SizeIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ColorIsDirty = 0; 

    [DataMember]
    internal string  _Color; 

    [DataMember]
    [StringLength(50)]
    public string  Color
    {
      get{
         return _Color;
      }
      set{
         _Color = value;
         _ColorIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _ImageUrlIsDirty = 0; 

    [DataMember]
    internal string  _ImageUrl; 

    [DataMember]
    [StringLength(200)]
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
    internal int  _MinStockIsDirty = 0; 

    [DataMember]
    internal decimal  _MinStock; 

    [DataMember]
    public decimal  MinStock
    {
      get{
         return _MinStock;
      }
      set{
         _MinStock = value;
         _MinStockIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _StockIsDirty = 0; 

    [DataMember]
    internal decimal  _Stock; 

    [DataMember]
    public decimal  Stock
    {
      get{
         return _Stock;
      }
      set{
         _Stock = value;
         _StockIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _MaxStockIsDirty = 0; 

    [DataMember]
    internal decimal  _MaxStock; 

    [DataMember]
    public decimal  MaxStock
    {
      get{
         return _MaxStock;
      }
      set{
         _MaxStock = value;
         _MaxStockIsDirty = 1;
      }
    }

    [DataMember]
    internal int  _IntroIsDirty = 0; 

    [DataMember]
    internal string  _Intro; 

    [DataMember]
    [StringLength(500)]
    public string  Intro
    {
      get{
         return _Intro;
      }
      set{
         _Intro = value;
         _IntroIsDirty = 1;
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

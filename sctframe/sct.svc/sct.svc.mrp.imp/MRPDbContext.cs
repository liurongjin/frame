using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using sct.ent.mrp;


namespace sct.svc.mrp.imp
{

  public class MRPDbContext : DbContext
  {

    public MRPDbContext() : base("MRPEntities") { }


    #region 包含对象
    public DbSet<CompanyWareHouse>  CompanyWareHouse  {　get;　set;　}

    public DbSet<GatherBill>  GatherBill  {　get;　set;　}

    public DbSet<ManufacturePlan>  ManufacturePlan  {　get;　set;　}

    public DbSet<ManufacturePlanItem>  ManufacturePlanItem  {　get;　set;　}

    public DbSet<Material>  Material  {　get;　set;　}

    public DbSet<MaterialBill>  MaterialBill  {　get;　set;　}

    public DbSet<MaterialBillItem>  MaterialBillItem  {　get;　set;　}

    public DbSet<MaterialCatalog>  MaterialCatalog  {　get;　set;　}

    public DbSet<MaterialPurchase>  MaterialPurchase  {　get;　set;　}

    public DbSet<MaterialPurchaseItem>  MaterialPurchaseItem  {　get;　set;　}

    public DbSet<MaterialPurchasePlan>  MaterialPurchasePlan  {　get;　set;　}

    public DbSet<MaterialPurchasePlanItem>  MaterialPurchasePlanItem  {　get;　set;　}

    public DbSet<MaterialWareStock>  MaterialWareStock  {　get;　set;　}

    public DbSet<Product>  Product  {　get;　set;　}

    public DbSet<ProductBill>  ProductBill  {　get;　set;　}

    public DbSet<ProductBillItem>  ProductBillItem  {　get;　set;　}

    public DbSet<ProductCatalog>  ProductCatalog  {　get;　set;　}

    public DbSet<ProductOrder>  ProductOrder  {　get;　set;　}

    public DbSet<ProductOrderItem>  ProductOrderItem  {　get;　set;　}

    public DbSet<ProductWareStock>  ProductWareStock  {　get;　set;　}

    public DbSet<Unit>  Unit  {　get;　set;　}

    public DbSet<WareHouse>  WareHouse  {　get;　set;　}

    #endregion

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
       modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }

  }

}

using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using sct.ent.uc;


namespace sct.svc.uc.imp
{

  public class UCDbContext : DbContext
  {

    public UCDbContext() : base("UCEntities") { }


    #region 包含对象
    public DbSet<App>  App  {　get;　set;　}

    public DbSet<ClientType>  ClientType  {　get;　set;　}

    public DbSet<Company>  Company  {　get;　set;　}

    public DbSet<CompanyClientType>  CompanyClientType  {　get;　set;　}

    public DbSet<CompanyStaff>  CompanyStaff  {　get;　set;　}

    public DbSet<Department>  Department  {　get;　set;　}

    public DbSet<Facility>  Facility  {　get;　set;　}

    public DbSet<FacilityFunction>  FacilityFunction  {　get;　set;　}

    public DbSet<Function>  Function  {　get;　set;　}

    public DbSet<Menu>  Menu  {　get;　set;　}

    public DbSet<Region>  Region  {　get;　set;　}

    public DbSet<Role>  Role  {　get;　set;　}

    public DbSet<RoleFacility>  RoleFacility  {　get;　set;　}

    public DbSet<Staff>  Staff  {　get;　set;　}

    public DbSet<StaffStation>  StaffStation  {　get;　set;　}

    public DbSet<Station>  Station  {　get;　set;　}

    public DbSet<StationRole>  StationRole  {　get;　set;　}

    #endregion

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
       modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }

  }

}

using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using sct.ent.cms;


namespace sct.svc.cms.imp
{

  public class CmsDbContext : DbContext
  {

    public CmsDbContext() : base("CmsEntities") { }


    #region 包含对象
    public DbSet<Advice>  Advice  {　get;　set;　}

    public DbSet<Article>  Article  {　get;　set;　}

    public DbSet<ArticleAnnex>  ArticleAnnex  {　get;　set;　}

    public DbSet<ArticleCatalog>  ArticleCatalog  {　get;　set;　}

    public DbSet<ArticleDetail>  ArticleDetail  {　get;　set;　}

    public DbSet<ArticleImage>  ArticleImage  {　get;　set;　}

    public DbSet<ArticleVideo>  ArticleVideo  {　get;　set;　}

    public DbSet<FriendLink>  FriendLink  {　get;　set;　}

    public DbSet<Plate>  Plate  {　get;　set;　}

    public DbSet<PlateNews>  PlateNews  {　get;　set;　}

    #endregion

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
       modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }

  }

}

using sct.ent.mrp;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace sct.svc.mrp.imp
{

  public class WareHouseRpt
  {

    public void Insert(DbContext DbContext,WareHouse entity)
    {
      DbContext.Entry(entity).State = EntityState.Added;
    }

     public void Update(DbContext DbContext,WareHouse entity)
     {
       EntityState state = DbContext.Entry(entity).State;
       if (state == EntityState.Detached)
       {
          DbContext.Entry(entity).State = EntityState.Modified;
        }
    }

    public void Delete(DbContext DbContext,WareHouse  entity)
    {
       DbContext.Entry(entity).State = EntityState.Deleted;
    }

     public WareHouse Get(DbContext DbContext, string key)
    {
        return DbContext.Set<WareHouse>().Where(p => p.Id.Equals(key)).FirstOrDefault();
    }

    public void Insert(DbContext DbContext, IEnumerable<WareHouse> entities)
    {
       try
       {
          DbContext.Configuration.AutoDetectChangesEnabled = false;
          foreach (WareHouse  entity in entities)
          {
            DbContext.Entry(entity).State = EntityState.Added;
          }
       }
       finally
       {
         DbContext.Configuration.AutoDetectChangesEnabled = true;
       }
    }

    public void Update(DbContext DbContext, IEnumerable<WareHouse> entities)
    {
       try
       {
          DbContext.Configuration.AutoDetectChangesEnabled = false;
          foreach (WareHouse  entity in entities)
          {
              EntityState state = DbContext.Entry(entity).State;
              if (state == EntityState.Detached)
             {
                DbContext.Entry(entity).State = EntityState.Modified;
             }
          }
       }
       finally
       {
         DbContext.Configuration.AutoDetectChangesEnabled = true;
       }
    }

    public void Delete(DbContext DbContext, IEnumerable<WareHouse> entities)
    {
       try
       {
          DbContext.Configuration.AutoDetectChangesEnabled = false;
          foreach (WareHouse  entity in entities)
          {
             DbContext.Entry(entity).State = EntityState.Deleted;
          }
       }
       finally
       {
         DbContext.Configuration.AutoDetectChangesEnabled = true;
       }
      }

  }

}

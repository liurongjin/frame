using sct.ent.uc;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace sct.svc.uc.imp
{

  public class FacilityFunctionRpt
  {

    public void Insert(DbContext DbContext,FacilityFunction entity)
    {
      DbContext.Entry(entity).State = EntityState.Added;
    }

     public void Update(DbContext DbContext,FacilityFunction entity)
     {
       EntityState state = DbContext.Entry(entity).State;
       if (state == EntityState.Detached)
       {
          DbContext.Entry(entity).State = EntityState.Modified;
        }
    }

    public void Delete(DbContext DbContext,FacilityFunction  entity)
    {
       DbContext.Entry(entity).State = EntityState.Deleted;
    }

     public FacilityFunction Get(DbContext DbContext, string key)
    {
        return DbContext.Set<FacilityFunction>().Where(p => p.Id.Equals(key)).FirstOrDefault();
    }

    public void Insert(DbContext DbContext, IEnumerable<FacilityFunction> entities)
    {
       try
       {
          DbContext.Configuration.AutoDetectChangesEnabled = false;
          foreach (FacilityFunction  entity in entities)
          {
            DbContext.Entry(entity).State = EntityState.Added;
          }
       }
       finally
       {
         DbContext.Configuration.AutoDetectChangesEnabled = true;
       }
    }

    public void Update(DbContext DbContext, IEnumerable<FacilityFunction> entities)
    {
       try
       {
          DbContext.Configuration.AutoDetectChangesEnabled = false;
          foreach (FacilityFunction  entity in entities)
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

    public void Delete(DbContext DbContext, IEnumerable<FacilityFunction> entities)
    {
       try
       {
          DbContext.Configuration.AutoDetectChangesEnabled = false;
          foreach (FacilityFunction  entity in entities)
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

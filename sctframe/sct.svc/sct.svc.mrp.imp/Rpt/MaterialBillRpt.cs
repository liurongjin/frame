using sct.ent.mrp;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace sct.svc.mrp.imp
{

  public class MaterialBillRpt
  {

    public void Insert(DbContext DbContext,MaterialBill entity)
    {
      DbContext.Entry(entity).State = EntityState.Added;
    }

     public void Update(DbContext DbContext,MaterialBill entity)
     {
       EntityState state = DbContext.Entry(entity).State;
       if (state == EntityState.Detached)
       {
          DbContext.Entry(entity).State = EntityState.Modified;
        }
    }

    public void Delete(DbContext DbContext,MaterialBill  entity)
    {
       DbContext.Entry(entity).State = EntityState.Deleted;
    }

     public MaterialBill Get(DbContext DbContext, string key)
    {
        return DbContext.Set<MaterialBill>().Where(p => p.Id.Equals(key)).FirstOrDefault();
    }

    public void Insert(DbContext DbContext, IEnumerable<MaterialBill> entities)
    {
       try
       {
          DbContext.Configuration.AutoDetectChangesEnabled = false;
          foreach (MaterialBill  entity in entities)
          {
            DbContext.Entry(entity).State = EntityState.Added;
          }
       }
       finally
       {
         DbContext.Configuration.AutoDetectChangesEnabled = true;
       }
    }

    public void Update(DbContext DbContext, IEnumerable<MaterialBill> entities)
    {
       try
       {
          DbContext.Configuration.AutoDetectChangesEnabled = false;
          foreach (MaterialBill  entity in entities)
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

    public void Delete(DbContext DbContext, IEnumerable<MaterialBill> entities)
    {
       try
       {
          DbContext.Configuration.AutoDetectChangesEnabled = false;
          foreach (MaterialBill  entity in entities)
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

using Microsoft.Data.Entity;

namespace webservice.Infrastructure.Interface.Db
{
    public interface IDatabaseContext 
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
    }
}
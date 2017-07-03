using System;
using System.Linq;
using System.Linq.Expressions;

namespace webservice.Infrastructure.Interface.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetSingle(Expression<Func<TEntity, bool>> filter);

        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null);

        void Delete(object id);

        void Delete(TEntity entityToDelete);

        void Update(TEntity entityToUpdate);

        void Insert(TEntity entityToInsert);
    }
}
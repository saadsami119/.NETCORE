using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Data.Entity;
using webservice.Infrastructure.Interface.Db;
using webservice.Infrastructure.Interface.Repository;

namespace webservice.Infrastructure.DbManager
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity :class 
    {
        private readonly IDatabaseContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(IDatabaseContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }
        public TEntity GetSingle(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Single(filter);
        }
        
        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query;
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entityToInsert)
        {
            _dbSet.Add(entityToInsert);
        }
    }
}
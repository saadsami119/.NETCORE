using webservice.Infrastructure.Interface.Db;
using webservice.Infrastructure.Interface.Repository;
using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.DbManager
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseContext _databaseContext;
        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public int SaveChanges()
        {
           return _databaseContext.SaveChanges();
        }

        public IRepository<Dish> DishRepository => new Repository<Dish>(_databaseContext);
        public IRepository<MenuType> MenuTypeRepository => new Repository<MenuType>(_databaseContext);
        public IRepository<Sales> SalesRepository => new Repository<Sales>(_databaseContext);
        public IRepository<User> UserRepository => new Repository<User>(_databaseContext);
    }
}
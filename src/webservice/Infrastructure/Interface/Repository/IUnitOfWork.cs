using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.Interface.Repository
{
    public interface IUnitOfWork
    {
        int SaveChanges();

        IRepository<Dish> DishRepository { get; }

        IRepository<MenuType> MenuTypeRepository { get; }

        IRepository<Sales> SalesRepository { get; }

        IRepository<User> UserRepository { get; }
    }
}
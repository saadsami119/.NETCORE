using Microsoft.Data.Entity;
using webservice.Infrastructure.DbManager.Mappings;
using webservice.Infrastructure.Interface.Db;
using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.DbManager
{
    public class DatabaseContext : DbContext , IDatabaseContext
    {
        public DatabaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new MenuTypeMapping(modelBuilder.Entity<MenuType>());
            new DishMapping(modelBuilder.Entity<Dish>());
            new SalesMapping(modelBuilder.Entity<Sales>());
            new OrderMapping(modelBuilder.Entity<Order>());
            new UserMapping(modelBuilder.Entity<User>());
        }
    }
}

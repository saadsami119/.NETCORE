using System.Linq;
using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.DbManager
{
    public static class DatabaseManagerExtensions
    {
        public static void EnsureSeedData(this DatabaseContext context)
        {
            if (!context.Set<MenuType>().Any())
            {

                var menuType = new MenuType { Name = "Pizza" };

                var dish = new Dish { Name = "Mexicana" };
                menuType.Dishes.Add(dish);

                dish = new Dish { Name = "Margherita", Price = 6 };
                menuType.Dishes.Add(dish);

                dish = new Dish { Name = "Funghi", Price = 8 };
                menuType.Dishes.Add(dish);

                dish = new Dish { Name = "Vegetariana", Price = 8 };
                menuType.Dishes.Add(dish);

                dish = new Dish { Name = "Quattro Formaggi", Price = 8 };
                menuType.Dishes.Add(dish);

                dish = new Dish { Name = "Marinara", Price = 8 };
                menuType.Dishes.Add(dish);

                dish = new Dish { Name = "Peperoni", Price = 8 };
                menuType.Dishes.Add(dish);

                context.Add<MenuType>(menuType);

                var pasteMenuType = new MenuType {Name = "Pasta"};

                dish = new Dish {Name = "Chicken Pasta", Price = 10};
                pasteMenuType.Dishes.Add(dish);

                dish = new Dish { Name = "Carbonara", Price = 10 };
                pasteMenuType.Dishes.Add(dish);

                context.Add<MenuType>(pasteMenuType);
                context.SaveChanges();
            }



            if (!context.Set<User>().Any())
            {
                var user = new User {FirstName = "Saad", LastName = "Sami", Password = "admin", Username = "admin"};
                context.Add<User>(user);
                context.SaveChanges();
            }
        }

    }
}
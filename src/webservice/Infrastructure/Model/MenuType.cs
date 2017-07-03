using System.Collections.Generic;
using webservice.Infrastructure.Interface;

namespace webservice.Infrastructure.Model
{
    public class MenuType : IEntity
    {
        public MenuType()
        {
            Dishes = new List<Dish>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; }

    }
}
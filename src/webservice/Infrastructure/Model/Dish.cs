using System.ComponentModel.DataAnnotations;
using webservice.Infrastructure.Interface;

namespace webservice.Infrastructure.Model
{
    public class Dish : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public  int MenuTypeId { get; set; }
        public MenuType MenuType { get; set; }

    }
}

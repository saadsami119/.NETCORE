using webservice.Infrastructure.Interface;

namespace webservice.Infrastructure.Model
{
    public class Order : IEntity
    {
        public int Id { get; set; }

        public Dish Dish { get; set; }

        public  int DishId { get; set; }

        public  int Quantity { get; set; }

    }
}
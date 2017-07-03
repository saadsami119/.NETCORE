using Microsoft.Data.Entity.Metadata.Builders;
using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.DbManager.Mappings
{
    public class OrderMapping
    {
        public OrderMapping(EntityTypeBuilder<Order> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(k => k.Id);

            entityTypeBuilder.Property(p => p.Quantity)
                .IsRequired();

            entityTypeBuilder.Ignore(x => x.DishId);

            entityTypeBuilder.HasOne(o => o.Dish);
        }
    }
}
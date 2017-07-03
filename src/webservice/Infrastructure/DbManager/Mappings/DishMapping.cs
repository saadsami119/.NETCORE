using Microsoft.Data.Entity.Metadata.Builders;
using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.DbManager.Mappings
{
    public class DishMapping
    {
        public DishMapping(EntityTypeBuilder<Dish> entityTypeBuilder)
        {

            entityTypeBuilder.HasKey(k => k.Id);

            entityTypeBuilder.Property(p => p.Name)
                .IsRequired();

            entityTypeBuilder.Property(p => p.Price)
                .IsRequired();

            entityTypeBuilder.HasOne(p => p.MenuType)
                .WithMany(d => d.Dishes)
                .HasForeignKey(fk => fk.MenuTypeId);
        }
    }
}
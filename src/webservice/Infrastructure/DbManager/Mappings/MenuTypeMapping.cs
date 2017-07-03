using Microsoft.Data.Entity.Metadata.Builders;
using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.DbManager.Mappings
{
    public class MenuTypeMapping
    {
        public MenuTypeMapping(EntityTypeBuilder<MenuType> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(k => k.Id);

            entityTypeBuilder.Property(p => p.Name).IsRequired();

        }
    }
}

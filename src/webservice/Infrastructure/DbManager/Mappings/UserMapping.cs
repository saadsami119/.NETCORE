using Microsoft.Data.Entity.Metadata.Builders;
using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.DbManager.Mappings
{
    public class UserMapping
    {
        public UserMapping(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(k => k.Id);

            entityTypeBuilder.HasAlternateKey(ak => ak.Username);
            
            entityTypeBuilder.Property(p => p.Password).IsRequired();

            entityTypeBuilder.Property(p => p.FirstName).IsRequired();

            entityTypeBuilder.Property(p => p.LastName).IsRequired();

        }
    }
}
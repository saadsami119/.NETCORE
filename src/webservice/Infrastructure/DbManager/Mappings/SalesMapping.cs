using Microsoft.Data.Entity.Metadata.Builders;
using webservice.Infrastructure.Model;

namespace webservice.Infrastructure.DbManager.Mappings
{
    public class SalesMapping
    {
        public SalesMapping(EntityTypeBuilder<Sales> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(k => k.Id);

            entityTypeBuilder.Property(p => p.Amount)
                .IsRequired();

            entityTypeBuilder.Property(p => p.CashRecieved)
                .IsRequired();

            entityTypeBuilder.Property(p => p.CashReturned)
               .IsRequired();

            entityTypeBuilder.Property(p => p.Date)
               .IsRequired();

            entityTypeBuilder.HasMany(x => x.Orders)
                .WithOne();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestVirtualStore.DataAccess
{
    public class SalesMap : IEntityTypeConfiguration<Sales>
    {
        public void Configure(EntityTypeBuilder<Sales> builder)
        {           
            builder.HasKey(s => s.ID);
            builder.Property(s => s.Date).IsRequired();
            builder.Property(s => s.Quantity).IsRequired();
            builder.Property(s => s.Total).IsRequired();
            builder.HasOne(u => u.User).WithMany(s => s.Sales).HasForeignKey(u => u.UserFK);
            builder.HasOne(p => p.Product).WithMany(s => s.Sales).HasForeignKey(p => p.ProductFK);

        }
    }
   
}

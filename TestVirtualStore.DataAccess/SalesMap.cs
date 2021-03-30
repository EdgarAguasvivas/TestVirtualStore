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
            builder.Property(s => s.Total).IsRequired();
        }
    }
   
}

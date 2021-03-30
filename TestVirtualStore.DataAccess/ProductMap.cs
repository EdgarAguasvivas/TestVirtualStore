using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestVirtualStore.DataAccess
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {          
            builder.HasKey(t => t.ID);
            builder.Property(t => t.Product_Code).IsRequired();
            builder.Property(t => t.Product_Name).IsRequired();
            builder.Property(t => t.Price).IsRequired();
            builder.Property(t => t.Quantity).IsRequired();

        }
    }
}

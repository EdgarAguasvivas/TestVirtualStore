using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestVirtualStore.DataAccess
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(t => t.ID);
            entityBuilder.Property(t => t.Product_Code).IsRequired();
            entityBuilder.Property(t => t.Product_Name).IsRequired();
            entityBuilder.Property(t => t.Price).IsRequired();
            entityBuilder.Property(t => t.Quantity).IsRequired();
        }
    }
}

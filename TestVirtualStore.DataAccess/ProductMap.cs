using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(p => p.ID_Product);        
            entityBuilder.Property(t => t.Product_Code).IsRequired();
            entityBuilder.Property(t => t.Product_Name).IsRequired();
            entityBuilder.Property(t => t.Price).IsRequired();
            entityBuilder.Property(t => t.Quantity).IsRequired();           
        }
    }

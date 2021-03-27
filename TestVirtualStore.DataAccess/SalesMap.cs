using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class SalesMap
    {
        public SalesMap(EntityTypeBuilder<Sales> entityBuilder)
        {
            entityBuilder.HasKey(s => s.ID);           
            entityBuilder.Property(s => s.Date).IsRequired();
            entityBuilder.Property(s => s.Quantity).IsRequired();
            entityBuilder.Property(s => s.Total).IsRequired();
            entityBuilder.HasOne(u => u.User).WithMany(s => s.Sales).HasForeignKey(u => u.UserFK);
            entityBuilder.HasOne(p => p.Product).WithMany(s => s.Sales).HasForeignKey(p => p.ProductFK);
        }
    }
}

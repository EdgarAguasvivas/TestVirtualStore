using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class RolesMap
    {
        public RolesMap(EntityTypeBuilder<Roles> entityBuilder)
        {
            entityBuilder.HasKey(r => r.ID);
            entityBuilder.Property(r => r.Rol_Name).IsRequired();           
        }
    }
}

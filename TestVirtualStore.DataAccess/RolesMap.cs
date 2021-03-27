using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class RolesMap
    {
        public RolesMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(r => r.ID_Rol);
            entityBuilder.Property(u => u.Rol_Name).IsRequired();           
        }
    }
}

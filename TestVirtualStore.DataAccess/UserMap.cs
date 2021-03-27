using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(u => u.ID_User);
            entityBuilder.Property(u => u.User_Name).IsRequired();
            entityBuilder.Property(u => u.Password).IsRequired();
            entityBuilder.HasOne<Roles>(u => u.Roles)
                entityBuilder.WithMany(r => r.Users)
            entityBuilder.HasForeignKey(u => u.Rol);

        }
    }
}

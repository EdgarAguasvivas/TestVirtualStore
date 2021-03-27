using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(u => u.ID);
            entityBuilder.Property(u => u.User_Name).IsRequired();
            entityBuilder.Property(u => u.Password).IsRequired();
            entityBuilder.HasOne(r => r.Roles).WithMany(u => u.Users).HasForeignKey(u => u.RolFK);

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestVirtualStore.DataAccess
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.ID);
            builder.Property(u => u.User_Name).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.HasOne(r => r.Roles).WithMany(u => u.Users).HasForeignKey(u => u.Rol);
        }
    }  
}

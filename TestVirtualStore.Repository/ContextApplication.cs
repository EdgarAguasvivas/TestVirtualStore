using Microsoft.EntityFrameworkCore;
using TestVirtualStore.DataAccess;

namespace TestVirtualStore.Repository
{
    public class ContextApplication : DbContext
    {
        public ContextApplication(DbContextOptions<ContextApplication> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Product>(new ProductMap());
            modelBuilder.ApplyConfiguration<Roles>(new RolesMap());
            modelBuilder.ApplyConfiguration<Sales>(new SalesMap());
            modelBuilder.ApplyConfiguration<User>(new UserMap());           
        }
    }
}

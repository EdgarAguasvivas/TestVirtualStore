using Microsoft.EntityFrameworkCore;
using TestVirtualStore.DataAccess;

namespace TestVirtualStore.Repository
{
    public class ContextApplication : DbContext
    {
        public ApplicationContext(DbContextOptions<ContextApplication> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ProductMap(modelBuilder.Entity<Product>());
            new RolesMap(modelBuilder.Entity<Roles>());
            new SalesMap(modelBuilder.Entity<Sales>());
            new UserMap(modelBuilder.Entity<User>());
        }
    }
}

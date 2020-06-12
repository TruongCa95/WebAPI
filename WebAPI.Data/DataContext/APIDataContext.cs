using Microsoft.EntityFrameworkCore;
using WebAPI.Domain.DataContext.Configurations;

namespace WebAPI.Data.DataContext
{
    public class APIDataContext: DbContext
    {
        public APIDataContext(DbContextOptions options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
        public DbSet<User> Users { get; set; }
    }
}

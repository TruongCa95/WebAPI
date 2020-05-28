using Microsoft.EntityFrameworkCore;


namespace WebAPI.Data.DataContext
{
    public class APIDataContext: DbContext
    {
        public APIDataContext(DbContextOptions options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}

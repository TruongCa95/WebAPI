using Microsoft.EntityFrameworkCore;


namespace WebAPI.Domain.DataContext
{
    public class APIDataContext: DbContext
    {
        public APIDataContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}

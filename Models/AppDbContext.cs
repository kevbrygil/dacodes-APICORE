using Microsoft.EntityFrameworkCore;

namespace dacodes_APICORE.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<User> Users{get;set;}
    }
}
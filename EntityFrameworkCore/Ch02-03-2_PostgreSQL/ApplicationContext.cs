using Microsoft.EntityFrameworkCore;

namespace Ch02_03_1_PostgreSQL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=usersdb2;Username=postgres;Password=1");
        }
    }
}

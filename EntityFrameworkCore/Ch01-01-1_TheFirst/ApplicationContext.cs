using Microsoft.EntityFrameworkCore;

namespace Ch01_01_1_TheFirst
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        //public DbSet<User> Users { get; set; } = null!;

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=data\\helloapp.db");
        }
    }
}

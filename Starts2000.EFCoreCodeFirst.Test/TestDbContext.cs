using Microsoft.EntityFrameworkCore;
using Starts2000.EFCoreCodeFirst.Models;

namespace Starts2000.EFCoreCodeFirst.Test
{
    public class TestDbContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=TestDb;user=test;password=123456;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasIndex(u => u.Aaccount).IsUnique();
        }
    }
}

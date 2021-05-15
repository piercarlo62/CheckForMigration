using CheckForMigration.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckForMigration.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<TestModel> TestModels { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

using EfCoreMigrations.Entity;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<EfMigrationE0146> EfMigrationE0146 { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EfMigrationE0146>()
                .ToTable("EF_MIGRATION_E0146");
        }
    }
}

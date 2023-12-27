using Microsoft.EntityFrameworkCore;

namespace chi2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet for each entity you want to persist in the database

        // Add other DbSet properties for additional entities...
        public DbSet<FinancialData> Charts { get; set; }
        public DbSet<UserViewModel> UserData { get; set; }
        // You can also configure the model using the Fluent API or Data Annotations here

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add any additional configuration for your entities
            // For example:
            // modelBuilder.Entity<ErrorViewModel>().Property(e => e.SomeProperty).IsRequired();
        }
    }
}

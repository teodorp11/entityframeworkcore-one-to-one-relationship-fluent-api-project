using Microsoft.EntityFrameworkCore;
using entityframeworkcore_one_to_one_relationship_example_project.Models;

namespace entityframeworkcore_one_to_one_relationship_example_project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CarCompany> CarCompanies { get; set; }
        public DbSet<CarModel> CarModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-One Relationship Configuration using Fluent API
            modelBuilder.Entity<CarCompany>()
                .HasOne(m => m.CarModel)
                .WithOne(c => c.CarCompany)
                .HasForeignKey<CarModel>(m => m.CarCompanyID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
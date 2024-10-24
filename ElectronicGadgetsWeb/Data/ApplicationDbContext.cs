using ElectronicGadgetsWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectronicGadgetsWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Smartphones", Description = "Mobile phones with advanced features", DisplayOrder = 1 },
               new Category { Id = 2, Name = "Laptops", Description = "Portable personal computers", DisplayOrder = 2 },
               new Category { Id = 3, Name = "Tablets", Description = "Compact touchscreen devices", DisplayOrder = 3 },
               new Category { Id = 4, Name = "Smartwatches", Description = "Wearable devices with smart features", DisplayOrder = 4 },
               new Category { Id = 5, Name = "Televisions", Description = "Electronic devices for viewing multimedia content", DisplayOrder = 5 },
               new Category { Id = 6, Name = "Cameras", Description = "Devices used to capture photographs or videos", DisplayOrder = 6 },
               new Category { Id = 7, Name = "Headphones", Description = "Personal audio listening devices", DisplayOrder = 7 },
               new Category { Id = 8, Name = "Speakers", Description = "Devices that amplify sound", DisplayOrder = 8 },
               new Category { Id = 9, Name = "Gaming Consoles", Description = "Devices used to play video games", DisplayOrder = 9 },
               new Category { Id = 10, Name = "Monitors", Description = "Electronic devices for visual display", DisplayOrder = 10 }
            );
        }
    }
}

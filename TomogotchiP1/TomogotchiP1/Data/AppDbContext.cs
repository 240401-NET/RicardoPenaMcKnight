using Microsoft.EntityFrameworkCore;
using TomogotchiP1.Models; // Update with the actual namespace where your models are located

namespace TomogotchiP1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSets for your entities
        public DbSet<Pet> Pets { get; set; }
        // Add DbSets for other entities like FoodItem, Activity, etc.
    }
}

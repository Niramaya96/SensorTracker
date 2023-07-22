using Microsoft.EntityFrameworkCore;
using SensorTracker.Entities;

namespace SensorTracker.DataAcessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {  }
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Sensor> Sensors { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
        }
    }
}

using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using SensorTracker.Entities;

namespace SensorTracker.DataAcessLayer
{
    public class ApplicationDbContext : DbContext,IDbContext, IReadDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {  }
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Sensor> Sensors { get; set; } = null!;

        IQueryable<Sensor> IReadDbContext.Sensors => Sensors.AsNoTracking();

        IQueryable<Order> IReadDbContext.Orders => Orders.AsNoTracking();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
        }
    }
}

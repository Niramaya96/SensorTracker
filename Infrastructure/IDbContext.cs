using Microsoft.EntityFrameworkCore;
using SensorTracker.Entities;

namespace Infrastructure.Interfaces
{
    public interface IDbContext
    {
        DbSet<Sensor> Sensors { get; }
        DbSet<Order> Orders { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

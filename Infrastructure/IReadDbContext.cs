using SensorTracker.Entities;

namespace Infrastructure.Interfaces
{
    public interface IReadDbContext
    {
        IQueryable<Sensor> Sensors { get; }
        IQueryable<Order> Orders { get; }
    }
}

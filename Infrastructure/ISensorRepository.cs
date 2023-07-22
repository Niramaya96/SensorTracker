using SensorTracker.Entities;

namespace Infrastructure
{
    public interface ISensorRepository
    {
        Task<List<Sensor>> GetSensorsAsync();
        Task<Sensor> GetSensorByIdAsync(int id);
        Task InsertSensorAsync(Sensor sensor);
        Task UpdateSensorAsync(Sensor sensor);
        Task DeleteSensorAsync(int id);
        Task SaveChangesAsync();
    }
}

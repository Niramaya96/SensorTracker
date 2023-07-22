using Infrastructure;
using Microsoft.EntityFrameworkCore;
using SensorTracker.Entities;

namespace SensorTracker.DataAcessLayer.Repos
{
    public class SensorRepository : ISensorRepository
    {
        private readonly ApplicationDbContext _context;

        public SensorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<Sensor>> GetSensorsAsync() => _context.Sensors.ToListAsync();

        public async Task<Sensor> GetSensorByIdAsync(int id)
        {
            return await _context.Sensors.FirstOrDefaultAsync(sensor => sensor.Id == id);
        }

        public async Task InsertSensorAsync(Sensor sensor)
        {
            await _context.Sensors.AddAsync(sensor);
        }
        public async Task UpdateSensorAsync(Sensor sensor)
        {
            var sensorFromDb = await _context.Sensors.FirstOrDefaultAsync(s => s.Id == sensor.Id);

            if (sensorFromDb == null) return;
            
            sensorFromDb.Name = sensor.Name;
            sensorFromDb.Price = sensor.Price;
            sensorFromDb.Description = sensor.Description;
        }
        public async Task DeleteSensorAsync(int id)
        {
            var sensorFromDb = await _context.Sensors.FirstOrDefaultAsync(s => s.Id == id);
            if (sensorFromDb == null) return;

            _context.Remove(sensorFromDb);

        }
        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

    }
}


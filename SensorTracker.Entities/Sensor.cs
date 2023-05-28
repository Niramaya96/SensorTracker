
namespace SensorTracker.Entities
{
    public class Sensor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public string? Description { get; set; }
    }
}

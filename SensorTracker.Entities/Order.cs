namespace SensorTracker.Entities
{
    public class Order
    {
        public string? OrderNumber { get; set; } 
        public int? SensorId { get; set; }
        public Sensor? Sensor { get; set; }
        public int Count { get; set; }
        public string? Description { get; set; }

    }
}

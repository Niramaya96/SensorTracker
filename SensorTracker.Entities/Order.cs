namespace SensorTracker.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Sensor? Sensor { get; set; }
        public string? OrderNumber { get; set; } 
        public int Count { get; set; }
        public string? Description { get; set; }

    }
}

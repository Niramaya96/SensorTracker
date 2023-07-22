using Microsoft.EntityFrameworkCore;
using SensorTracker.Entities;

namespace SensorTracker.DataAcessLayer
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Sensor>().HasData(
                new Sensor { Id = 1, Name = "K1", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 2, Name = "К1У", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 3, Name = "K2", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 4, Name = "K2.1", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 5, Name = "K3", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 6, Name = "K4", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 7, Name = "K5", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 8, Name = "К1И", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 9, Name = "Кл1-1", Price = 52, Description = "С клеемной головкой" },
                new Sensor { Id = 10, Name = "Кл1-2", Price = 52, Description = "С клеемной головкой" },
                new Sensor { Id = 11, Name = "Кл1-3", Price = 52, Description = "С клеемной головкой" },
                new Sensor { Id = 12, Name = "Кл4-1", Price = 52, Description = "С клеемной головкой" },
                new Sensor { Id = 13, Name = "Кл2-2", Price = 58, Description = "С клеемной головкой" },
                new Sensor { Id = 14, Name = "Кл3-1", Price = 48, Description = "С клеемной головкой" },
                new Sensor { Id = 15, Name = "Кл1-3", Price = 52, Description = "С клеемной головкой" },
                new Sensor { Id = 17, Name = "Рт-3", Price = 52, Description = "Другие" },
                new Sensor { Id = 18, Name = "Рт-4", Price = 52, Description = "Другие" },
                new Sensor { Id = 19, Name = "Рт-5", Price = 52, Description = "Другие" },
                new Sensor { Id = 20, Name = "It-7", Price = 37, Description = "Другие" });

        }
    }
}

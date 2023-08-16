using Microsoft.EntityFrameworkCore;
using SensorTracker.Entities;

namespace SensorTracker.DataAcessLayer
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Sensor>().HasData(
                new Sensor { Name = "K1", Price = 52, Description = "С засыпкой" },
                new Sensor { Name = "К1У", Price = 52, Description = "С засыпкой" },
                new Sensor { Name = "K2", Price = 52, Description = "С засыпкой" },
                new Sensor { Name = "K2.1", Price = 52, Description = "С засыпкой" },
                new Sensor { Name = "K3", Price = 52, Description = "С засыпкой" },
                new Sensor { Name = "K4", Price = 52, Description = "С засыпкой" },
                new Sensor { Name = "K5", Price = 52, Description = "С засыпкой" },
                new Sensor { Name = "К1И", Price = 52, Description = "С засыпкой" },
                new Sensor { Name = "Кл1-1", Price = 52, Description = "С клеемной головкой" },
                new Sensor { Name = "Кл1-2", Price = 52, Description = "С клеемной головкой" },
                new Sensor { Name = "Кл1-3", Price = 52, Description = "С клеемной головкой" },
                new Sensor { Name = "Кл4-1", Price = 52, Description = "С клеемной головкой" },
                new Sensor { Name = "Кл2-2", Price = 58, Description = "С клеемной головкой" },
                new Sensor { Name = "Кл3-1", Price = 48, Description = "С клеемной головкой" },
                new Sensor { Name = "Кл1-3", Price = 52, Description = "С клеемной головкой" },
                new Sensor { Name = "Рт-3", Price = 52, Description = "Другие" },
                new Sensor { Name = "Рт-4", Price = 52, Description = "Другие" },
                new Sensor { Name = "Рт-5", Price = 52, Description = "Другие" },
                new Sensor { Name = "It-7", Price = 37, Description = "Другие" });

        }
    }
}

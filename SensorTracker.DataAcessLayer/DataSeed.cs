using Microsoft.EntityFrameworkCore;
using SensorTracker.Entities;

namespace SensorTracker.DataAcessLayer
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Sensor>().HasData(
                new Sensor { Id = 1, Name = "K1", Price = 52,Description="С засыпкой" },
                new Sensor { Id = 2, Name = "К1У", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 3, Name = "K2", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 4, Name = "K2-KP", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 5, Name = "K2.1", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 6, Name = "K2T", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 7, Name = "К2Ф", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 9, Name = "K3", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 10, Name = "K4", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 11, Name = "K4P", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 12, Name = "K4.1", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 13, Name = "K5", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 14, Name = "К1И", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 15, Name = "ТКЖ", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 16, Name = "IT-8 RUT", Price = 52, Description = "С засыпкой" },
                new Sensor { Id = 17, Name = "K1", Price = 37},
                new Sensor { Id = 18, Name = "K2", Price = 37},
                new Sensor { Id = 19, Name = "K2.1", Price = 37},
                new Sensor { Id = 20, Name = "K3", Price = 37},
                new Sensor { Id = 21, Name = "K4", Price = 37},
                new Sensor { Id = 22, Name = "K5", Price = 37},
                new Sensor { Id = 23, Name = "K2Ф", Price = 37},
                new Sensor { Id = 24, Name = "K2М", Price = 37},
                new Sensor { Id = 25, Name = "K0", Price = 45},
                new Sensor { Id = 26, Name = "K9", Price = 58},
                new Sensor { Id = 27, Name = "K10", Price = 45},
                new Sensor { Id = 28, Name = "K1И-КП", Price = 52},
                new Sensor { Id = 29, Name = "", Price = 52 });


        }
    }
}

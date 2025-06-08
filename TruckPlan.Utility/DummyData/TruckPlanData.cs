using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckPlan.Utility.Models;

namespace TruckPlan.Utility.DummyData
{
    public static class TruckPlanData
    {
       public static List<TruckPlanModel> truckPlans = new List<TruckPlanModel>
        {
            new TruckPlanModel
            {
                Id = 1,
                StartTime = new DateTime(2025, 6, 10, 8, 0, 0),
                EndTime = new DateTime(2025, 6, 10, 16, 0, 0),
                StartPoint = new TruckPoint { Latitude = 40.7128, Longitude = -74.0060 },
                EndPoint = new TruckPoint { Latitude = 42.3601, Longitude = -71.0589 },
                CurrentPoint = new TruckPoint { Latitude = 41.7658, Longitude = -72.6734 },
                DistanceCoveredKm = 200, 
                Driver = new Driver { Name = "John Doe", DateOfBirth = new DateTime(1985, 7, 14) },
                Truck = new Truck { TruckNumber = "TX1234"}
            },
            new TruckPlanModel
            {
                Id = 2,
                StartTime = new DateTime(2025, 6, 12, 7, 30, 0),
                EndTime = new DateTime(2025, 6, 12, 14, 30, 0),
                StartPoint = new TruckPoint { Latitude = 41.8781, Longitude = -87.6298 },
                EndPoint = new TruckPoint { Latitude = 42.3314, Longitude = -83.0458 },
                CurrentPoint = new TruckPoint { Latitude = 42.2917, Longitude = -85.5872 },
                DistanceCoveredKm = 150,                
                Driver = new Driver { Name = "Sarah Johnson", DateOfBirth = new DateTime(1990, 3, 22) },
                Truck = new Truck { TruckNumber = "TX5678" }
            },
            new TruckPlanModel
            {
                Id = 3,
                StartTime = new DateTime(2025, 6, 15, 6, 0, 0),
                EndTime = new DateTime(2025, 6, 15, 14, 0, 0),
                StartPoint = new TruckPoint { Latitude = 34.0522, Longitude = -118.2437 },
                EndPoint = new TruckPoint { Latitude = 37.7749, Longitude = -122.4194 },
                CurrentPoint = new TruckPoint { Latitude = 35.3733, Longitude = -119.0187 },
                DistanceCoveredKm = 170,
                Driver = new Driver { Name = "Michael Smith", DateOfBirth = new DateTime(1978, 11, 5) },
                Truck = new Truck { TruckNumber = "TX9101"}
            },
            new TruckPlanModel
            {
                Id = 4,
                StartTime = new DateTime(2025, 6, 18, 9, 0, 0),
                EndTime = new DateTime(2025, 6, 18, 17, 0, 0),
                StartPoint = new TruckPoint { Latitude = 32.7767, Longitude = -96.7970 },
                EndPoint = new TruckPoint { Latitude = 29.7604, Longitude = -95.3698 },
                CurrentPoint = new TruckPoint { Latitude = 31.5493, Longitude = -97.1467 },
                DistanceCoveredKm = 130,
                Driver = new Driver { Name = "Emily Davis", DateOfBirth = new DateTime(1995, 9, 30) },
                Truck = new Truck { TruckNumber = "TX1122" }
            },
            new TruckPlanModel
            {
                Id = 5,
                StartTime = new DateTime(2025, 6, 20, 7, 45, 0),
                EndTime = new DateTime(2025, 6, 20, 15, 30, 0),
                StartPoint = new TruckPoint { Latitude = 25.7617, Longitude = -80.1918 },
                EndPoint = new TruckPoint { Latitude = 28.5383, Longitude = -81.3792 },
                CurrentPoint = new TruckPoint { Latitude = 26.7153, Longitude = -80.0534 },
                DistanceCoveredKm = 110,
                Driver = new Driver { Name = "David Martinez", DateOfBirth = new DateTime(1982, 6, 17) },
                Truck = new Truck { TruckNumber = "TX3344" }
            },
            new TruckPlanModel
            {
                Id = 6,
                StartTime = new DateTime(2025, 6, 22, 6, 30, 0),
                EndTime = new DateTime(2025, 6, 22, 14, 30, 0),
                StartPoint = new TruckPoint { Latitude = 47.6062, Longitude = -122.3321 },
                EndPoint = new TruckPoint { Latitude = 45.5051, Longitude = -122.6750 },
                CurrentPoint = new TruckPoint { Latitude = 45.6387, Longitude = -122.6615 },
                DistanceCoveredKm = 150,
                Driver = new Driver { Name = "Jessica Lee", DateOfBirth = new DateTime(1988, 12, 2) },
                Truck = new Truck { TruckNumber = "TX5566" }
            },
            new TruckPlanModel
            {
                Id = 7,
                StartTime = new DateTime(2025, 6, 24, 8, 0, 0),
                EndTime = new DateTime(2025, 6, 24, 16, 0, 0),
                StartPoint = new TruckPoint { Latitude = 33.7490, Longitude = -84.3880 },
                EndPoint = new TruckPoint { Latitude = 35.2271, Longitude = -80.8431 },
                CurrentPoint = new TruckPoint { Latitude = 34.8526, Longitude = -82.3940 },
                DistanceCoveredKm = 180,  Driver = new Driver { Name = "Robert Brown", DateOfBirth = new DateTime(1975, 1, 20) },
                Truck = new Truck { TruckNumber = "TX7788" }
            },
            new TruckPlanModel
            {
                Id = 8,
                StartTime = new DateTime(2025, 6, 26, 7, 0, 0),
                EndTime = new DateTime(2025, 6, 26, 15, 0, 0),
                StartPoint = new TruckPoint { Latitude = 39.7392, Longitude = -104.9903 },
                EndPoint = new TruckPoint { Latitude = 40.7608, Longitude = -111.8910 },
                CurrentPoint = new TruckPoint { Latitude = 39.0639, Longitude = -108.5506 },
                DistanceCoveredKm = 220, Driver = new Driver { Name = "Amanda Wilson", DateOfBirth = new DateTime(1992, 5, 11) },
                Truck = new Truck { TruckNumber = "TX9900" }
            },
            new TruckPlanModel
            {
                Id = 9,
                StartTime = new DateTime(2025, 6, 28, 6, 45, 0),
                EndTime = new DateTime(2025, 6, 28, 14, 45, 0),
                StartPoint = new TruckPoint { Latitude = 33.4484, Longitude = -112.0740 },
                EndPoint = new TruckPoint { Latitude = 36.1699, Longitude = -115.1398 },
                CurrentPoint = new TruckPoint { Latitude = 35.1894, Longitude = -113.9811 },
                Driver = new Driver { Name = "James Taylor", DateOfBirth = new DateTime(1980, 8, 28) },
                Truck = new Truck { TruckNumber = "TX1123" }
            },
            new TruckPlanModel
            {
                Id = 10,
                StartTime = new DateTime(2025, 6, 30, 9, 0, 0),
                EndTime = new DateTime(2025, 6, 30, 17, 0, 0),
                StartPoint = new TruckPoint { Latitude = 39.9526, Longitude = -75.1652 },
                EndPoint = new TruckPoint { Latitude = 38.9072, Longitude = -77.0369 },
                CurrentPoint = new TruckPoint { Latitude = 39.2904, Longitude = -76.6122 },
                DistanceCoveredKm = 160,
               
                Driver = new Driver { Name = "Laura Clark", DateOfBirth = new DateTime(1987, 4, 16) },
                Truck = new Truck { TruckNumber = "TX4455" }
            }
        };

    }
}

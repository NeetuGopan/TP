using TruckPlan.Utility.Models;

namespace TruckPlan.Utility
{
    public static class CalculateDistance
    {
        private const double EarthRadiusKm = 6371.0;

        public static double CalculateTotalDistance(TruckPoint positionA, TruckPoint positionB)
        {
            double total = 0;
            
                total += HaversineDistance(positionA, positionB);
           
            return total;
        }

        private static double HaversineDistance(TruckPoint wp1, TruckPoint wp2)
        {
            double dLat = DegreesToRadians(wp2.Latitude - wp1.Latitude);
            double dLon = DegreesToRadians(wp2.Longitude - wp1.Longitude);

            double lat1 = DegreesToRadians(wp1.Latitude);
            double lat2 = DegreesToRadians(wp2.Latitude);

            double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Pow(Math.Sin(dLon / 2), 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return EarthRadiusKm * c;
        }

        private static double DegreesToRadians(double degrees) => degrees * Math.PI / 180;
    }
}

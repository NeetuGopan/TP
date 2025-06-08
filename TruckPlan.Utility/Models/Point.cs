namespace TruckPlan.Utility.Models
{
    public struct TruckPoint
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public TruckPoint(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}

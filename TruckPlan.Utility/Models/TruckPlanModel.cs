namespace TruckPlan.Utility.Models
{
    public class TruckPlanModel
    {
        public int Id { get; set; }        
        public Driver Driver { get; set; } = null!;
        public Truck Truck { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TruckPoint StartPoint { get; set; }
        public TruckPoint EndPoint { get; set; }
        public TruckPoint CurrentPoint { get; set; }
        public double DistanceCoveredKm {  get; set; }
        
    }
}

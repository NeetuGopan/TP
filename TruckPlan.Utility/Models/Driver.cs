namespace TruckPlan.Utility.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public int Age(DateTime date) =>
       date.Year - DateOfBirth.Year - (date < DateOfBirth.AddYears(date.Year - DateOfBirth.Year) ? 1 : 0);
    }
}

using Microsoft.AspNetCore.Mvc;

namespace TruckPlan.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TruckPlanApiController : Controller
    {
        private readonly ILogger<TruckPlanApiController> _logger;


        public TruckPlanApiController(ILogger<TruckPlanApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetCountry")]        
        public async Task<string> GetCountry(string latitude, string longitude)
        {
            TruckCalculations tc = new TruckCalculations();
            var data = await tc.GetCountryFromCordinates(latitude, longitude);
            return data ?? "Unknown";

        }


        [HttpGet("GetDistance")]
        public double? GetDistance(int id)
        {
            TruckCalculations tc = new TruckCalculations();

            double? distance = tc.GetDistanceofTruckPlan(id);
            return distance;
        }

        [HttpGet("GetDistanceDrivenByDrivers")]
        public  double? GetDistanceDrivenByDrivers(int age)
        {
            TruckCalculations tc = new TruckCalculations();

            double? distance =  tc.CalculateDriverDistanceByAge(age);
            return distance;

        }

    }
}

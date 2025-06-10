using Microsoft.AspNetCore.Identity;
using System.Numerics;
using TruckPlan.Utility.DummyData;
using TruckPlan.Utility;
using Newtonsoft.Json;
using System.Net.Http;

namespace TruckPlan.Api
{
    public class TruckCalculations
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public double? GetDistanceofTruckPlan(int truckplanId)
        {
            var plan = TruckPlanData.truckPlans.FirstOrDefault(p => p.Id == truckplanId);
            double? distance = plan?.DistanceCoveredKm;
            return distance;
        }

        public async Task<string> GetCountryFromCordinates(string latitude, string longitude)
        {
            var url = $"https://nominatim.openstreetmap.org/reverse?format=jsonv2&lat={latitude}&lon={longitude}";
            _httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            _httpClient.DefaultRequestHeaders.Add("Referer", "http://www.microsoft.com");
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            dynamic? data = JsonConvert.DeserializeObject(json);
            return data?.address.country?.ToString()?? string.Empty;
        }

        public  double? CalculateDriverDistanceByAge(int age)
        {
            double totalDistance = 0;
            var plans = TruckPlanData.truckPlans.Select(i=>i).ToList();
            foreach (var plan in plans)
            {
                if (plan.Driver.Age(plan.StartTime) > 50) continue;
                var pointA = plan.StartPoint;
                var pointB = plan.EndPoint;

                var midLat = (pointA.Latitude + pointB.Latitude) / 2;
                var midLon = (pointA.Longitude + pointB.Longitude) / 2;


                // --Commented this because continously calling the external webservice giving 403 forbidden error, need an upgraded version

                //string country = await GetCountryFromCordinates(Convert.ToString(midLat), Convert.ToString(midLon));
                //if (country == "Germany")
                //{
                    totalDistance += CalculateDistance.CalculateTotalDistance(pointA, pointB);
                //}
            }
                return totalDistance;

        }
    }
}


namespace WeatherCareAPI.Helpers
{
    public class Utilities
    {
        public static string errorMsg(string type, string cityName)
        {
            if (type == "cityNotFound")
                return $"City name \"{cityName}\" doesn't exist in our database, please use geolocation instead.";
            else
                return "Incorrect geolocation, please input -90 to +90 for latitude, and -180 to +180 for longitude.";
        }
    }
}

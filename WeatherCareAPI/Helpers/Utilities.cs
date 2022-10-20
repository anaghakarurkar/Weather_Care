
namespace WeatherCareAPI.Helpers
{
    public class Utilities
    {
        public static string errorMsg(string cityName)
        {
            return $"City name \"{cityName}\" doesn't exist in our database, please use geolocation instead.";
        }
    }
}


namespace WeatherCareAPI.Helpers
{
    public class Utilities
    {
        public static string errorMsg(int type, string cityName)
        {
            if (type == 1)
                return $"City name \"{cityName}\" doesn't exist in our database, please use geolocation instead.";
            else
                return "Incorrect geolocation, please input -90 to +90 for latitude, and -180 to +180 for longitude.";
        }
    }
}

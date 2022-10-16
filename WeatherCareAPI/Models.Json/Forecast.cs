namespace WeatherCareAPI.Models.Json
{
    public class Forecast : IForecast
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}

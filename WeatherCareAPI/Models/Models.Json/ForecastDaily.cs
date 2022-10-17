namespace WeatherCareAPI.Models.Json
{
    public class ForecastDaily : Forecast
    {
        public daily_units daily_units { get; set; }
        public daily daily { get; set; }
    }
}

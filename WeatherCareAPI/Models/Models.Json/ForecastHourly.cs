namespace WeatherCareAPI.Models.Json
{
    public class ForecastHourly : Forecast
    {
        public hourly hourly { get; set; }
        public hourly_units hourly_units { get; set; }
    }
}

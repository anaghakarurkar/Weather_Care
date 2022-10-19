using Microsoft.AspNetCore.Mvc;
using WeatherCareAPI.Models;
using WeatherCareAPI.Services;
using WeatherCareAPI.Models.Json;
using WeatherCareAPI.Models.Display;
using WeatherCareAPI.Helpers;
using Microsoft.Extensions.Logging.Abstractions;

namespace WeatherCareAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherCareController : ControllerBase
    {
        private readonly ILogger<WeatherCareController> _logger;
        private readonly IWeatherCareService _weatherCareService;

        public WeatherCareController(ILogger<WeatherCareController> logger, IWeatherCareService weatherCareService)
        {
            _logger = logger;
            _weatherCareService = weatherCareService;
        }

        //  /WeatherForecast/daily/Mumbai
        [HttpGet("daily/{cityName}")]
        public ActionResult<IEnumerable<ForecastDaily>> GetDailyForecastByCity(string cityName)
        {
            Forecast location = _weatherCareService.GetLocationByCity(cityName);
            var foreCastDaily = ImportFromApi.ImportForecastDaily($"https://api.open-meteo.com/v1/forecast?latitude={location.latitude}&longitude={location.longitude}&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum").GetAwaiter().GetResult();
            return Ok(foreCastDaily);
        }
        [HttpGet("dailyAdvice/{cityName}")]
        public ActionResult<IEnumerable<DisplayClothingAdviceDaily>> GetDailyAdviceByCity(string cityName)
        {
            Forecast location = _weatherCareService.GetLocationByCity(cityName);
            var foreCastDaily = ImportFromApi.ImportForecastDaily($"https://api.open-meteo.com/v1/forecast?latitude={location.latitude}&longitude={location.longitude}&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum").GetAwaiter().GetResult();
            var displayClothingAdviceDaily = _weatherCareService.GetClothingAdviceDaily(foreCastDaily);
            return Ok(displayClothingAdviceDaily);
        }

        //  /WeatherForecast/hourly/{cityName}
        [HttpGet("hourly/{cityName}")]
        public ActionResult<IEnumerable<ForecastHourly>> GetHourlyForecastByCity(string cityName)
        {
            Forecast location = _weatherCareService.GetLocationByCity(cityName);
            var foreCastHourly = ImportFromApi.ImportForecastHourly($"https://api.open-meteo.com/v1/forecast?latitude={location.latitude}&longitude={location.longitude}&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m").GetAwaiter().GetResult();
            return Ok(foreCastHourly);
        }
        [HttpGet("hourlyAdvice/{cityName}")]
        public ActionResult<IEnumerable<DisplayClothingAdviceDaily>> GetHourlyAdviceByCity(string cityName)
        {
            Forecast location = _weatherCareService.GetLocationByCity(cityName);
            var foreCastHourly = ImportFromApi.ImportForecastHourly($"https://api.open-meteo.com/v1/forecast?latitude={location.latitude}&longitude={location.longitude}&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m").GetAwaiter().GetResult();
            var displayClothingAdviceHourly = _weatherCareService.GetClothingAdviceHourly(foreCastHourly);
            return Ok(displayClothingAdviceHourly);
        }

        //  /WeatherForecast/daily/geolocation?latitude=52.52&longitude=14.43
        [HttpGet("daily/geolocation")]
        public ActionResult<IEnumerable<DisplayClothingAdviceDaily>> SuggestDailyClothingUsingGeoLocation(double latitude, double longitude)
        {
            var foreCastDaily = ImportFromApi.ImportForecastDaily($"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum").GetAwaiter().GetResult();
            var displayClothingAdviceDaily = _weatherCareService.GetClothingAdviceDaily(foreCastDaily);
            return Ok(displayClothingAdviceDaily);

        }


        //  /WeatherForecast/hourly/geolocation?latitude=52.52&longitude=14.43
        [HttpGet("hourly/geolocation")]
        public ActionResult<IEnumerable<DisplayClothingAdviceHourly>> SuggestHourlyClothingUsingGeoLocation(double latitude, double longitude)
        {
            var foreCastHourly = ImportFromApi.ImportForecastHourly($"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m").GetAwaiter().GetResult();
            var displayClothingAdviceHourly = _weatherCareService.GetClothingAdviceHourly(foreCastHourly);
            return Ok(displayClothingAdviceHourly);

        }


        [HttpGet("DB")]
        public ActionResult<IEnumerable<City>> GetCities()
        {
            return _weatherCareService.GetAllCities();
        }
    }
}
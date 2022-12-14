using Microsoft.AspNetCore.Mvc;
using WeatherCareAPI.Models;
using WeatherCareAPI.Services;
using WeatherCareAPI.Models.Json;
using WeatherCareAPI.Models.Display;
using WeatherCareAPI.Helpers;
using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using Newtonsoft.Json.Linq;

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

       
        [HttpGet("dailyAdvice/{cityName}")]
        public ActionResult<IEnumerable<DisplayClothingAdviceDaily>> GetDailyAdviceByCity(string cityName)
        {
            Forecast location = _weatherCareService.GetLocationByCity(cityName);
            if (location == null) return BadRequest(Utilities.errorMsg("cityNotFound", cityName));
            var foreCastDaily = ImportFromApi.ImportForecastDaily($"https://api.open-meteo.com/v1/forecast?latitude={location.latitude}&longitude={location.longitude}&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum").GetAwaiter().GetResult();
            var displayClothingAdviceDaily = _weatherCareService.GetClothingAdviceDaily(foreCastDaily);
            return Ok(displayClothingAdviceDaily);
        }

        
        [HttpGet("hourlyAdvice/{cityName}")]
        public ActionResult<IEnumerable<DisplayClothingAdviceDaily>> GetHourlyAdviceByCity(string cityName)
        {
            Forecast location = _weatherCareService.GetLocationByCity(cityName);
            if (location == null) return BadRequest(Utilities.errorMsg("cityNotFound", cityName));
            var foreCastHourly = ImportFromApi.ImportForecastHourly($"https://api.open-meteo.com/v1/forecast?latitude={location.latitude}&longitude={location.longitude}&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m").GetAwaiter().GetResult();
            var displayClothingAdviceHourly = _weatherCareService.GetClothingAdviceHourly(foreCastHourly);
            return Ok(displayClothingAdviceHourly);
        }

        //  /WeatherForecast/daily/geolocation?latitude=52.52&longitude=14.43
        [HttpGet("dailyAdvice/geolocation")]
        public ActionResult<IEnumerable<DisplayClothingAdviceDaily>> SuggestDailyClothingUsingGeoLocation(double latitude, double longitude)
        {
            if (_weatherCareService.ValidateLongitudeLatitude(latitude, longitude)) return BadRequest(Utilities.errorMsg("invalidGeolocation",""));
            var foreCastDaily = ImportFromApi.ImportForecastDaily($"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum").GetAwaiter().GetResult();
            var displayClothingAdviceDaily = _weatherCareService.GetClothingAdviceDaily(foreCastDaily);
            return Ok(displayClothingAdviceDaily);

        }


        //  /WeatherForecast/hourly/geolocation?latitude=52.52&longitude=14.43
        [HttpGet("hourlyAdvice/geolocation")]
        public ActionResult<IEnumerable<DisplayClothingAdviceHourly>> SuggestHourlyClothingUsingGeoLocation(double latitude, double longitude)
        {
            if (_weatherCareService.ValidateLongitudeLatitude(latitude, longitude)) return BadRequest(Utilities.errorMsg("invalidGeolocation", ""));
            var foreCastHourly = ImportFromApi.ImportForecastHourly($"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m").GetAwaiter().GetResult();
            var displayClothingAdviceHourly = _weatherCareService.GetClothingAdviceHourly(foreCastHourly);
            return Ok(displayClothingAdviceHourly);

        }

        [HttpGet("currentAdvice/{cityName}")]
        public ActionResult<IEnumerable<DisplayClothingAdviceHourly>> GetCurrentAdviceByCity(string cityName)
        {
            Forecast location = _weatherCareService.GetLocationByCity(cityName);
            if (location == null) return BadRequest(Utilities.errorMsg("cityNotFound", cityName));
            var foreCastHourly = ImportFromApi.ImportForecastHourly($"https://api.open-meteo.com/v1/forecast?latitude={location.latitude}&longitude={location.longitude}&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m").GetAwaiter().GetResult();
            var displayClothingAdviceCurrent = _weatherCareService.GetClothingAdviceCurrentHour(foreCastHourly);
            return Ok(displayClothingAdviceCurrent);
        }

        [HttpGet("currentAdvice/geolocation")]
        public ActionResult<IEnumerable<DisplayClothingAdviceHourly>> GetCurrentAdviceByGeolocation(double latitude, double longitude)
        {
            if (_weatherCareService.ValidateLongitudeLatitude(latitude, longitude)) return BadRequest(Utilities.errorMsg("invalidGeolocation", ""));
            var foreCastHourly = ImportFromApi.ImportForecastHourly($"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m").GetAwaiter().GetResult();
            var displayClothingAdviceCurrent = _weatherCareService.GetClothingAdviceCurrentHour(foreCastHourly);
            return Ok(displayClothingAdviceCurrent);
        }

    }
}
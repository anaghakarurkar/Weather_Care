namespace WeatherCareAPI.Models
{
    public class City
    {
        public int Id { get; set; }
        public string EnglishName { get; set; }
        public string TimeZoneCode { get; set; }
        public float GeoPositionLatitude { get; set; }
        public float GeoPositionLongitude { get; set; }
    }
}

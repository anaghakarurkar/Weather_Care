namespace WeatherCareAPI.Models.Json
{
    public class daily
    {
        public DateTime[] time { get; set; }
        public float[] windspeed_10m { get; set; }
        public float[] temperature_2m_max { get; set; }
        public float[] temperature_2m_min { get; set; }
        public float[] windspeed_10m_max { get; set; } //km/h
        public float[] precipitation_sum { get; set; } //mm
        public int[] weathercode { get; set; }
    }
}

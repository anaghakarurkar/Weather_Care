namespace WeatherCareAPI.Models.Json
{
    public class hourly
    {
        public DateTime[] time { get; set; }
        public float[] windspeed_10m { get; set; }
        public float[] temperature_2m { get; set; }
        public float[] relativehumidity_2m { get; set; }
        public int[] weathercode { get; set; }
    }
}

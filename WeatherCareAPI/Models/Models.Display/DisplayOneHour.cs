namespace WeatherCareAPI.Models.Display
{
    public class DisplayOneHour : DisplayOneItem
    {
        public string Time { get; set; }
        public DisplayOneHour(DateTime time, double temperature, string weatherType, List<string> suggestedClothes) : base(temperature, weatherType, suggestedClothes)
        {
            Time = time.ToString("HH:mm");
        }
    }
}

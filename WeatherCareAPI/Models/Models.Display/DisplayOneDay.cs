namespace WeatherCareAPI.Models.Display
{
    public class DisplayOneDay
    {
        public string Date { get; set; }
        public double AverageTemperature { get; set; }
        public string WeatherType { get; set;  }
        public List<string> SuggestedClothes { get; set; }
        public DisplayOneDay(DateTime date, double averageTemperature, string weatherType, List<string> suggestedClothes)
        {
            Date = date.ToString("MM/dd/yyyy");
            AverageTemperature = Math.Round(averageTemperature,2);
            WeatherType = weatherType;
            SuggestedClothes = suggestedClothes;
        }
    }
}

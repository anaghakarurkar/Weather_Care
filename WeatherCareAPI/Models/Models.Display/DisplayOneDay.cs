namespace WeatherCareAPI.Models.Display
{
    public class DisplayOneDay
    {
        public DateTime Date { get; set; }
        public double AverageTemperature { get; set; }
        public string WeatherType { get; set;  }
        public string SuggestedClothes { get; set; }
        public string Advice { get; set; }
        public DisplayOneDay(DateTime date, double averageTemperature, string weatherType, string suggestedClothes, string advice)
        {
            Date = date;
            AverageTemperature = averageTemperature;
            WeatherType = weatherType;
            SuggestedClothes = suggestedClothes;
            Advice = advice;
        }
    }
}

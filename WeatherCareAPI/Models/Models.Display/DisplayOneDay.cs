namespace WeatherCareAPI.Models.Display
{
    public class DisplayOneDay
    {
        public string Date { get; set; }//DateTime Date { get; set; }
        public string AverageTemperature { get; set; } //double AverageTemperature { get; set; }
        public string WeatherType { get; set;  }
        public string SuggestedClothes { get; set; }
        public string Advice { get; set; }
        public DisplayOneDay(DateTime date, double averageTemperature, string weatherType, string suggestedClothes, string advice)
        {
            Date = date.ToString("MM/dd/yyyy");
            AverageTemperature = averageTemperature.ToString("0.00");
            WeatherType = weatherType;
            SuggestedClothes = suggestedClothes;
            Advice = advice;
        }
    }
}

namespace WeatherCareAPI.Models.Display
{
    public class DisplayOneItem
    {
        //public string Date { get; set; }
        public double Temperature { get; set; }
        public string WeatherType { get; set;  }
        public List<string> SuggestedClothes { get; set; }
        public DisplayOneItem(double temperature, string weatherType, List<string> suggestedClothes)
        {
            //Date = date.ToString("MM/dd/yyyy");
            Temperature = Math.Round(temperature,2);
            WeatherType = weatherType;
            SuggestedClothes = suggestedClothes;
        }
    }
}

namespace WeatherCareAPI.Models.Display
{
    public class DisplayOneDay : DisplayOneItem
    {
        public string Date { get; set; }
        public DisplayOneDay(DateTime date, double temperature, string weatherType, List<string> suggestedClothes) : base(temperature, weatherType, suggestedClothes)
        {
            Date = date.ToString("MM/dd/yyyy");

        }
    }
}

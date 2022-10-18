namespace WeatherCareAPI.Models.Display
{
    public class DisplayClothingAdviceDaily
    {
        public List<DisplayOneDay> DisplayOneDayList { get; set; }
        public DisplayClothingAdviceDaily()
        {
            DisplayOneDayList = new List<DisplayOneDay>();
        }
    }
}

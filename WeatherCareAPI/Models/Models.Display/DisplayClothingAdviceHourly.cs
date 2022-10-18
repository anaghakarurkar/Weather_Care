namespace WeatherCareAPI.Models.Display
{
    public class DisplayClothingAdviceHourly
    {
        public string Date;
        public List<DisplayOneHour> DisplayOneHourList { get; set; }
        public DisplayClothingAdviceHourly()
        {
            Date = DateTime.Now.ToString("MM/dd/yyyy");
            DisplayOneHourList = new List<DisplayOneHour>();
        }
    }
}

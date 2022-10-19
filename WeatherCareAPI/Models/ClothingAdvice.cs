using System;
using WeatherCareAPI.Models.Json;

namespace WeatherCareAPI.Models
{
    public class ClothingAdvice
    {

        // List of clothing 
        public List<Clothing> clothingSuggestions = new List<Clothing>()
        {
            new Clothing("Cold","Beanie"),
            new Clothing("Cold","Sweater"),
            new Clothing("Cold","Fleece jacket"),
            new Clothing("Cold","Mittens"),
            new Clothing("Cold","Scarf"),
            new Clothing("Cold","Cardigan"),
            new Clothing("Cold","Earmuffs"),
            new Clothing("Cold","Winter Jacket"),
            new Clothing("Cold","Long-sleeve top"),
            new Clothing("Hot","Vest"),
            new Clothing("Hot","Shorts"),
            new Clothing("Hot","Polo"),
            new Clothing("Hot","T-shirt"),
            new Clothing("Hot","Slippers"),
            new Clothing("Hot","Cap"),
            new Clothing("Wet","Raincoat"),
            new Clothing("Wet","Umbrella"),
            new Clothing("V.Wet","Umbrella"),
            new Clothing("V.Wet","Heavy RainCoat"),
            new Clothing("V.Wet","Wellingtons"),
            new Clothing("Windy","Windbreaker"),
            new Clothing("Mild","Jumper"),
            new Clothing("Mild","Fleece"),
            new Clothing("Mild","Long Sleeve Top"),
            new Clothing("Mild","Light Trousers")


          };
       public List<string> dailyClothingType = new List<string>();
       public List<string> hourlyClothingType = new List<string>();

        public ClothingAdvice()
        {
        }

        public void SetDailyClothingType(ForecastDaily dailyForecast)
        {


            for (int i = 0; i < dailyForecast.daily.weathercode.Count(); i++)

            {
                

                switch (dailyForecast.daily.weathercode[i])
                {
                    
                    case 0:
                        if ((dailyForecast.daily.temperature_2m_max[i]+ dailyForecast.daily.temperature_2m_min[i])/2 > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if (dailyForecast.daily.temperature_2m_max[i] > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");

                        break;
                    case 1:
                        if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;
                    case 2:
                        if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;
                    case 3:
                        if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i])/2 > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;
                    case 45:
                        if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i])/2 > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i])/2 > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;
                    case 48:
                        if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i])/2 > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;
                    case 51:
                        dailyClothingType.Add("Wet");
                        break;
                    case 53:
                        dailyClothingType.Add("Wet");
                        break;
                    case 55:
                        dailyClothingType.Add("Wet");
                        break;
                    case 57:
                        dailyClothingType.Add("Wet");
                        break;
                    case 61:
                        dailyClothingType.Add("Wet");
                        break;
                    case 63:
                        dailyClothingType.Add("V.Wet");
                        break;
                    case 65:
                        dailyClothingType.Add("V.Wet");
                        break;
                    case 66:
                        dailyClothingType.Add("V.Wet");
                        break;
                    case 67:
                        dailyClothingType.Add("V.Wet");
                        break;
                    case 71:
                        dailyClothingType.Add("Cold");
                        break;
                    case 73:
                        dailyClothingType.Add("Cold");
                        break;
                    case 77:
                        dailyClothingType.Add("Cold");
                        break;
                    case 80:
                        dailyClothingType.Add("V.Wet");
                        break;
                    case 82:
                        dailyClothingType.Add("V.Wet");
                        break;
                    case 85:
                        dailyClothingType.Add("Cold");
                        break;
                    case 86:
                        dailyClothingType.Add("Cold");
                        break;
                    case 95:
                        if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;
                    case 96:
                        if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;

                    case 99:
                        if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if ((dailyForecast.daily.temperature_2m_max[i] + dailyForecast.daily.temperature_2m_min[i]) / 2 > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;

                }

            }

            
        }
        public void SetHourlyClothingType(ForecastHourly hourlyForecast)
        {


            for (int i = 0; i < hourlyForecast.hourly.weathercode.Count(); i++)

            {

                switch (hourlyForecast.hourly.weathercode[i])
                {
                    case 0:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.temperature_2m[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");

                        break;
                    case 1:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.temperature_2m[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;
                    case 2:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.temperature_2m[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;
                    case 3:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.temperature_2m[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;
                    case 45:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.temperature_2m[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;
                    case 48:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.temperature_2m[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;
                    case 51:
                        hourlyClothingType.Add("Wet");
                        break;
                    case 53:
                        hourlyClothingType.Add("Wet");
                        break;
                    case 55:
                        hourlyClothingType.Add("Wet");
                        break;
                    case 57:
                        hourlyClothingType.Add("Wet");
                        break;
                    case 61:
                        hourlyClothingType.Add("Wet");
                        break;
                    case 63:
                        hourlyClothingType.Add("V.Wet");
                        break;
                    case 65:
                        hourlyClothingType.Add("V.Wet");
                        break;
                    case 66:
                        hourlyClothingType.Add("V.Wet");
                        break;
                    case 67:
                        hourlyClothingType.Add("V.Wet");
                        break;
                    case 71:
                        hourlyClothingType.Add("Cold");
                        break;
                    case 73:
                        hourlyClothingType.Add("Cold");
                        break;
                    case 77:
                        hourlyClothingType.Add("Cold");
                        break;
                    case 80:
                        hourlyClothingType.Add("V.Wet");
                        break;
                    case 82:
                        hourlyClothingType.Add("V.Wet");
                        break;
                    case 85:
                        hourlyClothingType.Add("Cold");
                        break;
                    case 86:
                        hourlyClothingType.Add("Cold");
                        break;
                    case 95:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.temperature_2m[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;
                    case 96:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.temperature_2m[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;

                    case 99:
                         if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.temperature_2m[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;

                }

            }


        }
        public List<List<string>> GetClothingBasedOnType(List<string> clothingType)
        {
            List<List<string>> clothingAdvice = new List<List<string>>();
            foreach (string clothingtype in clothingType)
            {
                var clothingSuggestion =
                from clothing in clothingSuggestions
                where clothing.type == clothingtype
                select clothing.clothingDescription;
                clothingAdvice.Add(clothingSuggestion.ToList());

            }
            return clothingAdvice;
        }
    }
}


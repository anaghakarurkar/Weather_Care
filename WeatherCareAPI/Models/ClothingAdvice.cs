using System;
using WeatherCareAPI.Models.Json;

namespace WeatherCareAPI.Models
{
    public class ClothingAdvice
    {

        // List of clothing 
        public List<Clothing> clothingSuggestions = new List<Clothing>()
        {
            new Clothing("C1","Cold","Beanie"),
            new Clothing("C2","Cold","Sweater"),
            new Clothing("C3","Cold","Fleece jacket"),
            new Clothing("C4","Cold","Mittens"),
            new Clothing("C5","Cold","Scarf"),
            new Clothing("C6","Cold","Cardigan"),
            new Clothing("C7","Cold","Earmuffs"),
            new Clothing("C8","Cold","Winter Jacket"),
            new Clothing("C9","Cold","Long-sleeve top"),
            new Clothing("C10","Hot","Vest"),
            new Clothing("C11","Hot","Shorts"),
            new Clothing("C12","Hot","Polo"),
            new Clothing("C13","Hot","T-shirt"),
            new Clothing("C14","Hot","Slippers"),
            new Clothing("C15","Hot","Cap"),
            new Clothing("C15","Wet","Raincoat"),
            new Clothing("C15","V.Wet","Umbrella"),
            new Clothing("C15","Windy","Windbreaker"),
            new Clothing("C15","Windy","Scarf"),
            new Clothing("C15","Windy","Cardigan"),
            new Clothing("C16","Cold","Scarf"),
            new Clothing("C17","Mild","Long Sleeve Top"),
            new Clothing("C19","Mild","Light Trousers")


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
                        if (dailyForecast.daily.temperature_2m_max[i]> 20)
                        { dailyClothingType.Add("Hot"); }
                        else if (dailyForecast.daily.weathercode[i] > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");

                        break;
                    case 1:
                        if (dailyForecast.daily.temperature_2m_max[i] > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if (dailyForecast.daily.weathercode[i] > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;
                    case 2:
                        if (dailyForecast.daily.temperature_2m_max[i] > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if (dailyForecast.daily.weathercode[i] > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;
                    case 3:
                        if (dailyForecast.daily.temperature_2m_max[i] > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if (dailyForecast.daily.weathercode[i] > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;
                    case 45:
                        if (dailyForecast.daily.temperature_2m_max[i] > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if (dailyForecast.daily.weathercode[i] > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;
                    case 48:
                        if (dailyForecast.daily.temperature_2m_max[i] > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if (dailyForecast.daily.weathercode[i] > 10)
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
                        if (dailyForecast.daily.temperature_2m_max[i] > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if (dailyForecast.daily.weathercode[i] > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;
                    case 96:
                        if (dailyForecast.daily.temperature_2m_max[i] > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if (dailyForecast.daily.weathercode[i] > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;

                    case 99:
                        if (dailyForecast.daily.temperature_2m_max[i] > 20)
                        { dailyClothingType.Add("Hot"); }
                        else if (dailyForecast.daily.weathercode[i] > 10)
                            dailyClothingType.Add("Mild");
                        else dailyClothingType.Add("Cold");
                        break;

                }

            }

            
        }
        public void SetHourlyClothingTypeHourly(ForecastHourly hourlyForecast)
        {


            for (int i = 0; i < hourlyForecast.hourly.weathercode.Count(); i++)

            {

                switch (hourlyForecast.hourly.weathercode[i])
                {
                    case 0:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.weathercode[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");

                        break;
                    case 1:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.weathercode[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;
                    case 2:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.weathercode[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;
                    case 3:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.weathercode[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;
                    case 45:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.weathercode[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;
                    case 48:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.weathercode[i] > 10)
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
                        else if (hourlyForecast.hourly.weathercode[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;
                    case 96:
                        if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.weathercode[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;

                    case 99:
                         if (hourlyForecast.hourly.temperature_2m[i] > 20)
                        { hourlyClothingType.Add("Hot"); }
                        else if (hourlyForecast.hourly.weathercode[i] > 10)
                            hourlyClothingType.Add("Mild");
                        else hourlyClothingType.Add("Cold");
                        break;

                }

            }


        }
        public List<Clothing> DailyGetClothingBasedOnType(List<string> dailyClothingType)
        {
            List<Clothing> dailyClothing = new List<Clothing>();
            foreach (string clothingtype in dailyClothingType)
            {
                var clothingSuggestion =
                from clothing in clothingSuggestions
                where clothing.type == clothingtype
                select clothing;
                dailyClothing = clothingSuggestion.ToList();

            }
            return dailyClothing;
        }

    }
}


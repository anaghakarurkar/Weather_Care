
using System;
namespace WeatherCareAPI.Models
{
    public class Clothing
    {
     
        public string type { get; set; }
        public string clothingDescription { get; set; }
        public Clothing( string _type, string _clothingDescription)
        {

       
            type = _type;
            clothingDescription = _clothingDescription;
        }
    }
}


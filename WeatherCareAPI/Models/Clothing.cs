
using System;
namespace WeatherCareAPI.Models
{
    public class Clothing
    {
        public string clothingId { get; set; }
        public string type { get; set; }
        public string clothingDescription { get; set; }
        public Clothing(string _clothingId, string _type, string _clothingDescription)
        {

            clothingId = _clothingId;
            type = _type;
            clothingDescription = _clothingDescription;
        }
    }
}


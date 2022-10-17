using System;
using Microsoft.EntityFrameworkCore;

namespace WeatherCareAPI.Models
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {
        }

        public DbSet<City> CityInfo { get; set; }
    }
}
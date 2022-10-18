using Microsoft.EntityFrameworkCore;
using WeatherCareAPI.Models;
using WeatherCareAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IWeatherCareService, WeatherCareService>();
builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("WeatherCareAPI");

if (builder.Environment.EnvironmentName == "Testing")
{
    // in test environment use a fresh in-memory DB
    builder.Services.AddDbContext<WeatherContext>(option =>
    option.UseInMemoryDatabase("WeatherCareDB"));
}
else
{
    // connect to the MySQL database
    builder.Services.AddDbContext<WeatherContext>(option =>
    option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
}

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

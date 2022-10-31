# Weather Care API
![GitHub last commit](https://img.shields.io/github/last-commit/anaghakarurkar/Weather_Care?style=plastic) ![GitHub repo size](https://img.shields.io/github/repo-size/anaghakarurkar/Weather_Care) ![GitHub watchers](https://img.shields.io/github/watchers/anaghakarurkar/Weather_Care)

With our Weather Care API you can plan your journey effectively by providing weather location for any given location 
Weather Care collaborates with Open Meteo API consuming National Weather Services. Our API provides  weather data as well as clothing suggestions  based on current and future  weather conditions responding with data as a simple JSON API.
APIs are free without any API key for open-source developers and non-commercial use. You can embed them directly into your app.

## key features of Weather Care API
<li>Daily Weather Advice via city name or GEO-Position - 7 Day Forecast</li>
<li>Hourly Weather Advice via city name or GEO-Position - 24 Hour Forecast</li> <br> 
The Advice includes the following:<br>
<li>Date and Time</li>
<li>Temperature</li>
<li>Weather Type Summary (Rainy, Snowing, Thunderstorm…)</li>
<li>Clothing Suggestions </li>

## Running the Unit Tests
Fork this repo to your Github and then clone the forked version of this repo.<br>
You can run the unit tests in Visual Studio, or you can go to your terminal and inside the root of this directory, run: <br>
dotnet test<br>


## Weather API End Points:
Get clothing daily advice using top 150 citynames:<br>
/WeatherCare/dailyAdvice/{cityname}

Get clothing daily advice using latitude and longitude:<br>
/WeatherCare/dailyAdvice/geolocation?latitude={latitude}&longitude={longitude}

Get clothing hourly advice using  top 150 citynames:<br>
/WeatherCare/hourlyAdvice/{cityname}

Get clothing hourly advice using latitude and longitude:<br>
/WeatherCare/hourlyAdvice/geolocation?latitude={latitude}&longitude={longitude}

Get clothing current advice using  top 150 citynames:<br>
/WeatherCare/currentAdvice/{cityname}<br>


For example:   /WeatherCare/currentAdvice/london <br>
Response object: This endpoint will return responce object in JSON format. <br>

{<br>
  "time": "17:00", <br>
  "temperature": 15, <br>
  "weatherType": "Overcast", <br>
  "suggestedClothes": [ <br>
    "Jumper", <br>
    "Fleece", <br>
    "Long Sleeve Top", <br>
    "Light Trousers" <br>
  ] <br>
}<br>


Get clothing current advice using latitude and longitude:<br>
/WeatherCare/currentAdvice/geolocation?latitude={latitude}&longitude={longitude}

<img width="593" alt="Screenshot 2022-10-31 at 18 10 18" src="https://user-images.githubusercontent.com/108285095/199080659-0281e1fb-e550-4527-9355-f1c71c561bcb.png">

<img width="624" alt="Screenshot 2022-10-31 at 18 12 13" src="https://user-images.githubusercontent.com/108285095/199080680-957602b8-fe31-4ae2-a4c0-22817d826ecd.png">

<img width="605" alt="Screenshot 2022-10-31 at 18 15 01" src="https://user-images.githubusercontent.com/108285095/199080722-f261b286-c247-41ab-8ce9-066df2ba228a.png">

<img width="603" alt="Screenshot 2022-10-31 at 18 15 08" src="https://user-images.githubusercontent.com/108285095/199080735-6cd2e4ed-55c3-4d78-9b56-9a6f67895649.png">


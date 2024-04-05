using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VotreApplication
{
    public class MeteoService
    {
        private const string APIKey = "5019de68474e4299bfe95007240404";

        private const string BaseURL = "http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric";

        public async Task<MeteoData> GetWeather(string city)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync(string.Format(BaseURL, city, APIKey));
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);
                    return MapToMeteoData(weatherData);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception($"Une erreur s'est produite lors de la requête HTTP : {ex.Message}");
                }
            }
        }

        private MeteoData MapToMeteoData(WeatherData weatherData)
        {
            return new MeteoData
            {
                Temperature = weatherData.Main.Temp,
                Humidity = weatherData.Main.Humidity
            };
        }
    }
}

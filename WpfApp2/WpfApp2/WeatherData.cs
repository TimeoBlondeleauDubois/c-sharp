namespace VotreApplication
{
    public class WeatherData
    {
        public MainData Main { get; set; }
    }

    public class MainData
    {
        public double Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class MeteoData
    {
        public double Temperature { get; set; }
        public int Humidity { get; set; }
    }
}

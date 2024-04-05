using System;
using System.Windows;

namespace VotreApplication
{
    public partial class MainWindow : Window
    {
        private MeteoService meteoService;

        public MainWindow()
        {
            InitializeComponent();
            meteoService = new MeteoService();
        }

        private async void btnGetWeather_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string city = txtCity.Text;
                MeteoData meteoData = await meteoService.GetWeather(city);
                txtWeatherResult.Text = $"Température: {meteoData.Temperature}°C\nHumidité: {meteoData.Humidity}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
            }
        }
    }
}

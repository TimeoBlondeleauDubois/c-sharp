using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace QuizzApp
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new QuizzPage(0);
        }
    }
}

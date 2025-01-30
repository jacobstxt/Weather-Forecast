using System.Configuration;
using System.Data;
using System.Windows;
using DLL;
using Microsoft.EntityFrameworkCore;

namespace Weather
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            // Ініціалізація бази даних
            using (var dbContext = new WeatherDBContext())
            {
                dbContext.Database.Migrate(); // Створює або оновлює базу даних
            }
        }

    }

}

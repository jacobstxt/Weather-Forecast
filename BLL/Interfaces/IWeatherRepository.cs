using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.DataModels;

namespace BLL.Interfaces
{
    public interface IWeatherRepository
    {
        Task<List<WeatherEntity>> GetWeatherDataAsync();  // Отримати всі дані про погоду
        Task AddWeatherDataAsync(WeatherEntity weather);  // Додати нові дані про погоду
        Task<WeatherEntity> GetWeatherByIdAsync(int id);  // Отримати запис про погоду за ідентифікатором
    }
}

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
        Task<List<WeatherEntity>> GetWeatherDataAsync();  
        Task AddWeatherDataAsync(WeatherEntity weather); 
        Task<WeatherEntity> GetWeatherByIdAsync(int id); 
    }
}

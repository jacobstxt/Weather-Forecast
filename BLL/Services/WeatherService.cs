using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DLL.DataModels;
using DLL.Repositories;

namespace BLL.Services
{
    public class WeatherService
    {

        private readonly IWeatherRepository _weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public async Task<List<WeatherEntity>> GetWeatherDataAsync()
        {
            return await _weatherRepository.GetWeatherDataAsync();
        }

        public async Task AddWeatherDataAsync(WeatherEntity weather)
        {
            await _weatherRepository.AddWeatherDataAsync(weather);
        }
    }

}

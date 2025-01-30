using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DLL.Repositories
{
    public class WeatherRepository
    {

        private readonly WeatherDBContext _context;

        public WeatherRepository(WeatherDBContext context)
        {
            _context = context;
        }


        public async Task<List<WeatherEntity>> GetAllWeatherDataAsync()
        {
            return await _context.Weather.ToListAsync();
        }


        public async Task<List<WeatherEntity>> GetWeatherByLocationAsync(string location)
        {
            return await _context.Weather
                .Where(w => w.Location == location)
                .ToListAsync();
        }

        public async Task AddWeatherAsync(WeatherEntity weather)
        {
            _context.Weather.Add(weather);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateWeatherAsync(WeatherEntity weather)
        {
            _context.Weather.Update(weather);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteWeatherAsync(int id)
        {
            var weather = await _context.Weather.FindAsync(id);
            if (weather != null)
            {
                _context.Weather.Remove(weather);
                await _context.SaveChangesAsync();
            }
        }

    }
}

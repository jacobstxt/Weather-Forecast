using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DLL.Repositories
{
    public class UserRepository
    {

        private readonly WeatherDBContext _context;

        public UserRepository(WeatherDBContext context)
        {
            _context = context;
        }


        public async Task<List<UserEntity>> GetAllUsersAsync()
        {
            return await _context.User.ToListAsync();
        }


        public async Task AddUserAsync(UserEntity user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(UserEntity user)
        {
            _context.User.Update(user);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteUserAsync(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user != null)
            {
                _context.User.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

    }
}

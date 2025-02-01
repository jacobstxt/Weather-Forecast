using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DLL.DataModels;

namespace BLL.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public async Task<UserEntity> GetUserByUsernameAsync(string username)
        {
            return await _userRepository.GetUserByUsernameAsync(username);
        }


        public async Task AddUserAsync(UserEntity user)
        {
            await _userRepository.AddUserAsync(user);
        }

       
        public async Task UpdateUserAsync(UserEntity user)
        {
            await _userRepository.UpdateUserAsync(user);  
        }


        public async Task DeleteUserAsync(int userId)
        {
            await _userRepository.DeleteUserAsync(userId);  
        }
    }
}

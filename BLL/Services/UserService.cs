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

        // Отримати користувача за ім'ям користувача
        public async Task<UserEntity> GetUserByUsernameAsync(string username)
        {
            return await _userRepository.GetUserByUsernameAsync(username);
        }

        // Додати нового користувача
        public async Task AddUserAsync(UserEntity user)
        {
            await _userRepository.AddUserAsync(user);
        }

        // Можна додати інші методи для оновлення чи видалення користувача
        // Оновити користувача
        public async Task UpdateUserAsync(UserEntity user)
        {
            await _userRepository.UpdateUserAsync(user);  // Викликає метод з репозиторію для оновлення користувача
        }

        // Видалити користувача
        public async Task DeleteUserAsync(int userId)
        {
            await _userRepository.DeleteUserAsync(userId);  // Викликає метод з репозиторію для видалення користувача
        }
    }
}

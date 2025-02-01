using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.DataModels;

namespace BLL.Interfaces
{
    public interface IUserRepository
    {
        Task<UserEntity> GetUserByUsernameAsync(string username); 
        Task AddUserAsync(UserEntity user);  
        Task UpdateUserAsync(UserEntity user);
        Task DeleteUserAsync(int userId);
    }
}

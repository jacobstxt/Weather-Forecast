using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsDTO
{
    public class UserDTO
    {
        public int Id { get; set; }  // Унікальний ідентифікатор користувача
        public string UserName { get; set; }  // Логін користувача
        public string Email { get; set; }  // Адреса електронної пошти
        public string PasswordHash { get; set; }  // Хеш паролю (не зберігати сам пароль)
    }
}

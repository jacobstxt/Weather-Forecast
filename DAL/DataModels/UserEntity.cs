using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DataModels
{
    [Table("tbl_users")]
    public class UserEntity
    {
        public int Id { get; set; }  // Унікальний ідентифікатор користувача
        public string UserName { get; set; }  // Логін користувача
        public string Email { get; set; }  // Адреса електронної пошти
        public string PasswordHash { get; set; }  // Хеш паролю (не зберігати сам пароль)
    }
}

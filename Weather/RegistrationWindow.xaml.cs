using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DLL;
using DLL.DataModels;

namespace Weather
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {

        WeatherDBContext db;

        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UserNameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            // Перевірка чи вже існує користувач з таким логіном або email
            using (var dbContext = new WeatherDBContext())
            {
                if (dbContext.User.Any(u => u.UserName == username))
                {
                    MessageBox.Show("Користувач з таким логіном вже існує");
                    return;
                }

                if (dbContext.User.Any(u => u.Email == email))
                {
                    MessageBox.Show("Користувач з таким email вже існує");
                    return;
                }

                string passwordHash = HashPassword(password);

                // Додавання нового користувача
                var newUser = new UserEntity
                {
                    UserName = username,
                    Email = email,
                    PasswordHash = passwordHash
                };

                dbContext.User.Add(newUser);
                dbContext.SaveChanges();
            }

            MessageBox.Show("Реєстрація успішна!");        
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private string HashPassword(string password)
        {
            return  BCrypt.Net.BCrypt.HashPassword(password);
        }


    }
}

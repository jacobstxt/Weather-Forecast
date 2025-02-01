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
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UserNameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            if (!IsValidEmail(email))
            {
                MessageBox.Show("Некоректний email!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            if (!IsValidPassword(password))
            {
                MessageBox.Show("Пароль має містити щонайменше 8 символів, 1 цифру та 1 спеціальний символ!", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            using (var dbContext = new WeatherDBContext())
            {
                if (dbContext.User.Any(u => u.UserName == username))
                {
                    MessageBox.Show("Користувач з таким логіном вже існує","error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (dbContext.User.Any(u => u.Email == email))
                {
                    MessageBox.Show("Користувач з таким email вже існує","error",MessageBoxButton.OK,MessageBoxImage.Warning);
                    return;
                }

                string passwordHash = HashPassword(password);

                var newUser = new UserEntity
                {
                    UserName = username,
                    Email = email,
                    PasswordHash = passwordHash
                };

                dbContext.User.Add(newUser);
                dbContext.SaveChanges();
            }

            MessageBox.Show("Реєстрація успішна!","Succes",MessageBoxButton.OK,MessageBoxImage.Information);        
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private string HashPassword(string password)
        {
            return  BCrypt.Net.BCrypt.HashPassword(password);
        }

        private void ReturnBT_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private bool IsValidPassword(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsDigit) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }



    }
}

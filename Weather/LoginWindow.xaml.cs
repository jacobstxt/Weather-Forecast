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
using Org.BouncyCastle.Crypto.Generators;


namespace Weather
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        public bool IsLoggedIn { get; private set; } = false;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            // Пошук користувача в базі
            using (var dbContext = new WeatherDBContext())
            {
                var ValidEmail = dbContext.User.FirstOrDefault(u => u.Email == email);
                               
                if (ValidEmail == null)
                {
                    EmailTextBox.BorderBrush = Brushes.Red;
                    EmailTextBox.BorderThickness = new Thickness(1);
                    ErrorMessage.Text = "Невірний e-mail";
                    ErrorMessage.Visibility = Visibility.Visible;
                }
               
                else if ((!BCrypt.Net.BCrypt.Verify(password, ValidEmail.PasswordHash)))
                {
                    PasswordBox.BorderBrush = Brushes.Red;
                    PasswordBox.BorderThickness = new Thickness(1);
                    ErrorMessage.Text = "Невірний пароль";
                    ErrorMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    EmailTextBox.ClearValue(BorderBrushProperty);
                    EmailTextBox.ClearValue(BorderThicknessProperty);
                    PasswordBox.ClearValue(BorderBrushProperty);
                    PasswordBox.ClearValue(BorderThicknessProperty);
                    ErrorMessage.Visibility = Visibility.Collapsed;
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
            }
        }


        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }



    }
}

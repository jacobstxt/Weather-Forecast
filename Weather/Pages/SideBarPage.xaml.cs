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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Weather.Pages
{
    /// <summary>
    /// Interaction logic for SideBarPage.xaml
    /// </summary>
    public partial class SideBarPage : Page
    {
        public SideBarPage()
        {
            InitializeComponent();
        }


        private void LogOutBT_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Application.Current.Windows.OfType<Window>().FirstOrDefault(w => w is MainWindow);
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            mainWindow?.Close();

        }

        private void CloseBT_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService != null)
            {
                this.NavigationService.Content = null;
            }
        }

        private void OpenAboutProgramBT_Click(object sender, RoutedEventArgs e)
        {
           AboutProgramWindow aboutProgramWindow = new AboutProgramWindow();
            aboutProgramWindow.Show();
        }


    }
}

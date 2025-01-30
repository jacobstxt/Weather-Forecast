using System;
using System.Threading.Tasks;
using System.Windows;
using BLL.Services;
using DLL;
using Microsoft.EntityFrameworkCore;

namespace Weather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly UserService _userService;
        public MainWindow()
        {
            InitializeComponent();
        }

    }
}

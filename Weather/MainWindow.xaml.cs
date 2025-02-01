using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using BLL.Services;
using DLL;
using DLL.DataModels;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using DLL;
using DLL.DataModels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Weather.Pages;

namespace Weather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Animation 
        //private bool isPanelVisible = false; // Додаткова змінна для відстеження стану панелі

        //private void OpenPanel_Click(object sender, RoutedEventArgs e)
        //{
        //    // Перевіряємо, чи панель вже має RenderTransform
        //    if (SidePanel.RenderTransform is TranslateTransform transform)
        //    {
        //        // Якщо панель видима, анімація для приховування
        //        if (isPanelVisible)
        //        {
        //            // Анімація для ховання панелі
        //            DoubleAnimation slideAnimation = new DoubleAnimation
        //            {
        //                From = 0,  // Початкове положення (панель на своєму місці)
        //                To = -250, // Кінцеве положення (панель ховається)
        //                Duration = new Duration(System.TimeSpan.FromSeconds(0.5)) // Тривалість анімації
        //            };
        //            transform.BeginAnimation(TranslateTransform.XProperty, slideAnimation);
        //            isPanelVisible = false; // Зміна стану на приховану
        //        }
        //        else
        //        {
        //            // Анімація для виїзду панелі
        //            DoubleAnimation slideAnimation = new DoubleAnimation
        //            {
        //                From = -250, // Початкове положення (панель прихована за межами екрану)
        //                To = 0,      // Кінцеве положення (панель на своєму місці)
        //                Duration = new Duration(System.TimeSpan.FromSeconds(0.5)) // Тривалість анімації
        //            };
        //            transform.BeginAnimation(TranslateTransform.XProperty, slideAnimation);
        //            isPanelVisible = true; // Зміна стану на видиму
        //        }
        //    }
        //    else
        //    {
        //        // Якщо немає трансформації, додаємо нову і початково ховаємо панель
        //        TranslateTransform newTransform = new TranslateTransform(-250, 0);
        //        SidePanel.RenderTransform = newTransform;

        //        // Анімація для виїзду панелі
        //        DoubleAnimation slideAnimation = new DoubleAnimation
        //        {
        //            From = -250, // Початкове положення (панель прихована за межами екрану)
        //            To = 0,      // Кінцеве положення (панель на своєму місці)
        //            Duration = new Duration(System.TimeSpan.FromSeconds(0.5))
        //        };

        //        newTransform.BeginAnimation(TranslateTransform.XProperty, slideAnimation);
        //        isPanelVisible = true; // Панель стає видимою
        //    }
        //}
        #endregion

        private async void SearchBT_Click(object sender, RoutedEventArgs e)
        {
            ForecastStackPanel.Children.Clear();
            string apiKey = "9702b9e2bfe06c61aa12b74b8bbf20c6";
            string city = this.CityTB.Text;
            string url = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var forecastData = JObject.Parse(responseBody);
                    var list = forecastData["list"];

                    foreach (var item in list)
                    {
                        string dateString = item["dt_txt"].ToString();
                        DateTime date = DateTime.Parse(dateString).ToUniversalTime(); // Перетворення на UTC
                        double temp = double.Parse(item["main"]["temp"].ToString());
                        string description = item["weather"][0]["description"].ToString();
                        string iconCode = item["weather"][0]["icon"].ToString();


                        StackPanel forecastCard = new StackPanel
                        {
                            Orientation = Orientation.Horizontal,
                            Margin = new Thickness(10),
                            Height = 80
                        };

                        if (temp >= 10)
                        {
                            forecastCard.Background = new SolidColorBrush(Colors.Yellow); 
                        }
                        else if (temp < 10 && temp >= 5)
                        {
                            forecastCard.Background = new SolidColorBrush(Colors.LightBlue); 
                        }
                        else
                        {
                            forecastCard.Background = new SolidColorBrush(Colors.Blue);
                        }


                        Image weatherIcon = new Image
                        {
                            Width = 50,
                            Height = 50,
                            Source = new BitmapImage(new Uri(
                                iconCode == "03n"
                                ? "C:/IT/NetworkProgramming/Weather/Weather/Images/ScatteredClouds.png"
                                : $"http://openweathermap.org/img/wn/{iconCode}.png"))
                        };

                        forecastCard.Children.Add(weatherIcon);

                        StackPanel textStack = new StackPanel
                        {
                            Orientation = Orientation.Vertical,
                            Margin = new Thickness(10, 0, 0, 0)
                        };

                        textStack.Children.Add(new TextBlock { Margin = new Thickness(10, 10, 0, 0), Text = date.ToString(), FontWeight = FontWeights.Bold });
                        textStack.Children.Add(new TextBlock { Margin = new Thickness(10, 0, 0, 0), Text = $"Температура: {temp}°C" });
                        textStack.Children.Add(new TextBlock { Margin = new Thickness(10, 0, 0, 0), Text = $"Погода: {description}" });

                        forecastCard.Children.Add(textStack);
                        ForecastStackPanel.Children.Add(forecastCard);

  
                        using (var dbContext = new WeatherDBContext())
                        {                
                               var newWeather = new WeatherEntity
                                {
                                    Date = date,
                                    Temperature = (float)temp,
                                    Location = city,
                                    WeatherCondition = description
                                };

                                dbContext.Weather.Add(newWeather);
                                dbContext.SaveChanges();
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Непередбачувана помилка: {ex.Message}");
                }
            }
        }



      

        private void SideBar_Click(object sender, RoutedEventArgs e)
        {
            TranslateTransform moveAnimation = new TranslateTransform();
            MainFrame.RenderTransform = moveAnimation;

            DoubleAnimation moveAnimationX = new DoubleAnimation
            {
                From = -250, 
                To = 0, 
                Duration = new Duration(TimeSpan.FromSeconds(0.4))
            };

            moveAnimation.BeginAnimation(TranslateTransform.XProperty, moveAnimationX);

            MainFrame.Navigate(new SideBarPage());
        }
    }
}

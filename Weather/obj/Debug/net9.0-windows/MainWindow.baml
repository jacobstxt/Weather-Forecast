   M S B A M L   `   `   `  ����B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WeatherWeather  5   	       Weather.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Weather     5   	     � Title$  Weather Forecast��5   	    � Icon$> 8C:\IT\NetworkProgramming\Weather\Weather\Images\icon.png��6"   $	��650��6b   $	��750��6o    � WindowStartupLocation$ CenterScreen=�6{   .��5      � ��5   
   �� 5       �� ImageSource$A ;C:\IT\NetworkProgramming\Weather\Weather\Images\Weather.jpg��6    � ColumnDefinitions 5   
   �� 5      $��0.67* �6   6/   �� 5      6!   .+�5   
   �� $	��100��6   $	��100��6   $?��9C:\IT\NetworkProgramming\Weather\Weather\Images\image.png��6)   $
��Left=�6l   $��	0,0,0,500q�6�   �� 5   
   $��22(�6   $
��Bold"�5      
�������
������ �� Padding$ 10q�5      $��Center=�5      $��Center=�5      $��Weather Forecast��5       �� TextAlignment$ Center=�5       $��Lucida Sans Typewriter)�5!      $��
0,0,30,350q�5"      �� 5$   
   $��Center=�6   
�������$
��Bold"�6D   $��Bottom=�6V   $��14(�6q   $��	0,0,20,20q�6   53© 2025 Jacobs. Всі права захищено.5&      � 5Z   
   $��1��6    5[      �� 5\      6%   �� 5]      6%    � RowDefinitions 5a      �� 5b      $
��0.2* �6    60   �� 5c      6"   .+�5f      �� -   5         ��Name$ CityTB��5f      $	��350��6&   $��	0,0,-10,0q�62   $��18(�6E   $��Center=�6S   	 �� TextAlignment$	 Justify=�6u   $��Stretch=�6�   $��2��6�   $��40��6�   6�   �� 5g      -   5        
 ��Name$
 SearchBT��5g   O   $��40��6   $��40��6    $��	130,0,0,0q�6,   $��1��6?   ��5h      �� 5i      $>��8C:\IT\NetworkProgramming\Weather\Weather\Images\Lupa.png��6   5k      �� 5m      -   5        $
 SideBar��5m   c   $��40��6   $��40��6    $��2��6,   $��	0,0,380,0q�6@   $��0��6S   ��5n      �� 5o      $A��;C:\IT\NetworkProgramming\Weather\Weather\Images\SideBar.png��6   5q      �� 5s      -   5         ��Name$ Scroll��5s      $	��450��6+   $��	-30,0,0,0q�67   $��1��6J   $��2��6W   $��0��6k   $
��Auto=�6~   .��5t      �� -   5         ��Name$ ForecastStackPanel��5t   L   $	��430��6   $��0,0,0,0q�6)   $��1��6:   $��2��6h   5v      5w      5x      �� 5z   
   $	��140��6   $	��260��6"   ���#333$��0,0,10,0q�6A   $��Center=�6S   .+�5{      �� $��18(�6   $��0,20,0,0q�6#   
�������$ Center=�6H   $��Italic$�6_   31"Іноді щось може йти не так,�� 5}   
   '%як хотілося б, але ви�� 5   
   ,*не повинні зупинятися."5�      �� 5�      $��16(�6   
�������$ Right=�6=   $��	0,10,30,0q�6S   — Michael Jordan5�      5�       � 5�   
   -   5          �Name$ 	MainFrame��5�        � NavigationUIVisibility$ 	Automatic=�6#   5�      5�      
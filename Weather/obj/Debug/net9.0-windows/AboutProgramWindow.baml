   M S B A M L   `   `   `  ����B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WeatherWeather  5   	        Weather.AboutProgramWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Weather     5   	     � Title$
  Info��5   	   $	��450��6   $	��800��6#    � WindowStartupLocation$ CenterScreen=�6/    � Icon$> 8C:\IT\NetworkProgramming\Weather\Weather\Images\info.png��6T   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ LightSkyBlue��6    � Offset$ 0Q�64   � 5      $
 Gray��6   $ 1Q�6,   5       � RowDefinitions 5   
   �� 5      $
��0.2* �6   6,   �� 5      $��1* �6   6*   .+�5   
   �� $��30(�6   $��Center=�6"   $��Center=�6?   $��Lucida Sans Typewriter)�6Z   
�������Про програму5      �� 5   
   $��1��6   $��20q�6"   .+�5      �� $��16(�6   
�������$
��Wrap=�69   $
��0,10q�6M   ��Ця програма дозволяє вам отримати точний прогноз погоди для будь-якого міста у світі. Вона використовує дані з OpenWeather API для показу актуальних температур, умов погоди та прогнозу на кілька днів вперед.5       �� 5"      $��20(�6   $
��Bold"�6&   
�������$
��Wrap=�6K   $
��0,10q�6_   " Функції програми:5$      �� 5&      $��20,0,0,0q�6   .+�5'      �� $��20(�6   
�������$
��Wrap=�6=   YW1. Перегляд поточної погоди для вибраного міста.6�   �� 5(      $��20(�6   
�������$
��Wrap=�6=   OM2. Прогноз погоди на найближчі кілька днів.6~   �� 5)      $��20(�6   
�������$
��Wrap=�6=   ~|3. Відображення умов погоди з описом (наприклад, ясне небо, дощ, сніг).6�   �� 5*      $��20(�6   
�������$
��Wrap=�6=   \Z4. Підтримка відображення температури у Цельсіях.6�   5+      5-      50      51      
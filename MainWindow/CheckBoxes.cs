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
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;

namespace uLab_system_builder
{
    public partial class MainWindow : Window
    {
        private void OnESP32Click(object sender, RoutedEventArgs e)
        {
            if (ESP32Box.IsChecked == true)
            {
                ESP32_PROTOCOL_LIST.Visibility = Visibility.Visible;
                ESP32_PROTOCOL_TEXT.Visibility = Visibility.Visible;
                ESP32_PROTOCOL_LIST.IsEnabled = true;

                ESP32Border.Visibility = Visibility.Visible;
            }
            else
            {
                ESP32_PROTOCOL_LIST.Visibility = Visibility.Hidden;
                ESP32_PROTOCOL_TEXT.Visibility = Visibility.Hidden;
                ESP32_PROTOCOL_LIST.IsEnabled = false;
                ESP32_PROTOCOL_LIST.SelectedItem = null;
                ESP32Border.Visibility = Visibility.Hidden;
            }                
        }

        private void OnLEDsClick(object sender, RoutedEventArgs e)
        {
            if (_8x_LEDsBox.IsChecked == true)
                _8xLEDsBorder.Visibility = Visibility.Visible;
            else
                _8xLEDsBorder.Visibility = Visibility.Hidden;
        }

        private void OnFourSwitchesClick(object sender, RoutedEventArgs e)
        {
            if (_4x_SwitchesBox.IsChecked == true)
                _4SwitchesBorder.Visibility = Visibility.Visible;
            else
                _4SwitchesBorder.Visibility = Visibility.Hidden;
        }

        private void OnSevenSegClick(object sender, RoutedEventArgs e)
        {
            if (_3x_7_SegmentBox.IsChecked == true)
                _7SEGBorder.Visibility = Visibility.Visible;
            else
                _7SEGBorder.Visibility = Visibility.Hidden;
        }

        private void OnPushButtonsClick(object sender, RoutedEventArgs e)
        {
            if (_2x_push_buttonsBox.IsChecked == true)
                _2xPushButtonsBorder.Visibility = Visibility.Visible;
            else
                _2xPushButtonsBorder.Visibility = Visibility.Hidden;
        }

        private void OnGPIOClick(object sender, RoutedEventArgs e)
        {
            if (GPIOBox.IsChecked == true)
                GPIOBorder.Visibility = Visibility.Visible;
            else
                GPIOBorder.Visibility = Visibility.Hidden;
        }
    }
}

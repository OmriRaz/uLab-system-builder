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

namespace uLab_system_builder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string version = "V1.0.0";
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "μLab_system_builder " + version;
        }

        private bool IsProjectNameValid()
        {
            if (this.ProjectNameInput.Text.Length < 1)
                return false;
            if (!IsLetter(this.ProjectNameInput.Text[0]))
                return false;
            return true;
        }
        private bool IsLetter(char letter) // range: A-Z and a-z
        {
            if ((letter >= 65 && letter <= 90) || (letter >= 97 && letter <= 122))
                return true;
            return false;
        }

        private void OnClickExit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void OnClickGenerate(object sender, RoutedEventArgs e)
        {
            if (IsProjectNameValid())
            {
                FileGeneration.GenerateFile(this);
            }
            else
            {
                Helper.ErrorMessage("Project name cannot be empty, and its first character must be a letter!");
            }
        }
    }
    public class Helper : Window
    {
        public static void ErrorMessage(string error)
        {
            MessageBox.Show(error, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    public class FileGeneration : MainWindow
    {
        public static void GenerateFile(MainWindow window)
        {
            try
            {
                // write stuff to file before parameters
                if(window.ESP32Box.IsChecked == true)
                {
                    WriteESP32();
                }
                if (window._8x_LEDsBox.IsChecked == true)
                {
                    WriteLEDS();
                }
                if (window._2x_push_buttonsBox.IsChecked == true)
                {
                    WritePushButtons();
                }
                if (window._3x_7_SegmentBox.IsChecked == true)
                {
                    WriteSevenSegment();
                }
                if (window._4x_SwitchesBox.IsChecked == true)
                {
                    WriteSwitches();
                }
                if (window.GPIOBox.IsChecked == true)
                {
                    WriteGPIO();
                }
            }
            catch(Exception e)
            {
                Helper.ErrorMessage(e.ToString());
            }

        }
        private static void WriteESP32()
        {

        }
        private static void WriteLEDS()
        {

        }
        private static void WritePushButtons()
        {

        }
        private static void WriteSevenSegment()
        {

        }
        private static void WriteSwitches()
        {

        }
        private static void WriteGPIO()
        {

        }
    }
}

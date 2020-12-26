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
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

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

        private void OnClickExit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void OnClickGenerate(object sender, RoutedEventArgs e)
        {
            if (Helper.IsProjectNameValid(this.ProjectNameInput.Text))
            {
                string path = Helper.GetValidFilePath();
                if(path != "-1")
                {
                    path += "\\" + this.ProjectNameInput.Text + ".qsf"; // add filename (project name) with extention to folder path
                    FileGeneration.GenerateFile(this, path);
                }
                else
                {
                    Helper.ErrorMessage("Error with path");
                }
            }
            else
            {
                Helper.ErrorMessage("Project name cannot be empty, and its first character must be a letter!");
            }
        }
    }
    public class Helper : Window
    {
        public static bool IsProjectNameValid(string name)
        {
            if (name.Length < 1)
                return false;
            if (!IsLetter(name[0]))
                return false;
            return true;
        }

        public static bool IsLetter(char letter) // range: A-Z and a-z
        {
            if ((letter >= 65 && letter <= 90) || (letter >= 97 && letter <= 122))
                return true;
            return false;
        }

        public static string GetValidFilePath()
        {
            try
            {
                string path = "";
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.InitialDirectory = path;
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    path = dialog.FileName;
                }

                if (Directory.Exists(path))
                {
                    return path;
                }

                return "-1";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return "-1";
            }
        }

        public static void ErrorMessage(string error)
        {
            MessageBox.Show(error, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    public class FileGeneration : MainWindow
    {
        public static void GenerateFile(MainWindow window, string path)
        {
            try
            {
                GenerateFileWrites.WriteGeneral(path);
                // write stuff to file before parameters
                if(window.ESP32Box.IsChecked == true)
                {
                    GenerateFileWrites.WriteESP32(path);
                }
                if (window._8x_LEDsBox.IsChecked == true)
                {
                    GenerateFileWrites.WriteLEDS(path);
                }
                if (window._2x_push_buttonsBox.IsChecked == true)
                {
                    GenerateFileWrites.WritePushButtons(path);
                }
                if (window._3x_7_SegmentBox.IsChecked == true)
                {
                    GenerateFileWrites.WriteSevenSegment(path);
                }
                if (window._4x_SwitchesBox.IsChecked == true)
                {
                    GenerateFileWrites.WriteSwitches(path);
                }
                if (window.GPIOBox.IsChecked == true)
                {
                    GenerateFileWrites.WriteGPIO(path);
                }
            }
            catch(Exception e)
            {
                Helper.ErrorMessage(e.ToString());
            }

        }
    }
}

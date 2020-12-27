using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;
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

namespace uLab_system_builder
{
    public class Helper : Window
    {
        public static void AppendToFile(string fileName, string text)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true))
            {
                file.WriteLine(text);
            }
        }
        public static void DeleteFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                // 2 lines before delete clear garbage collection so that the file can be unlocked
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete(fileName);
            }
        }
        public static string GetCurrentDateAndTime()
        {
            string dateAndTime = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            dateAndTime += " "
            + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month)
            + DateTime.Now.ToString(" d, yyyy");

            return dateAndTime;
        }
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

        public static string GetValidFolderPath()
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
                else
                {
                    return "-1";
                }
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
}

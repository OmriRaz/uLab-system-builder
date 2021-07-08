using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace uLab_system_builder
{
    public class QsfFileGeneration : KiwiWindow
    {
        public static void GenerateQsfFile(KiwiWindow window, string path, string projectName)
        {
            WriteGeneral(path, projectName);

            if (window.ESP32Box.IsChecked == true)
            {
                WriteESP32(path, window);
            }
            if (window._8x_LEDsBox.IsChecked == true)
            {
                WriteLEDS(path);
            }
            if (window._2x_push_buttonsBox.IsChecked == true)
            {
                WritePushButtons(path);
            }
            if (window._3x_7_SegmentBox.IsChecked == true)
            {
                WriteSevenSegment(path);
            }
            if (window._4x_SwitchesBox.IsChecked == true)
            {
                WriteSwitches(path);
            }
            if (window.GPIOBox.IsChecked == true)
            {
                WriteGPIO(path);
            }
        }
        public static void WriteGeneral(string path, string projectName)
        {
            string generalSettings = QsfFileWriteSettings.WRITES_GENERAL_PROJECT_NAME + projectName + "\n"; // name of project
            generalSettings += QsfFileWriteSettings.WRITES_GENERAL_DATETIME + "\"" + Helper.GetCurrentDateAndTime() + "\"" + "\n"; // time and date

            generalSettings += QsfFileWriteSettings.WRITES_GENERAL; // general writes for every .qsf file

            generalSettings += QsfFileWriteSettings.WRITES_CLOCK;

            Helper.AppendToFile(path, generalSettings);
        }
        public static void WriteESP32(string path, KiwiWindow window)
        {
            if(window.ESP32_ITEM_UART.IsSelected)
            {

            }
            else if(window.ESP32_ITEM_I2C.IsSelected)
            {

            }
            else if(window.ESP32_ITEM_SPI.IsSelected)
            {

            }
            else
            {
                Helper.ErrorMessage("ERROR WITH PROTOCOLS ~ CONTACT DEVELOPER");
            }
        }
        public static void WriteLEDS(string path)
        {
            Helper.AppendToFile(path, QsfFileWriteSettings.WRITES_LED);
        }
        public static void WritePushButtons(string path)
        {
            Helper.AppendToFile(path, QsfFileWriteSettings.WRITES_BUTTON);
        }
        public static void WriteSevenSegment(string path)
        {
            Helper.AppendToFile(path, QsfFileWriteSettings.WRITES_SEG7);
        }
        public static void WriteSwitches(string path)
        {
            Helper.AppendToFile(path, QsfFileWriteSettings.WRITES_SWITCHES);
        }
        public static void WriteGPIO(string path)
        {
            Helper.AppendToFile(path, QsfFileWriteSettings.WRITES_GPIO);
        }
    }
}

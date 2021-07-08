using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uLab_system_builder
{
    class VFileGeneration : KiwiWindow
    {
        public static void GenerateVFile(KiwiWindow window, string path, string projectName)
        {
            WriteAll(window, path, projectName);
        }
        private static void WriteAll(KiwiWindow window, string path, string projectName)
        {
            string settings = VFileWriteSettings.WRITES_MODULE + projectName + "(" + "\n\n"; // name of project
            settings += VFileWriteSettings.WRITES_CLOCK;

            if (window._4x_SwitchesBox.IsChecked == true)
            {
                settings += ",\n" + VFileWriteSettings.WRITES_SWITCH;
            }
            if(window._2x_push_buttonsBox.IsChecked == true)
            {
                settings += ",\n" + VFileWriteSettings.WRITES_BUTTON;
            }
            if (window._3x_7_SegmentBox.IsChecked == true)
            {
                settings += ",\n" + VFileWriteSettings.WRITES_SEVENSEG;
            }
            if (window._8x_LEDsBox.IsChecked == true)
            {
                settings += ",\n" + VFileWriteSettings.WRITES_LED;
            }
            if (window.ESP32Box.IsChecked == true)
            {
                if (window.ESP32_ITEM_UART.IsSelected)
                {

                }
                else if (window.ESP32_ITEM_I2C.IsSelected)
                {

                }
                else if (window.ESP32_ITEM_SPI.IsSelected)
                {

                }
                else
                {
                    Helper.ErrorMessage("ERROR WITH PROTOCOLS ~ CONTACT DEVELOPER");
                }
                //settings += ",\n" + VFileWriteSettings.WRITES_ESP32;
            }
            if (window.GPIOBox.IsChecked == true)
            {
                // FOR NOW: GPIO is commented. When it is uncommented, replace "\n" with ",\n"
                settings += ",\n" + VFileWriteSettings.WRITES_GPIO;
            }

            Helper.AppendToFile(path, settings);
            Helper.AppendToFile(path, VFileWriteSettings.WRITES_END_LINE);
        }
    }
}

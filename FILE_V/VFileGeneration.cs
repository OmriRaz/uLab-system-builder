using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uLab_system_builder
{
    class VFileGeneration : MainWindow
    {
        public static void GenerateVFile(MainWindow window, string path, string projectName)
        {
            WriteAll(window, path, projectName);
        }
        private static void WriteAll(MainWindow window, string path, string projectName)
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
                if (window._8x_LEDsBox.IsChecked == true || window.GPIOBox.IsChecked == true) // 7seg not last
                {
                    settings += ",\n" + VFileWriteSettings.WRITES_SEVENSEG;
                }
                else
                {
                    settings += ",\n" + VFileWriteSettings.WRITES_SEVENSEG_NO_COMMAS;
                }
            }
            if (window._8x_LEDsBox.IsChecked == true)
            {
                settings += ",\n" + VFileWriteSettings.WRITES_LED;
            }
            if (window.GPIOBox.IsChecked == true)
            {
                settings += ",\n" + VFileWriteSettings.WRITES_GPIO;
            }

            Helper.AppendToFile(path, settings);
            Helper.AppendToFile(path, VFileWriteSettings.WRITES_END_LINE);
        }
    }
}

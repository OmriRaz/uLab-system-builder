using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uLab_system_builder
{
    public class GenerateFileWrites
    {
        private static void AppendToFile(string fileName, string settings)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true))
            {
                file.WriteLine(settings);
            }
        }
        public static void WriteGeneral(string path, string projectName)
        {
            string generalSettings = FileWriteSettings.WRITES_GENERAL_PROJECT_NAME + projectName + "\n"; // name of project
            generalSettings += FileWriteSettings.WRITES_GENERAL_DATETIME + "\"" + Helper.GetCurrentDateAndTime() + "\"" + "\n"; // time and date

            generalSettings += FileWriteSettings.WRITES_GENERAL; // general writes for every file

            AppendToFile(path, generalSettings);
        }
        public static void WriteESP32(string path)
        {

        }
        public static void WriteLEDS(string path)
        {
            AppendToFile(path, FileWriteSettings.WRITES_LED);
        }
        public static void WritePushButtons(string path)
        {
            AppendToFile(path, FileWriteSettings.WRITES_BUTTON);
        }
        public static void WriteSevenSegment(string path)
        {
            AppendToFile(path, FileWriteSettings.WRITES_SEG7);
        }
        public static void WriteSwitches(string path)
        {
            AppendToFile(path, FileWriteSettings.WRITES_SWITCHES);
        }
        public static void WriteGPIO(string path)
        {
            AppendToFile(path, FileWriteSettings.WRITES_GPIO);
        }
    }
}

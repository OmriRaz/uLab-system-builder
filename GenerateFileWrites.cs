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
            string generalSettings = FileWriteSettings.GENERAL_WRITES_PROJECT_NAME + projectName + "\n";
            //generalSettings += set_global_assignment -name PROJECT_CREATION_TIME_DATE ""17:22:40  DECEMBER 21, 2020"" ";

            generalSettings += FileWriteSettings.GENERAL_WRITES;

            AppendToFile(path, generalSettings);
        }
        public static void WriteESP32(string path)
        {

        }
        public static void WriteLEDS(string path)
        {

        }
        public static void WritePushButtons(string path)
        {

        }
        public static void WriteSevenSegment(string path)
        {

        }
        public static void WriteSwitches(string path)
        {

        }
        public static void WriteGPIO(string path)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uLab_system_builder
{
    public class GenerateFileWrites
    {
        private static void AppendToFile(string fileName, string line)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true))
            {
                file.WriteLine(line);
            }
        }
        public static void WriteGeneral(string path, string projectName)
        {
            string line = "set_global_assignment -name FAMILY \"MAX 10\"\n" +
            "set_global_assignment -name DEVICE 10M08SCU169C8G\n" +
            "set_global_assignment -name TOP_LEVEL_ENTITY " + projectName + "\n" +
            "";

            AppendToFile(path, line);
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

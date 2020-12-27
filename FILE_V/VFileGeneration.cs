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
            WriteGeneral(path, projectName);
        }
        private static void WriteGeneral(string path, string projectName)
        {
            string settings = VFileWriteSettings.WRITES_MODULE + projectName + "(" + "\n\n"; // name of project

            Helper.AppendToFile(path, settings);
        }
    }
}

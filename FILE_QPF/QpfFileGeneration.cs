using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uLab_system_builder
{
    class QpfFileGeneration : MainWindow
    {

        public static void GenerateQpfFile(MainWindow window, string path, string projectName)
        {
            string settings = QpfWriteSettings.WRITES_QUARTUS_VERSION + "\n";
            settings += QpfWriteSettings.WRITES_DATE + "\"" + Helper.GetCurrentDateAndTime() + "\"" + "\n"; // time and date
            settings += QpfWriteSettings.WRITES_PROJECT_NAME + "\"" + projectName + "\"" + "\n"; // name of project

            Helper.AppendToFile(path, settings);
        }
    }
}

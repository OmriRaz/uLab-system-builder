using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace uLab_system_builder
{
    public class GenerateFileWrites
    {
        public static void GenerateFiles(MainWindow window, string folder, string projectName)
        {
            try
            {
                string path = folder;

                path += "\\" + window.ProjectNameInput.Text + ".qsf"; // add filename (project name) with extention to folder path
                Helper.DeleteFile(path); // only deletes if exists
                QsfFileGeneration.GenerateQsfFile(window, path, window.ProjectNameInput.Text);

                path = folder + "\\" + window.ProjectNameInput.Text + ".qpf";
                Helper.DeleteFile(path);
                QpfFileGeneration.GenerateQpfFile(window, path, window.ProjectNameInput.Text);

                path = folder + "\\" + window.ProjectNameInput.Text + ".v";
                Helper.DeleteFile(path);
                VFileGeneration.GenerateVFile(window, path, window.ProjectNameInput.Text);

            }
            catch (Exception e)
            {
                Helper.ErrorMessage(e.ToString());
            }

        }
    }
}

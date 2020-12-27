using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using System.Diagnostics;

namespace uLab_system_builder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string version = "V1.0.0";
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "μLab_system_builder " + version;
        }

        private void OnClickExit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void OnClickGenerate(object sender, RoutedEventArgs e)
        {
            if (Helper.IsProjectNameValid(this.ProjectNameInput.Text))
            {
                try
                {
                    string path = Helper.GetValidFolderPath();
                    if(path != "-1")
                    {
                        path += "\\" + this.ProjectNameInput.Text;

                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }

                        string folder = path;
                        GenerateFileWrites.GenerateFiles(this, folder, this.ProjectNameInput.Text);

                        Process.Start(folder);
                        string successMessage = "Project " + this.ProjectNameInput.Text + " successfully generated";
                        MessageBox.Show(successMessage, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        Helper.ErrorMessage("Invalid path");
                    }
                }
                catch(Exception exception)
                {
                    Helper.ErrorMessage(exception.ToString());
                }
                
            }
            else
            {
                Helper.ErrorMessage("Project name cannot be empty, and its first character must be a letter!");
            }
        }
    }
}

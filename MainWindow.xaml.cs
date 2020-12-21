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

        private bool isProjectNameValid()
        {
            if (this.ProjectNameInput.Text.Length < 1)
                return false;
            if (!isLetter(this.ProjectNameInput.Text[0]))
                return false;
            return true;
        }
        private bool isLetter(char letter) // range: A-Z and a-z
        {
            if ((letter >= 65 && letter <= 90) || (letter >= 97 && letter <= 122))
                return true;
            return false;
        }

        private void OnClickExit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void OnClickGenerate(object sender, RoutedEventArgs e)
        {
            if(isProjectNameValid())
            {

            }
            else 
            {
                MessageBox.Show("Project name cannot be empty, and its first character must be a letter!", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

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
using System.Windows.Shapes;

namespace uLab_system_builder.MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void kiwi_image_MouseDown(object sender, MouseEventArgs e)
        {
            KiwiWindow window = new KiwiWindow();
            window.Show();
            this.Close();
        }
        private void kiwi_lite_image_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Kiwi Lite");
        }
    }
}

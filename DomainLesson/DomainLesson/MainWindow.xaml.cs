using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace DomainLesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void ButtonClickForDownload(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.Exited += new EventHandler(ExitedForDownload);
            process.StartInfo.FileName = "DownloadApp";
            process.EnableRaisingEvents = true;
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.Exited += new EventHandler(ExitedForCalculetion);
            process.StartInfo.FileName = "Calculetion";
            process.EnableRaisingEvents = true;
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();            
        }

        void ExitedForCalculetion(object sender, EventArgs e)
        {
            MessageBox.Show("Сalculation completed");
        }

        void ExitedForDownload(object sender, EventArgs e)
        {
            MessageBox.Show("Download completed");
        }
    }
}

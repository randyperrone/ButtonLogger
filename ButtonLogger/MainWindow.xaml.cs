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

namespace ButtonLogger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FileStream stream;
        private string path;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartRecordingButton_Click(object sender, RoutedEventArgs e)
        {
            path = "rec-" + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss") + ".csv";
            if (!File.Exists(path))
            {
                stream = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
            }
            else
            {
                stream = new FileStream(path, FileMode.Open, FileAccess.Write);
            }
            WriteToFile("recording started");
        }

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            WriteToFile("button 1 pressed");
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            WriteToFile("button 2 pressed");
        }

        private void WriteToFile(string buttonName)
        {
            try
            {
                string timeStamp = DateTime.Now.ToString("HH:mm.ss") + ", " + buttonName + System.Environment.NewLine;
                stream.Write(Encoding.ASCII.GetBytes(timeStamp), 0, ASCIIEncoding.ASCII.GetByteCount(timeStamp));
            }
            catch
            {
                System.Console.Write("You must start recording first");
            }
           
        }
    }
}

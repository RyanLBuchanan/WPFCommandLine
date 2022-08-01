using System;
using System.IO;
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

namespace WPFCommandLine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            String[] args = App.Args;

            try
            {
                // Open the text file using a stream reader
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    // Read the stream to a string, and write the string to a textbox
                    String line = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                textBox.AppendText("The file could not be read:");
                textBox.AppendText("\n");
                textBox.AppendText(e.Message);
            }
        }
    }
}

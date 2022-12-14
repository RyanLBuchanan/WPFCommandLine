using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFCommandLine
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string[] Args;

        void app_Startup(object sender, StartupEventArgs e)
        {
            // Ifno command line arguments were provided, don't process them
            if (e.Args.Length == 0) return;

            if (e.Args.Length > 0)
            {
                Args = e.Args;
            }
        }
    }
}

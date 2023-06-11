using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace CultureInfo_For_All_Software
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void AppStartup(object sender, StartupEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("it-IT");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("it-IT");
            Window window = new MainWindow();
            window.Show();
        }
    }

}

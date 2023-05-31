using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Software_Conditioning_by_Parameter
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            if(e.Args.Length > 0)
            {
                MessageBox.Show(e.Args[0]);
            }
            else {
                MainWindow mw = new MainWindow();
                mw.Show();
            }
        }
    }
}

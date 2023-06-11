using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace UICulture
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            double number = 1406.2023;

            CultureInfo cultureInfoEng = new CultureInfo("en-US");
            CultureInfo cultureInfoIta = new CultureInfo("it-IT");
            CultureInfo cultureInfoGer = new CultureInfo("de-DE");

            localUs.Content += number.ToString(cultureInfoEng);
            localIt.Content += number.ToString(cultureInfoIta);
            localDe.Content += number.ToString(cultureInfoGer);
        }
    }
}

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

namespace Switch_Culture_With_Button
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double NUMBER = 1051.25;
        DateTime DATE = DateTime.Now;
        public MainWindow()
        {
            InitializeComponent();
            numberLabel.Content = NUMBER.ToString();
            dateLabel.Content = DATE.ToString();

        }

        private void itButton_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo cultureIT = new CultureInfo("it-IT");
            numberLabel.Content = NUMBER.ToString(cultureIT);
            dateLabel.Content = DATE.ToString(cultureIT);
        }

        private void deButton_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo cultureDe = new CultureInfo("de-DE");
            numberLabel.Content = NUMBER.ToString(cultureDe);
            dateLabel.Content = DATE.ToString(cultureDe);
        }

        private void usButton_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo cultureUS = new CultureInfo("en-US");
            numberLabel.Content = NUMBER.ToString(cultureUS);
            dateLabel.Content = DATE.ToString(cultureUS);
        }
    }
}

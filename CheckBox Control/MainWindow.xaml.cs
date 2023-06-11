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

namespace CheckBox_Control
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (mainCheckBox.IsChecked == null)
                mainCheckBox.IsChecked = false;
            abcCheckBox.IsChecked = xyzCheckBox.IsChecked = wwwCheckBox.IsChecked = mainCheckBox.IsChecked;
        }

        private void nodeCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (abcCheckBox.IsChecked == true && xyzCheckBox.IsChecked == true && wwwCheckBox.IsChecked == true)
                mainCheckBox.IsChecked = true;
            else if (abcCheckBox.IsChecked == true || xyzCheckBox.IsChecked == true || wwwCheckBox.IsChecked == true)
                mainCheckBox.IsChecked = null;
            else 
                mainCheckBox.IsChecked = false;
        }
    }
}

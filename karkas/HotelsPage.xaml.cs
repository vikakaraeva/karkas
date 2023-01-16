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

namespace karkas
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
        }
        private void Page1(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Page1());
        }

        private void Page2(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Page2());
        }

        private void Page3(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Page3());
        }

        private void Page4(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Page4());
        }

        private void Page5(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Page5());
        }

        private void Page6(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Page6());
        }
    }
}

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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            webbrowser.Navigate("http://google.kz");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            webbrowser.Navigate("http://www.google.kz/search?q=" + findfield.Text);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = (sender as MenuItem);
            webbrowser.Navigate(menuItem.DataContext.ToString());
        }

    }
}

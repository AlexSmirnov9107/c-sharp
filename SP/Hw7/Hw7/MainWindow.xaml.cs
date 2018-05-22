using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Hw7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Result
        {
            public int value { get; set; }
        }
        ObservableCollection<Result> results;
        public bool stop = false;
        public int v = 0;

        public MainWindow()
        {
            InitializeComponent();
            results = new ObservableCollection<Result>();
            datagrid.ItemsSource = results;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            stop = false;
            await startTimer();
        }


        private Task startTimer()
        {
            return Task.Run(() =>
            {
                while (!stop)
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        time.Content = v;

                    });
                   
                    Thread.Sleep(1000);
                    v++;
                }

            });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            stop = true;
            v = 0;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            results.Add(new Result { value = v });
            
          
        }
    }
}

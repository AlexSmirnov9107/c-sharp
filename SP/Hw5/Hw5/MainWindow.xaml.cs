using System;
using System.Collections.Generic;
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

namespace Hw5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CancellationTokenSource cancelTokenSource;
        public CancellationToken token;
        public MainWindow()
        {
            InitializeComponent();
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Task task1 = new Task(() =>
            {
            
                while (true)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция прервана");
                        return;
                    }
                    
                }
            });
            task1.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cancelTokenSource.Cancel();
        }
    }
}

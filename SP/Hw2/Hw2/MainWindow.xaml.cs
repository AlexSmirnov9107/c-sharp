using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using System.Xml.Serialization;

namespace Hw2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
//        <title>AUD</title>
//<pubDate>22.05.18</pubDate>
//<description>247.27</description>
//<quant>1</quant>
//<index>UP</index>
//<change>+0.91</change>
//<link/>
        public class Currency
        {
            public string kod { get; set; }
            public double kurs { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(() => {
                //http://www.nationalbank.kz/rss/rates_all.xml

                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString("http://data.egov.kz/api/v2/valutalar_bagamdary4/v320?pretty");

                    var res = JsonConvert.DeserializeObject<Currency[]>(json);
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        datagrid.ItemsSource = res.ToList();
                    });

                }

            }));
            thread.Start();
        }
    }
}

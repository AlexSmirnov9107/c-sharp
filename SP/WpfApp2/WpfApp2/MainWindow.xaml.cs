using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //https://api.nasa.gov/planetary/apod?api_key=mZwDU8Capnd3Ssnb07rVcGYX2cA254Ms1IAR5RI8
        //        {
        //  "date": "2018-05-20", 
        //  "explanation": "In the heart of monstrous Tarantula Nebula lies huge bubbles of energetic gas, long filaments of dark dust, and unusually massive stars. In the center of this heart, is a knot of stars so dense that it was once thought to be a single star. This star cluster, labeled as R136 or NGC 2070, is visible just above the center of the featured image and home to a great number of hot young stars.  The energetic light from these stars continually ionizes nebula gas, while their energetic particle wind blows bubbles and defines intricate filaments.  The representative-color picture, a digital synthesis of images from the NASA/ESA orbiting  Hubble Space Telescope and ESO's ground-based New Technology Telescope, shows great details of the LMC nebula's tumultuous center. The Tarantula Nebula, also known as the 30 Doradus nebula, is one of the largest star-formation regions known, and has been creating unusually strong episodes of star formation every few million years.", 
        //  "hdurl": "https://apod.nasa.gov/apod/image/1805/Tarantula_HubbleLacrue_3204.jpg", 
        //  "media_type": "image", 
        //  "service_version": "v1", 
        //  "title": "In the Heart of the Tarantula Nebula", 
        //  "url": "https://apod.nasa.gov/apod/image/1805/Tarantula_HubbleLacrue_960.jpg"
        //}
        const string url = "https://api.nasa.gov/planetary/apod?api_key=mZwDU8Capnd3Ssnb07rVcGYX2cA254Ms1IAR5RI8";
    public class Response
        {
            public DateTime date { get; set; }
            public string explanation { get; set; }
            public string hdurl { get; set; }
            public string title { get; set; }
            public string url { get; set; }
            

        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            progress.IsIndeterminate = true;
            img.Source = null;
            Response res = await GetData(datepicker.SelectedDate.Value);
            using (var stream = File.OpenRead(AppDomain.CurrentDomain.BaseDirectory + "image.png"))
            {
                var bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.StreamSource = stream;
                bmp.CacheOption = BitmapCacheOption.OnLoad;
                bmp.EndInit();
                img.Source = bmp;
            }

            progress.IsIndeterminate = false;

        }
        private Task<Response> GetData(DateTime d)
        {
            return Task.Run(() =>
            {
                Response res;
                 using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString(url + "&date=" + d.Year + "-" + d.Month + "-" + d.Day);
                    res = JsonConvert.DeserializeObject<Response>(json);
                    wc.DownloadFile(new Uri(res.url), AppDomain.CurrentDomain.BaseDirectory + "image.png");
                }
               
                return res;
            });
        }
    }
}

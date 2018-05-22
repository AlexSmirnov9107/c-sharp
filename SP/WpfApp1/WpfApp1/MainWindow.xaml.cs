using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Image> images = new List<Image>();
            images.Add(imageTemplate);

            int startx = 10, starty = 0;
            for (int i = 0, j = 0; i < 9; i++)
            {
                string imageXML = XamlWriter.Save(imageTemplate);

                StringReader stringReader = new StringReader(imageXML);
                XmlReader xmlReader = XmlReader.Create(stringReader);
                Image newImage = (Image)XamlReader.Load(xmlReader);
                newImage.Name = "image" + i;
                newImage.Margin = new Thickness(startx, starty, newImage.Margin.Bottom, newImage.Margin.Right);
                newImage.Visibility = Visibility.Visible;
                grid.Children.Add(newImage);
                startx += 110;
                if ((i+1) % 3 == 0)
                {
                    j++;
                    startx = 10;
                }
                starty = 110 * j;
            }
        }
        public double maxY = 96;
        public void addImages(int row)
        {
            for (int i = 0, j = 0; i < 3; i++) {
             string imageXML = XamlWriter.Save(imageTemplate);
            StringReader stringReader = new StringReader(imageXML);
            XmlReader xmlReader = XmlReader.Create(stringReader);
            Image newImage = (Image)XamlReader.Load(xmlReader);
            newImage.Name = "image" + i;
            newImage.Margin = new Thickness(i*110, 110*row, newImage.Margin.Bottom, newImage.Margin.Right);
            newImage.Visibility = Visibility.Visible;
            grid.Children.Add(newImage);
        }
        }
        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            Console.WriteLine(e.VerticalOffset);
            if (e.VerticalOffset%96 == 0 && e.VerticalOffset > maxY) {
                maxY = e.VerticalOffset;
             }

        }
    }
}

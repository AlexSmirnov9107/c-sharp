using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace ExplorerApp
{
    public partial class MainWindow : Window
    {
        public List<File> files;

        public MainWindow()
        {
            files = new List<File>();
            InitializeComponent();
            Thread thread = new Thread(new ThreadStart(GetFileList));
            thread.Start();

        }
        private void GetFileList()
        {

            string appDirectory = Directory.GetCurrentDirectory();

            IEnumerable<string> filePaths = Directory.EnumerateFiles(appDirectory);
            IEnumerable<string> catalogPaths = Directory.EnumerateDirectories(appDirectory);

            ObservableCollection<File> newFiles = new ObservableCollection<File>();

            Parallel.ForEach(filePaths, path =>
            {
                FileInfo info = new FileInfo(path);

                File newFile = new File
                {
                    Name = info.Name,
                    CreateDate = info.CreationTime,
                    FilePath = info.FullName,
                    FileType = info.Extension,
                    Image = new BitmapImage(new Uri(appDirectory + "\\File.png"))
                };

                lock (files) files.Add(newFile);
            });

            Parallel.ForEach(catalogPaths, path =>
            {
                DirectoryInfo info = new DirectoryInfo(path);

                File newFile = new File
                {
                    Name = info.Name,
                    CreateDate = info.CreationTime,
                    FilePath = info.FullName,
                    FileType = info.Extension,
                    Image = new BitmapImage(new Uri(appDirectory + "\\Папка.png"))
                };

                lock (files) files.Add(newFile);
            });
            Dispatcher.Invoke(() => {
                foreach (var item in files)
                {
                    DataGridTest.Items.Add(item);
                }


            });
        }
    }
}

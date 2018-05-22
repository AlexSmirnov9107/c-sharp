using System.Windows;
using System.Threading;
using Firebase.Database;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Net;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //2UhKsOLwox93iVlF35ihUAyWTqKMCz0hK8dCADxY sectet fb
        //https://thread-c36d3.appspot.com

        public MainWindow()
        {
            if (File.Exists("logonew.png"))
            {
                File.Delete("logo.png");
                File.Move("logonew.png", "logo.png");
            }

            InitializeComponent();
            Uri iconUri = new Uri("logo.png", UriKind.RelativeOrAbsolute);
            Icon = BitmapFrame.Create(iconUri);
            Thread myThread = new Thread(new ThreadStart(GetUpdates));
            myThread.Start(); // запускаем поток

        }

        public async static void GetUpdates()
        {
            var firebase = new FirebaseClient("https://thread-c36d3.firebaseio.com/");
            var FireBaseFiles = await firebase.Child("files").OnceAsync<FireBaseFile>(); // получаем первые версии файлов
            Dictionary<string, FireBaseFile> files = new Dictionary<string, FireBaseFile>(); // сохранаем в словарь
            foreach (var file in FireBaseFiles)
            {
                files.Add(file.Key, file.Object);
            }
            while (true)
            {
               
                var newFiles = await firebase.Child("files").OnceAsync<FireBaseFile>();
                var changed = false;
                foreach (var file in newFiles)
                {
                    if (files[file.Key].version != file.Object.version) // проверяем на версии
                    {
                        files[file.Key] = file.Object; // синхронизируем файлы
                        changed = true;
                        Console.WriteLine("{0} - {1}", file.Key, file.Object.version);
                        using (var client = new WebClient())
                        {
                            client.DownloadFile(file.Object.url, "logonew.png");
                        }
                    }
                  
                }
                if (changed)
                {
                    System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                    Application.Current.Dispatcher.Invoke(new Action(() =>
                    {
                        Application.Current.Shutdown();
                    }));
                    
                }
                Thread.Sleep(1000);
               
            }
        }
        public class FireBaseFile
        {
            [JsonProperty("version")]
            public int version { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }
        //      public async void GetUpdates()
        //      {
        //          var firebase = new FirebaseClient("https://thread-c36d3.firebaseio.com/");
        //          ///firebase.Child("files").AsObservable<FireBaseFile>().Subscribe(file => Console.WriteLine(file.EventType));
        //          var files = await firebase.Child("files")
        //.OnceAsync<FireBaseFile>();
        //          foreach (var file in files)
        //          {
        //              Console.WriteLine("{0} - {1}",file.Key,file.Object.version);
        //          }
        //          firebase.Child("files").AsObservable<FireBaseFile>().Subscribe(file =>
        //          {
        //              Console.WriteLine("{0} - {1}", file.Key, file.Object.version);
        //          });


        //      }

    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace WpfAppExam
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public ObservableCollection<Check> list { get; set; }
        public Window2()
        {
            DataContext = this;
            DataService.CheckemployeeList = DataService.GetCheckList();
            DataService.CheckemployeeList.CollectionChanged += CheckemployeeList_CollectionChanged;
            list = DataService.GetCheckLisByDate(DateTime.Now.Date);
            InitializeComponent();
          
            //datagrid.ItemsSource = DataService.GetCheckLisByDate(DateTime.Now.Date);
        }
        private void CheckemployeeList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
           DataService.SaveToFileCheck();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = (sender as Calendar).SelectedDate;
            datagrid.ItemsSource = DataService.GetCheckLisByDate(date.Value);
        }
    }
}

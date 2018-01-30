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
using System.Collections.ObjectModel;
namespace WpfAppExam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            DataService.employeeList = DataService.GetEmployees();
            DataService.employeeList.CollectionChanged += EmployeeList_CollectionChanged;
            InitializeComponent();
            datagrid.ItemsSource = DataService.employeeList;
            
          
          
        }

        private void EmployeeList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            DataService.SaveToFile();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {

            Window1 addwindow = new Window1(new Employee(),false);
            addwindow.ShowDialog();
            
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedIndex > -1)
            {
                Window1 addwindow = new Window1(DataService.employeeList[datagrid.SelectedIndex], true);
                addwindow.ShowDialog();
            }
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedIndex > -1)
            {
                MessageBoxResult mbresult = MessageBox.Show("Are you sure?", "Delete employee?", MessageBoxButton.YesNo);
                if (mbresult == MessageBoxResult.Yes)
                {
                    DataService.employeeList.RemoveAt(datagrid.SelectedIndex);
                }
                
               
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.ShowDialog();
        }
    }
}

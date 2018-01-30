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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Employee emp { get; set; }
        private bool IsEdit;
        public Window1(Employee emp,bool Edit)
        {
            DataContext = this;
            this.IsEdit = Edit;
            this.emp = emp;
            InitializeComponent();

         


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataService.SaveEmployee(this.emp, !IsEdit);
            Close();
        }
    }
}

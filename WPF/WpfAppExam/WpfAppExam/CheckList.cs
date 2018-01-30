using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExam
{
    public class Check: INotifyPropertyChanged
    {
        private bool ispresent = false; 
        public DateTime DateCheck { get; set; }
        public Employee Employee { get; set; }
        public bool IsPresent {
            get
            {
                return ispresent;
            }
            set
            {
                if (DateCheck.Date <= DateTime.Now.Date)
                {
                    ispresent = value;
                    if (PropertyChanged != null)
                    {
                        DataService.SaveToFileCheck();
                    }
                }
            }
        }

      
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

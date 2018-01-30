using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExam
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public Employee()
        {
            this.FullName = "";
            this.Position = "";
        }
        public override string ToString()
        {
            return this.FullName;
        }
    }
}

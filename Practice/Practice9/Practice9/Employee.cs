using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public struct Employee
    {
        public string Name { get; set; }
        public Vacancies Vacancy { get; set; }
        public int  Salary { get; set; }
        public int[] DateGet { get; set; }
        public Employee(string name,Vacancies vacancy,int salary,int[] dateGet)
        {
            Name = name;
            Vacancy = vacancy;
            Salary = salary;
            DateGet = dateGet;
        }
    }
}

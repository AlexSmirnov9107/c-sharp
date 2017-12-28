using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{

    public enum Sex
    {
        FEMALE,
        MALE
    }
    public enum EducationType
    {
        Edu1,
        Edu2
    }
    public struct Student
    {

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string GroupName { get; set; }
        public double AvgValue { get; set; }
        public int ParentsSalary { get; set; }
        public Sex Sex { get; set; }
        public EducationType EduType { get; set; }

    }
}
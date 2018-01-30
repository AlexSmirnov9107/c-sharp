using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExam
{
    public static class DataService
    {
        public static ObservableCollection<Employee> employeeList;
        public static ObservableCollection<Check> CheckemployeeList;

        public static void SaveEmployee(Employee employee, Boolean isNew = false)
        {
            if (isNew)
            {
                employeeList.Add(employee);

            }
        }

        public static void SaveToFile()
        {
            using (StreamWriter file = File.CreateText("employees.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, employeeList);

            }
        }
        public static ObservableCollection<Employee> GetEmployees()
        {
            ObservableCollection<Employee> list = new ObservableCollection<Employee>();
            if (File.Exists("employees.json"))
                using (StreamReader stream = new StreamReader("employees.json"))
                {

                    list = JsonConvert.DeserializeObject<ObservableCollection<Employee>>(stream.ReadToEnd());
                }
            return list;
        }
        public static void SaveToFileCheck()
        {
            using (StreamWriter file = File.CreateText("employees_check.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, CheckemployeeList);

            }
        }
        public static ObservableCollection<Check> GetCheckList()
        {
            ObservableCollection<Check> list = new ObservableCollection<Check>();
            if (File.Exists("employees_check.json"))
                using (StreamReader stream = new StreamReader("employees_check.json"))
                {
                    list = JsonConvert.DeserializeObject<ObservableCollection<Check>>(stream.ReadToEnd());
                }
            return list;
        }
        public static ObservableCollection<Check> GetCheckLisByDate(DateTime date)
        {
            var list = CheckemployeeList.Where(item => item.DateCheck == date).ToList();
            if (list.Count == 0)
            {
                foreach (var item in employeeList)
                {
                    Check userForCheck = new Check() { DateCheck = date, Employee = item };
                    CheckemployeeList.Add(userForCheck);
                    list.Add(userForCheck);
                }
               
            }
            
            return  new ObservableCollection<Check>(list);
        }

  
    }
}

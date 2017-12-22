using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Additionals.Person newPerson = new Additionals.Person();
            newPerson.Name = "Ivan";
            newPerson.LastName = "Ivanov";
            Console.WriteLine(Additionals.Person.GetInfo(newPerson));

            MyStrings mystrings = new MyStrings();

            Console.WriteLine(mystrings.GetAge());
            Console.WriteLine(mystrings.GetCity());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork18
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.С помощью рефлексии получить список методов класса Console и вывести на экран.
            //2.Описать класс с несколькими свойствами. Создать экземпляр класса и инициализировать его свойства.С помощью рефлексии получить свойства и их значения из созданного экземпляра класса. Вывести полученные значения на экран
            Type type = Type.GetType("System.Console");
            foreach (var method in type.GetMethods())
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine("-----------------------------------");


            SomeClass someclass = new SomeClass(15, "Вуася");
            Type type2 = someclass.GetType();
            foreach (var prop in type2.GetProperties())
            {
                Console.WriteLine(prop.Name + " = " +prop.GetValue(someclass));
            }
            Console.ReadKey();
        }
    }
}

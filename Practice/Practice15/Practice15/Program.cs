using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice15
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomObject obj = new CustomObject();
            obj.Propertychanged += WatchChanges;
            obj.Count = 5;
            Console.ReadLine();

        }

        private static void WatchChanges(object sender, PropertyeventArgs args)
        {
            Console.WriteLine("{0} изменил {1} на {2}", sender.GetType().ToString(), e.name, e.value.ToString());
        }
    }
}

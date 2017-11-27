using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass cls = new MyClass();
            Console.WriteLine(cls.SayMyName("Alex"));
            try
            {
                cls.SayMyName("");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            
        }
    }
}

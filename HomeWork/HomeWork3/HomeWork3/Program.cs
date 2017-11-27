using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {

            Car[] cars = new Car[5];
            cars[0] = new Car("MB", "GLK", 2015, 2.0, "Brown");
            cars[1] = new Car("MB", "GLK", 2016, 2.0, "Brown");
            cars[2] = new Car("MB", "GLK", 2014, 2.0, "Brown");
            cars[3] = new Car("MB", "GLK", 2013, 2.0, "Brown");
            cars[4] = new Car("MB", "GLK", 2017, 2.0, "Brown");
            Console.WriteLine(Car.oldestCar.GetYear());
            Console.ReadKey();
        }
    }
}

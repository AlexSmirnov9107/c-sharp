using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prartice1
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo1();
            ToDo2();
            Console.ReadKey();
        }

        private static void ToDo2()
        {
            Console.WriteLine("2.Дан радиус окружности. Найти длину окружности и площадь круга");
        }

        private static void ToDo1()
        {
            Console.WriteLine("вычисления значения функции y = 7x ^ 2 - 3x + 4  при любом значении x;");
            Console.Write("Введите x ->");
            int x = int.Parse(Console.ReadLine());
            int y = 7 * x * x  - 3 * x + 4;
            Console.Write("y = {0:G} ", y);

        }
    }
}

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
            ToDo3();
            ToDo4();
            ToDO5();
            Console.ReadKey();
        }

        private static void ToDO5()
        {
            Console.WriteLine("5.	Дано двузначное число. Найти:\n" +
                "a.число десятков в нем;\n" +
                "b.число единиц в нем;\n" +
                "c.сумму его цифр;\n" +
                "d.произведение его цифр\n");
            Console.Write("Введите двухзначное число ->");
            int chislo = int.Parse(Console.ReadLine());
            int firstChislo = chislo / 10;
            int secondChislo = chislo - firstChislo*10;
            count1 = (chislo - desyat * 10) == 1 ? count1++ : count1;

            
        }

        private static void ToDo4()
        {
            Console.WriteLine("4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");
            Console.Write("Введите кол-во дней ->");
            int days = int.Parse(Console.ReadLine());
            int weeks = days / 7;
            Console.Write("Кол-во полных недель = {0:G} \n", weeks);
        }

        private static void ToDo3()
        {
            Console.WriteLine("3.	Дано расстояние в сантиметрах. Найти число полных метров в нем");
            Console.Write("Введите расстояние -> ");
            int distance = int.Parse(Console.ReadLine());
            int m = distance / 100;
            Console.Write("Полных метров = {0:G} \n", m);
        }

        private static void ToDo2()
        {
            Console.WriteLine("2.Дан радиус окружности. Найти длину окружности и площадь круга");
            Console.Write("Введите радиус окружности ->");
            int radius = int.Parse(Console.ReadLine());
            int diametr = radius * 2;
            double dlina = diametr * Math.PI;
            double ploshad = (radius * radius) * Math.PI;
            Console.Write("Длина окружности = {0:G} \n", dlina);
            Console.Write("Площадь  = {0:G} \n", ploshad);

        }

        private static void ToDo1()
        {
            Console.WriteLine("вычисления значения функции y = 7x ^ 2 - 3x + 4  при любом значении x;");
            Console.Write("Введите x ->");
            int x = int.Parse(Console.ReadLine());
            int y = 7 * x * x  - 3 * x + 4;
            Console.Write("y = {0:G} \n", y);

        }
    }
}

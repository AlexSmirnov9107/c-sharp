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
            Console.Write("Введите номер задания (1-8) ->");
            switch (Console.ReadLine())
            {
                case "1":
                    ToDo1();
                    break;
                case "2":
                    ToDo2();
                    break;
                case "3":
                    ToDo3();
                    break;
                case "4":
                    ToDo4();
                    break;
                case "5":
                    ToDo5();
                    break;
                case "6":
                    ToDo6();
                    break;
                case "7":
                    ToDo7();
                    break;
                case "8":
                    ToDo8();
                    break;

            }

           
            Console.ReadKey();
        }

        private static void ToDo8()
        {
            Console.WriteLine("8.	Вычислить значение логического выражения при всех возможных значениях логических величин X и Y: \n a.	не X и не Y; \n b.	X или (не X и Y); \n c.	(не X и Y) или Y. \n \n");
            bool x = false;
            bool y = true;
            Console.Write("X = {0:G}\nY = {1:G}\n", x, y);

            Console.Write("не X и не Y = {0:G}\n", !x && !y);
            Console.Write("X или (не X и Y) = {0:G}\n", !x || (!x && !y));
            Console.Write("(не X и Y) или Y = {0:G}\n", (!x && y) || y);



        }

        private static void ToDo7()
        {
            Console.WriteLine("7.	В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456. Найти число x");
            Console.Write("Введите трехзначное число ->");
            int chislo = int.Parse(Console.ReadLine());
            int first = chislo / 100;
            int second = (chislo % 100) / 10;
            int third = chislo % 10;
            Console.Write("x = {0:G}{1:G}{2:G}", first, third, second);
        }

        private static void ToDo6()
        {
            Console.WriteLine("6.	Дано четырехзначное число. Найти: \na.сумму его цифр;\nb.произведение его цифр.");
            Console.Write("Введите четырехзначное число ->");
            int chislo = int.Parse(Console.ReadLine());
            int first = chislo / 1000;
            int second = (chislo % 1000) / 100;
            int third = ((chislo % 1000) % 100) / 10;
            int fourth = chislo % 10;
            int sum = first + second + third + fourth;
            int multi = first * second * third * fourth;
            Console.Write("а. Сумма = {0:G}\n", sum);
            Console.Write("а. Произведение = {0:G}\n", multi);

        }

        private static void ToDo5()
        {
            Console.WriteLine("5.	Дано двузначное число. Найти:\n" +
                "a.число десятков в нем;\n" +
                "b.число единиц в нем;\n" +
                "c.сумму его цифр;\n" +
                "d.произведение его цифр\n");
            Console.Write("Введите двухзначное число ->");
            int chislo = int.Parse(Console.ReadLine());
            int firstChislo = chislo / 10;
            int secondChislo = chislo - firstChislo * 10;
            int count1 = firstChislo == 1 ? 1 : 0;
            count1 = secondChislo == 1 ? count1++ : count1;
            int sum = firstChislo + secondChislo;
            int multiply = firstChislo * secondChislo;
            Console.Write("a. Десятков = {0:G}\n", firstChislo);
            Console.Write("b. Число единиц = {0:G}\n", count1);
            Console.Write("c. Сумма цифр = {0:G}\n", sum);
            Console.Write("d. Произведение = {0:G}\n", multiply);


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

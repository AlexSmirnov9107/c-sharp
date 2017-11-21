using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания (1-10) -> ");
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
                case "9":
                    ToDo9();
                    break;
                case "10":
                    ToDo10();
                    break;
                


            }
            Console.ReadKey();
        }

        private static void ToDo10()
        {
            Console.WriteLine("Напечатать \"столбиком\": \n" +
                " a.все целые числа от 20 до 35\n" +
                " b.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);\n" +
                " c.третьи степени всех целых чисел от a до 50(значение a вводится с клавиатуры; a < 50);\n" +
                " d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).");


            //a.все целые числа от 20 до 35
            Console.WriteLine("a -> ");
            for(int i= 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }

            //b.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10)
            Console.Write("Введиите b -> ");
            int b = int.Parse(Console.ReadLine());
            if (b < 10)
                b = 11;
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(i*i);
            }


            //c.третьи степени всех целых чисел от a до 50(значение a вводится с клавиатуры; a < 50);
            Console.Write("Введиите a -> ");
            int a = int.Parse(Console.ReadLine());
            if (a > 50)
                a = 50;
            for (int i = a; i < 50; i++)
            {
                Console.WriteLine(i * i*i);
            }


            //d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).
            Console.Write("Введиите a -> ");
            int aStart = int.Parse(Console.ReadLine());
            Console.Write("Введиите b -> ");
            int bEnd = int.Parse(Console.ReadLine());
            if (bEnd < aStart)
                bEnd = aStart + 1;
            for (int i = aStart; i <= bEnd; i++)
            {
                Console.WriteLine(i * i);
            }
        }

        private static void ToDo9()
        {
            Console.WriteLine("9. Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток");
            Console.Write("Введите сопротивление №1 ->");
            int r1 = int.Parse(Console.ReadLine());
            Console.Write("Введите напряжение №1 ->");
            int u1 = int.Parse(Console.ReadLine());

            Console.Write("Введите сопротивление №2 ->");
            int r2 = int.Parse(Console.ReadLine());
            Console.Write("Введите напряжение №2 ->");
            int u2 = int.Parse(Console.ReadLine());

            double I1 = u1 / r1;
            double I2 = u2 / r2;

            Console.Write("Сила тока №1  = {0:G} \n", I1);
            Console.Write("Сила тока №2  = {0:G} \n", I2);
            if (I1 < I2)
            {
                Console.Write("Сила тока на №1 меньше");
            }
            else if (I2 < I1)
            {
                Console.Write("Сила тока на №2 меньше");
            }
            else
            {
                Console.Write("Силы тока равны");
            }
        }

        private static void ToDo8()
        {
            Console.WriteLine("8. Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?");
            Console.Write("Введите обьем тела №1 ->");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Введите массу тела №1 ->");
            int m1 = int.Parse(Console.ReadLine());

            Console.Write("Введите обьем тела №2 ->");
            int v2= int.Parse(Console.ReadLine());
            Console.Write("Введите массу тела №2 ->");
            int m2 = int.Parse(Console.ReadLine());

            double p1 = m1 / v1;
            double p2 = m2 / v2;

            Console.Write("Плотность тела №1  = {0:G} \n", p1);
            Console.Write("Плотность тела №2  = {0:G} \n", p2);
            if (p1 > p2)
            {
                Console.Write("Плотность тела №1 больше");
            }
            else if (p2 > p1)
            {
                Console.Write("Плотность тела №2 больше");
            }
            else
            {
                Console.Write("Плотности равны");
            }

        }

        private static void ToDo7()
        {
            Console.WriteLine("7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше");
            Console.Write("Введите радиус окружности ->");
            int radius = int.Parse(Console.ReadLine());
            double ploshadKruga = (radius * radius) * Math.PI;

            Console.Write("Введите сторону квадрата");
            int storona = int.Parse(Console.ReadLine());
            int ploshadKvadrata = storona * storona;

            Console.Write("Площадь круга  = {0:G} \n", ploshadKruga);
            Console.Write("Площадь квадрата  = {0:G} \n", ploshadKvadrata);
            if (ploshadKruga > ploshadKvadrata)
            {
                Console.Write("Площадь круга больше");
            }
            else if (ploshadKvadrata > ploshadKruga)
            {
                Console.Write("Площадь квадрта больше");
            }
            else
            {
                Console.Write("Площади равны");
            }

        }

        private static void ToDo6()
        {
            Console.WriteLine("6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:");
            bool A = true;
            bool B = false;
            bool C = false;
         

            Console.Write("a.	А или В = {0:G}\n", A || B);
            Console.Write("b.	А и В = {0:G}\n", A && B);
            Console.Write("c.	В или С = {0:G}\n", B || C);
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
            Console.WriteLine("2.Вывести на экран числа 5, 10 и 21 одно под другим..");
            Console.Write("{0:G}\n{1:G}\n{2:G}", 5, 10, 21);
        }

        private static void ToDo1()
        {
            Console.WriteLine("1. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.");
            Console.Write("{0:G} {1:G} {2:G}",123,456,789);
        }
    }
}

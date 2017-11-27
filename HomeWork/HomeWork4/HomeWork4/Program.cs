using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
  
    class Program
    {
        
        static public double Divison(object a, object b=null)
        {
            //1.	реализовать метод деления двух чисел. Внутри метода проверять входящие параметры. Если они не заданы, то генерировать исключение ArgumentNullException. Если делитель равен нулю, то генерировать исключение ArgumentException.
            if (a == null || b == null) throw new ArgumentNullException("Нет аругментов");
            if ((int)b == 0) throw new ArgumentException("Деление на ноль!");
            return (int)a / (int)b;
        }
        static public int GetValByIndex(int i)
        {
            int[] arr = new int[4] { 1,2,3,4};

            if (i > 3)
            {
                throw new Exception("Выход за границы массива");
            }

            return arr[i];
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Divison(5, 2));
                Console.WriteLine(Divison(null, null));
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(GetValByIndex(4));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Завершена обработка массива");
            }
            Console.ReadKey();
        }
    }
}

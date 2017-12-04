using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {

        //1.	Создать индексатор для одномерного массива который при установке значения 
        //будет возводить в квадрат передаваемое значение переменной и устанавливать
        //его для указанного индекса. При получении элемента массива по индексу будет возвращаться его текущее значение

        static void Main(string[] args)
        {
            MyArray10 arr = new MyArray10();
            arr[0] = 2;
            Console.WriteLine(arr[0]);
            Console.ReadKey();
        }
    }
}

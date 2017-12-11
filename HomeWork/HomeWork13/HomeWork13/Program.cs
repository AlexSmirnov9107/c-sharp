using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            ///1.Создать коллекцию List<int> .Вывести на экран позицию и значение элемента, являющегося вторым максимальным значением в коллекции.Вывести на экран сумму элементов на четных позичиях.
            List<int> array = new List<int>() { 1,2,4,5,6,7,8,8,10,21,3,4,5,6,7,8,9 };
            List<int> array2 = new List<int>(array);
            array2.Sort();
            int max2 = array2[array2.Count - 2];
            int pos = array.IndexOf(max2);
            Console.WriteLine("Макс элемент {0} на позиции {1}",max2,pos);

            Console.ReadLine();
        }
    }
}

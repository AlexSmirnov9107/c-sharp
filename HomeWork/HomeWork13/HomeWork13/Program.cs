using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList() {
                1,2,3,4,5,6
            };
            int sum = 0;
            for (int i = 0; i < array.Count; i++)
            {
                sum += (int)array[i];
                if ((int)array[i] % 2 == 1) // 
                    array.RemoveAt(i); // Удаляем Нечетные
            }
            foreach (var item in array)
            {
                if ((int)item > sum / array.Count) // Элементы больше среднеарифметического
                    Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

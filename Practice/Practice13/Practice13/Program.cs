﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList() {
                1,2,3,4,5,6
            };
            ArrayList tmp = new ArrayList();
            int sum = 0;
            for (int i = 0; i < array.Count; i++)
            {
                sum += (int)array[i];
                if ((int)array[i] % 2 == 0) // 
                    tmp.Add(array[i]); // четные
            }
            array.Clear();
            array.SetRange(0, tmp);
            foreach (var item in array)
            {
                if ((int)item > sum/array.Count) // Элементы больше среднеарифметического
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

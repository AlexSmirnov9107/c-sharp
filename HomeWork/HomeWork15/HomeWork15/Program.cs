using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader stream = new StreamReader("fibo.txt"))
            {
                string inputStr = stream.ReadLine();
                var numbers = inputStr.Split(' ').ToList();
                int count = numbers.Count;
                for (int i = 0; i < count ; i++)
                {
                    int number = int.Parse(numbers[numbers.Count - 2]) + int.Parse(numbers[numbers.Count - 1]);
                    numbers.Add(number.ToString());
                }
                int sum = 0;
                foreach (var item in numbers)
                {
                    sum += int.Parse(item);
                    Console.Write(item + " ");
                }

                using (StreamWriter streamWriter = new StreamWriter("OUTPUT.txt"))
                {
                    
                    streamWriter.WriteLine(sum);    
                                                        
                }

                Console.ReadKey();
            }

        }
    }
}

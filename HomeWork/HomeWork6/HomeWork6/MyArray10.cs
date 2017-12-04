using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public class MyArray10
    {
        public MyArray10()
        {
            mas = new int[10];
        }
        public int[] mas;

        public int this[int index]
        {
            get
            {
                return mas[index];
            }
            set
            {
                mas[index] = value * value;
            }
        }
    }
}

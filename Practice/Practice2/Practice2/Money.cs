using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Money
    {
        private int nominal;
        private int count;

        public Money(int nominal,int count)
        {
            this.nominal = nominal;
            this.count = count;
        }

        public int GetMoney()
        { 
            Console.WriteLine($"{nominal} x {count} KZT = {count * nominal}");
            return count * nominal;
        }

        public bool IsEnough(int summa)
        {
            return summa < count * nominal ? true : false;
        }
        public int HowMany(int price)
        {
            return count * nominal / price;
        }
        public int GetNominal()
        {
            return nominal;
        }
        public void SetNominal(int nominal)
        {
            this.nominal= nominal;
        }
        public int GetCount()
        {
            return count;
        }

        public void SetCount(int count)
        {
            this.count = count;
        }
        
    }
}

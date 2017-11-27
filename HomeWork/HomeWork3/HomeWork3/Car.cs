using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    partial class Car
    {
        static public int countCars;
        static public Car oldestCar;
        private string vendor;
        private string mark;
        private int year;
        private double capacity;
        private string color;

        static Car()
        {
            countCars = 0 ;
            oldestCar = null;
        }
        public Car()
        {
           year= 1991;
           countCars++;
        }
        public Car(string vendor,string mark, int year, double capacity, string color)
        {
            countCars++;
            this.vendor = vendor;
            this.mark = mark;
            this.year = year;
            this.capacity = capacity;
            this.color = color;

            if (oldestCar != null)
            {
                if (oldestCar.GetYear() > year)
                {
                    oldestCar = this;
                }

            }
            else
            {
                oldestCar = this;
            }
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public int GetYear()
        {
            return year;
        }
        public void SetYear(int year)
        {
          
            this.year = year;
        }
        public void GetCountCars(out int count)
        {
            count = countCars;
        }
    }
}

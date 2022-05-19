using System;
using System.Collections.Generic;
using System.Text;

namespace video7_lesson_
{
     public abstract class Vehicle
    {
        public string color { get; set; }
        public string brand { get; set; }
        public double Millage { get; set; }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"{brand} " +
                $"{color} " +
                $"{Millage}");
        }
        public abstract void Drive(double km);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace video7_lesson_
{
    class Car : Vehicle
    {
        public double FullCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelForm { get; set; }

        public override void Drive(double km)
        {
            if (CurrentFuel> km* FuelForm)
            {
                Millage += km;
                CurrentFuel -= km * FuelForm;
                Console.WriteLine("getdi");
            }
            else
            {
                Console.WriteLine("benzinin azdir");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace video3
{
    public  class Cars
    {
        public string Name;
        public int DoorCount;
        public double MotorGucu;
        public static double MotorGucu2;
        public void Motor()
        {
            Console.WriteLine(Name+ " " +$"gucu {MotorGucu} atla hesablanir");
        }
        public static void Motor2()
        {
            Console.WriteLine( "gucu atla hesablanir");
        }
    }
}

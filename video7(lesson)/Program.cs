using System;

namespace video7_lesson_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Car c = new Car();
            Bycle b = new Bycle();
            c.FullCapacity = 16;
            c.CurrentFuel = 45;
            c.FuelForm = 2;

            c.Drive(20);
            Console.WriteLine("------------------");
            Console.Write("");
            b.Drive(20);
            #endregion
            //Milk milla = new Milk("Milla")
            //{
            //    Price = 1.5,
            //    Count = 60,
            //    Volume = 1.5,
            //    FatRate = 2
            //};
            //milla.Sell(3);
            //milla.Sell(4);
            //milla.Sell(30);

        }
    }
}

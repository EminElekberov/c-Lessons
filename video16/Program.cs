using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video16
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperatur tem = new Temperatur();
            tem.tempertureBelow += Check;
            tem.Temp = 18;
            Console.ReadKey();
        }
        public static void Check(int x)
        {
            Console.WriteLine("20 dereceden asagidir");
        }
    }
    class Temperatur
    {
        public delegate void TemperatureHandler(int temp);
        public event TemperatureHandler tempertureBelow;
        private int temp;
        public int Temp
        {
            get
            {
                return temp;
            }
            set
            {
                if (value!=0)
                {
                    temp = value;
                    if (temp<20)
                    {
                        tempertureBelow?.Invoke(temp);
                    }
                }
            }
        }
    }
}

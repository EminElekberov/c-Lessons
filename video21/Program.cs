using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video21
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
                BaseGC oBaseGC = new BaseGC();
                Console.WriteLine("BaseGC Generation is :" + GC.GetGeneration(oBaseGC)); //Returns the current generation number of an object.
                Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
            }
            catch (Exception oEx)
            {
                Console.WriteLine("Error:" + oEx.Message);
            }
            #region
            //for (int i = 0; i < 100; i++)
            //{
            //    for (int a = 0; a < 10000; a++)
            //    {
            //        System.IO.Path.GetRandomFileName();
            //        System.IO.Path.GetRandomFileName();
            //    }
            //    System.Threading.Thread.Sleep(1);
            //}
            //for (int i = 0; i <= GC.MaxGeneration; i++)
            //{
            //    int count = GC.CollectionCount(i);
            //    Console.WriteLine("generations of objects "+count);
            //}
            #endregion
            Console.ReadLine();
       }
    }
    public class BaseGC
    {
        public void Display()
        {
            Console.WriteLine("Example Method");
        }
    }
}

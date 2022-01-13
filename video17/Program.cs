using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace video17
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Process p = new Process();
            //p.StartInfo.FileName = "calc.exe";
            //p.StartInfo.Arguments = "";
            //p.Start();
            //Console.ReadKey();
            #endregion
            //Process.Start("https://medium.com/@eminelekberov09");

            #region
            //var process = Process.GetCurrentProcess();
            //Console.WriteLine(process);
            //Console.ReadKey();
            #endregion

            #region
            //var process = Process.GetProcesses();
            //foreach (var item in process)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            #endregion

            #region
            //Console.WriteLine("search data");
            //string data = Console.ReadLine();
            //Process.Start($"https://www.google.com/search?q="+data);
            //Console.ReadKey();
            #endregion

            #region
            //Thread t = new Thread(Y);
            //t.Start();
            //X();
            #endregion

            //Thread t = new Thread(Y1);
            //t.IsBackground = true;//menasi odurki bizim main threadimiz yeni x isini bitirdikdden sonra diger threadida saxlasin
            //t.Start();
            //X1();
        }
        public static void X()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("XXXXXXXXX");
            }
        }
        public static void Y()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Y");
            }
        }
        public static void X1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("XXXXXXXXX");
            }
        }
        public static void Y1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Y");
            }
        }
    }
}

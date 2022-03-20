using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace video19
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //ThreadPool.QueueUserWorkItem(X);
            //Console.WriteLine("dredec");
            //Console.WriteLine("drffopjvojvop");
            //Console.ReadKey();
            #endregion

            #region
            Console.WriteLine(Y());
            Console.ReadKey();
            #endregion

            #region
            Task task = new Task(CallMethod);
            //task.Start();
            //task.Wait();
            //Console.ReadLine();
            #endregion
            // WriteToFile();
            WriteToFile2();
        }
        #region
        public static async void CallMethod()
        {
            string file = "D:\\qasimc#\\mina_teacher\\newtext.txt";
            var total = await ReadFile(file);
            var write = await WriteFile(file);
            Console.WriteLine("1workk");
            Console.WriteLine("2workk");
            Console.WriteLine("3workk");
            Test();
            Console.WriteLine(total);
            Console.WriteLine(write);
            Console.WriteLine("after work 1");
        }
        public static void Test()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " test");
            }
        }
        static async Task<int> ReadFile(string file)
        {
            int lenght = 0;
            Console.WriteLine("start file is reading ");
            using (StreamReader streamReader = new StreamReader(file))
            {
                string s = await streamReader.ReadToEndAsync();
                lenght = s.Length;

            }
            Console.WriteLine("read end");
            return lenght;
        }
       
        static int Y()
        {
            int x = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int z = 0; z < 100000; z++)
                {
                    x = i + z;
                }
            }
            return x;
        }
        public static void X(object state)
        {
            Console.WriteLine("hello");
            //
        }
        #endregion
        static async Task<string> WriteFile(string file)
        {
            string s1;
            Console.WriteLine("start file is reading ");
            using (StreamReader streamReader = new StreamReader(file))
            {
                string s = await streamReader.ReadToEndAsync();
                s1 = s;

            }
            Console.WriteLine("read end");
            return s1;
        }
        public static void WriteToFile()
        {
            using (StreamWriter sw = File.CreateText(@"D:\text.txt"))
            {
                sw.WriteLine("Please find the below generated table of 1 to 10");
                sw.WriteLine("");
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        sw.WriteLine("{0}x{1}= {2}", i, j, (i * j));
                    }
                    sw.WriteLine("==============");
                }
                Console.WriteLine("Table successfully written on file.");
            }
        }
        public static void WriteToFile2()
        {
            using (StreamWriter sw = File.CreateText(@"D:\text2.txt"))
            {
                sw.WriteLine("Please find the below generated table of 1 to 10");
                sw.WriteLine("");
                string s = Console.ReadLine();
                sw.WriteLine(s);
                Console.WriteLine("Table successfully written on file.");
            }
        }
    }
}

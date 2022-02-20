using System;
using System.Threading;

namespace video18
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <10; i++)
            {
                new Thread(() => Console.WriteLine(i)).Start();
            }
        }
    }
}

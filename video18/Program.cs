using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

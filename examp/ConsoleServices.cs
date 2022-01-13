using System;
using System.Collections.Generic;
using System.Text;

namespace examp
{
    class ConsoleServices
    {
        public void OnGameRecorded(object sender,GameEnevtArgs args)
        {
            Console.WriteLine($"print on console {args.Game.name}");
        }
    }
}

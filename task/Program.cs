using System;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phone = new PhoneBook();
            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                phone.NameParametr(name);
                string number = Console.ReadLine();
                phone.NumberParametr(number);
            }
            
        }
    }
}

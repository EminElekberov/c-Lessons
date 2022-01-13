using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class PhoneBook
    {
        private readonly Dictionary<string, string> _phoneBook = new Dictionary<string, string>();
        public void AddPerson(string name, string number)
        {
            if (_phoneBook.ContainsKey(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{name} is exist");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Select option: \n 1.Keep the number \n 2.Update");
                string option = Console.ReadLine();
                while (option != "1" && option != "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Pls  select correct option");
                    Console.ForegroundColor = ConsoleColor.White;
                    option = Console.ReadLine();
                }
                if (option == "2")
                {
                    _phoneBook[name] = number;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{number} successfully updated");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                _phoneBook.Add(name, number);
                Console.WriteLine($"{name} with {number} added");
            }
        }
        public void NameParametr(string name1)
        {
            if (_phoneBook.ContainsKey(name1))
            {
                Console.WriteLine(_phoneBook[name1]);
            }
            else
            {
                Console.WriteLine("bu adda kimse yoxdur");
            }
        }
        public void NumberParametr(string number1)
        {
            if (_phoneBook.ContainsValue(number1)){
                foreach (var item in _phoneBook.Keys)
                {
                    if (_phoneBook[item]==number1)
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.WriteLine(_phoneBook.Keys);
            }
            else
            {
                Console.WriteLine("");
            }
        }
        public void RemoveByName(string nm)
        {
            if (_phoneBook.ContainsKey(nm))
            {
                foreach (var item in _phoneBook)
                {
                    if (_phoneBook[item]==nm)
                    {
                        Console.WriteLine(_phoneBook.Remove(nm));
                    }
                }
            }
        }
        public void RemoveByNumber(string number)
        {
            if (_phoneBook.ContainsValue(number))
            {
                foreach (var item in _phoneBook)
                {
                    if (_phoneBook[number] == number)
                    {
                        Console.WriteLine(_phoneBook[number].Remove(0));
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ex
{
    public class Medicine
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public static double _totalInCome { get; set; }
        public Medicine(string name, int count,double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
    }
}

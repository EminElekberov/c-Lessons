using System;
using System.Collections.Generic;
using System.Text;

namespace video7_lesson_
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        private int TotalIncome { get; set; }
        public int Count { get; set; }
        private double _totalInCome { get; set; }
        public Product(string name)
        {
            Name = name;
        }
        public void Sell(int buyProductCount)
        {
            if (Count >= buyProductCount)
            {
                Count -= buyProductCount;
                double resultPrice = buyProductCount * Price;
                _totalInCome += resultPrice;
                Console.WriteLine($"{buyProductCount} mehsul satildi ve umumi qiymet{resultPrice} manat, " +
                    $"bazada ise umumi satisdan elde edilen gelir{_totalInCome} manat");

            }
            else
            {
                Console.WriteLine($"Bazada {Count} mehsul var, sizin isteyinize uygun deyil");
            }
        }
    
   
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace video4
{
    class Product
    {
        #region Numune 1
        //public string Name;
        //public double Price;
        //public double DiscountPrize;
        //public string Code;
        //public static int No=1000;
        //public Product(string name,double price,double discountPrize)
        //{
        //    Name = name;
        //    Price = price;
        //    DiscountPrize = discountPrize;
        //    string x = name.Substring(0, 1);
        //    No++;
        //    Code = x + No;
        //}
        #endregion


        public string Name;
        public double Price;
        public double DiscountPrize;
        public string Code;
        public static int No = 1000;
        public double TotalPrice;
        public Product(string name, double price, double discountPrize)
        {
            Name = name;
            Price = price;
            DiscountPrize = discountPrize;
            string x = name.Substring(0, 1);
            No++;
            Code = x + No;
        }
        public double GetTotalPrice()
        {
            double y = (this.Price * this.DiscountPrize) / 100;
            this.TotalPrice = Price - y;
            return TotalPrice;
        }
    }
}

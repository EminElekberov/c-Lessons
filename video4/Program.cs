using System;

namespace video4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region numune 1
            //Product product = new Product("bakery", 20, 3);
            //Console.WriteLine(product.Code);

            #endregion

            Product pr = new Product("bakery", 20, 3);
            pr.GetTotalPrice();
            Console.WriteLine(pr.Code);
            Console.WriteLine(pr.TotalPrice);
        }
    }
}

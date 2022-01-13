using System;

namespace tasklesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //    Print pr = new Print(TranslateMonthName());
            //}
            //public delegate void Print();
            //public static void TranslateMonthName(byte Month)
            //{
            //    Console.WriteLine("1-12 arasinda reqem secin");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    if (number<=12)
            //    {
            //        Console.WriteLine("bir ay secin /n" +
            //        " 1) january /n" +
            //        " 2) February");
            //        string answer = Console.ReadLine();
            //        switch (answer)
            //        {
            //            case "1":
            //                Show();
            //                break;
            //            case "2":
            //                ShowFebruary();
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(" 1 ve 12 arasinda deyer girilmelidir");
            //    }

            //}
            //public static void Show()
            //{
            //    Console.WriteLine("hansi bilgileri bilmek isdeyirsiniz /n" +
            //        "1) ayin cevrilmis adi /n" +
            //        "2) sezonun adi");
            //    string select = Console.ReadLine();
            //    switch (select)
            //    {
            //        case "1":
            //            Console.WriteLine("sezonun adi: yanvar");
            //            break;
            //        case "2":
            //            Console.WriteLine("sezonun adi qis");
            //            break;
            //        default:
            //            break;
            //    }
            //}
            #endregion
            #region
            //public static void ShowFebruary()
            //{
            //    Console.WriteLine("hansi bilgileri bilmek isdeyirsiniz /n" +
            //        "1) ayin cevrilmis adi /n" +
            //        "2) sezonun adi");
            //    string select = Console.ReadLine();
            //    switch (select)
            //    {
            //        case "1":
            //            Console.WriteLine("sezonun adi: Fevral");
            //            break;
            //        case "2":
            //            Console.WriteLine("sezonun adi qis");
            //            break;
            //        default:
            //            break;
            //    }
            //}
            #endregion
            Check ch = new Check(NUmber);
            ch += delegate (int n)
            {
                Console.WriteLine($"daxil olunan eded {n}  {(n % 5 == 0 ? "5 ye bolunur" : "5  ye bolunmur")}");

            };
            ch += delegate (int n)
              {
                  Console.WriteLine($"daxil olunan eded {n}  {(n % 2 == 0 ? "cutdur" : "cut deyil")}");
              };
            ch.Invoke(20);
        }
        public delegate void Check(int n);
        static void NUmber(int n)
        {
            if (n>0)
            {
                Console.WriteLine($"daxil edilen eded {n} 0 dan boyukdur ");
            }
            else
            {
                Console.WriteLine($"daxil edilen eded {n} 0 dan kicikdir ");
            }
        }
    }
}

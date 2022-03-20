using System;

namespace video13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1ci usul
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Choose ch = ChooseMethod;
            Console.WriteLine("1. ayin adini yazdirmaq \n 2.Fesilin adinin yazdirmaq ");
            Console.WriteLine("bir metod secin");
            string method = Console.ReadLine();
            Console.WriteLine("bir ay secin");
            byte month = byte.Parse(Console.ReadLine());
            Console.WriteLine(ch.Invoke(method, month));
            #endregion
            #region
            //Console.WriteLine("1. ayin adini yazdirmaq \n 2.Fesilin adinin yazdirmaq ");
            //Action<string, byte> action;
            //Console.WriteLine("bir metod secin");
            //string method = Console.ReadLine();
            //Console.WriteLine("bir ay secin");
            //byte month = byte.Parse(Console.ReadLine());
            //action = (method, month) => Console.ReadLine();
            //{
            //    if (method == "1")
            //    {
            //        PrintInfo("daxil edilen reqeme uygun ay gosderen proqram");
            //        string Month;
            //        switch (month)
            //        {
            //            case 1:
            //                Month = "yanvar";
            //                break;
            //            case 2:
            //                Month = "Fevral";
            //                break;
            //            case 3:
            //                Month = "Mart";
            //                break;
            //            case 4:
            //                Month = "Aprel";
            //                break;
            //            case 5:
            //                Month = "May";
            //                break;
            //            case 6:
            //                Month = "Iyun";
            //                break;
            //            case 7:
            //                Month = "Iyul";
            //                break;
            //            case 8:
            //                Month = "Avqust";
            //                break;
            //            case 9:
            //                Month = "Sentaybr";
            //                break;
            //            case 10:
            //                Month = "Oktyabr";
            //                break;
            //            case 11:
            //                Month = "Noyabr";
            //                break;
            //            case 12:
            //                Month = "Dekabr";
            //                break;

            //            default:
            //                Month = "bele bir ay yoxdur";
            //                break;
            //        }
            //        Console.WriteLine(Month);
            //    }
            //    else if (method == "2")
            //    {
            //        Console.WriteLine("-------s");
            //        PrintInfo("daxil edilen reqeme uygun fesil gosderen proqram");
            //        string season;
            //        switch (month)
            //        {
            //            case 12:
            //            case 1:
            //            case 2:
            //                season = "Qis";
            //                break;
            //            case 3:
            //            case 4:
            //            case 5:
            //                season = "yaz";
            //                break;
            //            case 6:
            //            case 7:
            //            case 8:
            //                season = "yay";
            //                break;
            //            case 9:
            //            case 10:
            //            case 11:
            //                season = "payiz";
            //                break;

            //            default:
            //                season = "girdiyiniz aya gore etice yoxdur";
            //                break;
            //        }
            //        Console.WriteLine(season);
            //    }
            //}
            #endregion
        }
        #region 1 ci usul
        public delegate string Print(byte Month);
        public delegate string Choose(string method, byte month);
        public static string TranslateMonth(byte Month)
        {
            string month;
            switch (Month)
            {
                case 1:
                    month = "yanvar";
                    break;
                case 2:
                    month = "Fevral";
                    break;
                case 3:
                    month = "Mart";
                    break;
                case 4:
                    month = "Aprel";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "Iyun";
                    break;
                case 7:
                    month = "Iyul";
                    break;
                case 8:
                    month = "Avqust";
                    break;
                case 9:
                    month = "Sentaybr";
                    break;
                case 10:
                    month = "Oktyabr";
                    break;
                case 11:
                    month = "Noyabr";
                    break;
                case 12:
                    month = "Dekabr";
                    break;

                default:
                    month = "bele bir ay yoxdur";
                    break;
            }
            return month;
        }
        public static string PrintSeasonName(byte Month)
        {
            string season;
            switch (Month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Qis";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "yaz";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "yay";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "payiz";
                    break;

                default:
                    season = "girdiyiniz aya gore etice yoxdur";
                    break;
            }
            return season;

        }
        public static string ChooseMethod(string method,byte month)
        {
            Print print = null;
            if (method=="1")
            {
                PrintInfo("daxil edilen reqeme uygun ay gosderen proqram");
                print = TranslateMonth;
            }else if (method == "2")
            {
                PrintInfo("daxil edilen reqeme uygun fesil gosderen proqram");
                print = PrintSeasonName;
            }
            return print(month);
            //
        }
        public static void PrintInfo(string info)
        {
            Console.WriteLine(info);
        }
        #endregion
    }
}

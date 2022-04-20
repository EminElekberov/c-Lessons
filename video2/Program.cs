using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace video2
{
    class Program
    {
        static void Main(string[] args)
        {
             WriteToFile();
            //Console.WriteLine("daxil edin: ");
            //string word = Console.ReadLine();
            //char[] wods = word.ToCharArray();
            //for (int i = 0; i < wods.Length; i++)
            //{
            //    if (wods[i].ToString()=="*")
            //    {
            //        Console.WriteLine("burda * isaresi var"+wods[i]);
            //        Console.WriteLine(wods[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("burada * isaresi yoxdur");
            //        var x = wods[i].ToString();
            //        x = "-";
            //    }
            //}

            #region
            //
            //Console.WriteLine("Secim edin \n" +
            //    "\n A" +
            //    "\n b");
            //string example = Console.ReadLine();
            //int res = Convert.ToInt32(Console.ReadLine());
            //string message = null;
            //switch (res)
            //{
            //cw
            //cw
            //    case 1:
            //        message = "bu herf A dir";
            //        break;
            //    case 2:
            //        message = "bu herf b dir";
            //        break;
            //    default:
            //        message = "daxil etdiyiniz melumat sehvdir";
            //        break;
            //}
            //return message;
            //Console.WriteLine("reqem daxil edin");
            //int s = Convert.ToInt32(Console.ReadLine());
            //if (s > 0)
            //{

            //    Console.WriteLine("bu eded mubet ededdir");
            //}
            //else if (s < 0)
            //{
            //    Console.WriteLine("bub eded menfidir");
            //}
            //else
            //{
            //    Console.WriteLine("bu eded 0 beraberdir");
            //}
            /*
            string a = "hello ";
            string b = "hello";
            Console.WriteLine(string.Compare(a,b));
            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(string.Concat(a,b));
        */
            //
            //int i = 10;
            //object o = i;
            //Console.WriteLine(o);
            //int x = 10;
            //int y = ++x;
            //int z = y++;
            //Console.WriteLine(z);
            //string a = "hello c sharp";
            //string s2 = a.Substring(0, 3);
            //Console.WriteLine(s2);


            /*
            string a = "AA12365478";
            string s2 = a.Substring(0, 2);
            if (s2=="AA")
            {
                Console.WriteLine("AA nomreli pasword "+ s2);
            }
            */

            /*
            string a = "hello f#";
            string s2 = a.Replace("f#", "c#");
            Console.WriteLine(s2);
            */

            /*
            string password = "salam ";
            Console.WriteLine(password.Length);
            Console.WriteLine((password.Trim().Length));
            */
            /*
            string password = "hello c sharp";
            string[] soz = password.Split(' ');
            foreach (var item in soz)
            {
                Console.WriteLine(item);
            }
            */


            /*
            //boxing unboxing
            int f = 5;
            object n = f;//boxing- boyuk value type den kicik value type kecmesine deyilir
            object c2 = 5;
            if (c2 is int)
            {
                int g = (int)c2;//unboxing
                Console.WriteLine(g);
            }
            */



            //int number = 5;
            //ChangeNumber(ref number);
            //Console.WriteLine(number);
            #endregion
        }
        public static void WriteToFile()
        {
            using (StreamWriter sw = File.CreateText(@"D:\textTask.txt"))
            {
                sw.WriteLine("Please find the below generated table of 1 to 10");
                sw.WriteLine("");
                string s = Console.ReadLine();
                sw.WriteLine(s);
                Console.WriteLine("Table successfully written on file.");
                Console.WriteLine(s.Length);
            }
        }


        // public static void WriteToFile()
        //{
        //    using (StreamWriter sw = File.CreateText(@"D:\textEmin.txt"))
        //    {
        //        sw.WriteLine("Please find the below generated table of 1 to 10");
        //        sw.WriteLine("");
        //        for (int i = 1; i <= 10; i++)
        //        {
        //            for (int j = 1; j <= 10; j++)
        //            {
        //                sw.WriteLine("{0}x{1}= {2}", i, j, (i * j));
        //            }
        //            sw.WriteLine("==============");
        //        }
        //        Console.WriteLine("Table successfully written on file.");
        //    }
        //}
        private static void ChangeNumber(ref int num)
        {
            num = 100;
        }


        /*
        int number;
        ChangeNumber(out number);
        Console.WriteLine(number);
    }
    private static void ChangeNumber(out int num)
    {
        num = 100;
    }
        */


        /*
        //1
        int[] number = new int[5];
        //2
        int[] number2 = new int[5] {1,2,3,4,5};
        //3
        int[] number3 = { 3, 4, 5,6 };
        //4
        string[] sm = new string[] { "a", "b", "c" };
        number3.SetValue(5, 0);
        for (int i = 0; i < number3.Length; i++)
        {
            Console.WriteLine(i);
        }
        */

        /*
        int[] number3 = { 3, 4, 5, 6 };
        for (int i = 0; i < number3.Length; i++)
        {
            Console.WriteLine(number3[i]);
        }
        */



        //int[] numbers = { 1, 2, 6, 5, 55, 23,2,5 };
        //int[] notDublicate = numbers.Distinct().ToArray();
        //foreach (var item in notDublicate)
        //{
        //    Console.WriteLine(item);
        //}


       
        //int[] numbers = { 1, 2, 6, 5, 55, 23, 2, 5 };
        //int[] notDublicate = numbers.Distinct().ToArray();
        //Array.Sort(notDublicate);

        //foreach (var item in notDublicate)
        //{
        //    Console.WriteLine(item);
        //}
        

        //int[] numbers2 = { 1, 2, 6, 5, 55, 23, 2, 5 };
        //int arrayFirstElement = numbers2[0];
        //for (int i = 0; i < numbers2.Length; i++)
        //{
        //    if (numbers2[i]>arrayFirstElement)
        //    {
        //        arrayFirstElement = numbers2[i];

        //    }
        //}
        //Console.WriteLine(arrayFirstElement);

        public static string Result(int year)
        {
            string level;
            switch (year)
            {
                case 0:
                    level = "in";
                    break;
                case 1:
                    level = "2";
                    break;
                default:
                    level = "eferfc";
                    break;
            }
            return level;
        }
    }
}


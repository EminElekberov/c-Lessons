using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {

            #region
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //if ((a+b==c) || (a+b==d))
            //{
            //    Console.WriteLine("a ve b "+c+" beraberdi");
            //}
            //else
            //{
            //    Console.WriteLine("-1");
            //}
            #endregion
            #region 1ci usul
            //Console.WriteLine(" 3reqemli ededi daxil edin");
            //    int abc = Convert.ToInt32(Console.ReadLine());
            //    int a = abc / 100;
            //    int b = (abc / 10) % 10;
            //    int c = abc % 10;
            //    if (a>b && a>c && b>c)
            //    {
            //        Console.WriteLine(abc);
            //        return;
            //    }
            //    else if (a > b && a > c && b > c)
            //    {
            //        Console.WriteLine(a+""+b+""+c);
            //        return;
            //    }
            //    else if (b>a && b>c && a>c)
            //    {
            //        Console.WriteLine(b+""+a+""+c);
            //    }
            //    else if (b>a && b>c && c>a)
            //    {
            //        Console.WriteLine(b+""+c+""+a);
            //    }
            //    else if (c>a && c>b && b>a)
            //    {
            //        Console.WriteLine(c+""+b+""+a);
            //    }
            //    else if (c > a && c > b && a>b)
            //    {
            //        Console.WriteLine(c + "" + a + "" + b);
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("dogru deyer girin");
            //    }
            #endregion
            #region 2 ci usul
            //int[] list = { 36, 78, 1, 69, 45 };
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //Array.Sort(list);
            //Array.Reverse(list);
            //Console.WriteLine("\n");
            //for (int i = 0; i < list.Length; i++)
            //{
            //    Console.Write(list[i] + " ");
            //}
            #endregion
        }
        #region 1 ci sual
        //Console.WriteLine(CheckLetters("Karabaxh is azerbaijan",10));
        //public static bool CheckLetters(string text, int n)
        //{
        //    string letters = "qwertyuioplkjhgfdsazxcvbnm";
        //    int counter = 0;
        //    for (int i = 0; i < letters.Length; i++)
        //    {
        //        counter = 0;
        //        for (int j = 0; j < text.Length; j++)
        //        {
        //            if (letters[i] == text[j])
        //            {
        //                counter++;
        //            }
        //        }
        //        if (counter > n) return false;
        //        {

        //        }
        //    }
        //    return true;
        //}
        #endregion

        //Console.WriteLine(a+"b="+b+"c="+c);

        //Console.WriteLine("__________");
        #region
        #region

        //Book book = new Book
        //{
        //    Name="kris",
        //    Author="emin",
        //    Page=3000,
        //    genre=Genre.Detective
        //};
        //Book book2 = new Book
        //{
        //    Name = "JS",
        //    genre = Genre.Dram,
        //    Page = 2000,
        //    Author = "XXX"
        //};
        //Book book3 = new Book
        //{
        //    Name = "ferfer",
        //    genre = Genre.Dram,
        //    Page = 2000,
        //    Author = "XXX"
        //};
        //Library library = new Library();

        //library.AddBook(book);
        //library.AddBook(book2);library.AddBook(book3);
        //// library.DeleteBook("kris");
        ////library.AllList();
        //library.Search("JS",Genre.Dram);
        ///
        #endregion
        #region
        //DateTime currentDateTime = DateTime.Today;
        //Console.WriteLine(currentDateTime);

        //byte b = byte.MaxValue;
        //Console.WriteLine(b);

        //Console.WriteLine(newDate);
        //Console.WriteLine(auth(Login));
        //Check register = new Check(CheckTemperature);
        //register.Invoke(20);
        //
        #endregion

        #region recursive
        //recursive- fibonancy
        //int fibonansi1 = 0, fibonansi2 = 1, fibonansi, number;
        //Console.Write("Reqem Daxil edin ");
        //number = Convert.ToInt32(Console.ReadLine());
        //Console.Write(fibonansi1 + " " + fibonansi2 + " "); 
        //for (int i = 2; i < number; ++i)    
        //{
        //    fibonansi = fibonansi1 + fibonansi2;
        //    Console.Write(fibonansi + " ");
        //    fibonansi1 = fibonansi2;
        //    fibonansi2 = fibonansi;
        //}


        //multiplication
        //int i, n, f = 1;
        //n = Convert.ToInt32(Console.ReadLine());
        //for (i = 1; i <= n; i++)
        //{
        //    f *= i;
        //}
        //Console.WriteLine(f);


        //Direct Recursion
        //int x = 20;
        //fun(x);

        #endregion

        #region Devide 
        //Sort Algorithm Devide aiddir
        //int[] numbers = { 1, 2, 6, 5, 55, 23, 2, 5 };
        //int[] notDublicate = numbers.Distinct().ToArray();
        //Array.Sort(notDublicate);
        //foreach (var item in notDublicate)
        //{
        //    Console.WriteLine(item);
        //}


        // MAthlibrary
        //double x, y;
        //x = double.Parse(Console.ReadLine());
        //y = Math.Pow(x, 3) - 5 * Math.Pow(x, 2) / 7 + 9 * x - 3 / x + 1;
        //Console.WriteLine(y);

        //ArrayMAx Element
        //int[] numbers = { 14, 8, 96, 35, 6, 1, 3 };
        //int small = numbers[0];
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] > small) small = numbers[i];
        //}
        //Console.WriteLine(small);


        //int[] array = { 1, 2, 3, 4,10, 5, 6, 7, 8, 9 };
        //var maxNumber = array.Max();
        //Console.WriteLine($"Max Number Of this Array:{maxNumber}");
        #endregion


        #endregion
        //var member = new Member()
        //{
        //    Id = 10,
        //    Title = "John Wick",
        //    Director = "Chad Stahelski",
        //    ReleasedOn = DateTime.Parse("2014/10/24"),
        //    BoxOfficeRevenue = 86_000_000
        //};
        //var directorProperty = member.GetType().GetProperty("Director");
        //directorProperty.SetValue(member, "Stahelski");

        //Console.WriteLine(directorProperty.Name);

        //Member member = new Member();
        //member.age=21;
        //var properties = member.GetType().GetFields();
        //int index = -1;
        //for (int i = 0; i < properties.Length; i++)
        //{
        //    if (properties[i].Name=="age")
        //    {
        //        index = i;
        //    }
        //}
        //Console.WriteLine("next"+properties[index+1].Name);
        //Console.WriteLine("next"+properties[index-1].Name);

    }

    #region recursive
    //static void fun(int n)
    //{
    //    if (n > 0)
    //    {
    //        Console.Write(n + " ");

    //        // Last statement in the function
    //        fun(n - 1);
    //    }
    //}
    #endregion
}
    public class Member
    {
        public string Title;
        public int age;

        public string Director;
        public DateTime ReleasedOn;
        public long BoxOfficeRevenue;
    }


#region
//public delegate void Check(int temp);
//public event Check registerUserEvent;
//public static void CheckTemperature(int temp)
//{
//    Console.WriteLine($"derece  {temp} -dir {(temp < 20 ? "derece 20 den asagidir" : "derece 20 den yuxaridiri")}");
//}
//public delegate void Check(int n);
//Action<int> action = delegate (int temp)
//{
//    Console.WriteLine($"number {temp} is {(temp<20 ? "4 ye bolunur" : "4 ye bolunmur")}");
//};
//public delegate void auth(bool validUser);
//public static void Login()
//{
//    Console.WriteLine("valid user");
//}

//    }
//interface Iperson
//{
//    string FirstName
//    {
//        get;
//        set;
//    }
//}
//class Empl : Iperson
//{
//    private string str;
//    public string FirstName {
//        get
//        {
//            return str;
//        }
//        set
//        {
//            //str.value;
//        }
//    }
//}
#endregion



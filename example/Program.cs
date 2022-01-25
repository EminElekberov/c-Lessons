using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
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
            //    Name = "JS",
            //    genre = Genre.Dram,
            //    Page = 2000,
            //    Author = "XXX"
            //};
            //Library library = new Library();

            //library.AddBook(book);
            //library.AddBook(book2);library.AddBook(book3);
            //library.DeleteBook("kris");
            ////library.AllList();
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

              Brutforce b = new Brutforce()
            {

                Alphabet = new[] { 'a', 'b', 'c', 'd' }
            };
            ICollection<string> vals = b.Calculate(3);
            foreach (var elem in vals)
                Console.WriteLine(elem);
            Console.ReadKey();
        }
    }


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



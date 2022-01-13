using System;
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
            Console.OutputEncoding = Encoding.UTF8; 

        link1:
            Console.Clear();     

            string[] powlvl = { "aşağı", "orta", "yüksək" }; 

            Console.Write(" Güc dəyərini daxil edin (1-10): "); 
            int pown = Convert.ToInt32(Console.ReadLine());      


            string[] splvl = { "az", "kifayət qədər", "çox" };                                                                                                                       Console.Write(" Введите количество колонок(1-10): ");    //Ввод значения количества колонок
            int spn = Convert.ToInt32(Console.ReadLine());          


            string[] roomlvl = { "kiçik", "orta", "böyük" };
            Console.Write(" Otağın ölçüsünü daxil edin(1-3): ");                        
            int roomn = Convert.ToInt32(Console.ReadLine());

            String time = " Quraşdırma vaxtı: ";                                       
            string[] timelvl = { "az", "orta", "kifayət qədər", "çox" };           
                                                                                     
            if (pown > 6 && spn < 4 && roomn == 1)
            { Console.Write(time + timelvl[0] + "\n\r"); }
            else if (pown > 6 && spn > 6 && roomn == 2)
            { Console.Write(time + timelvl[2] + "\n\r"); }
            else if (pown < 4 && spn > 6 && roomn == 3)
            { Console.Write(time + timelvl[3] + "\n\r"); }
            else if (pown > 3 && pown < 7 && spn > 3 && spn < 7 && roomn == 2)
            { Console.Write(time + timelvl[2] + "\n\r"); }
            else { Console.Write(time + timelvl[1] + "\n\r"); }

        link2: Console.Write("\n Yenidən başladın? (y / n)");
            string i = Console.ReadLine();        
            if (i == "y")                       
            {                                  
                goto link1;                    
            }                                 
            else if (i == "n")               
            {                               
                Environment.Exit(0);         
            }                             
            else if (i != "y" || i != "n")   
            {                           
                goto link2;             
            }                         
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



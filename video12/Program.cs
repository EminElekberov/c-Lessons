using System;

namespace video12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("daxil et");
            string s = Console.ReadLine();
            char[] words = s.ToCharArray();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i]>=48 && words[i]<=57)
                {
                    Console.WriteLine(words[i]+" bu reqemdir");
                }
                else
                {
                    Console.WriteLine(words[i]+" bu reqen deyil");
                }
            }
            #region Extension
            //string email = "eminelekberov09@gmail.com";
            //email.IsEmail();
            #endregion

            #region example 2
            //int[] num = { 10, 20, 30, 40, 5, 9, 7 };
            //Console.WriteLine(SumEven(num));
            //Console.WriteLine(SumOdd(num));
            //SumOdd(num);
            //int x = SumEven(num) + 15;
            //Console.WriteLine(x);
            //int  x2 = SumOdd(num) + 15;
            #endregion

            #region Delegate example
            //Console.WriteLine(Sum(IsEven,2,6,5,8,7,15));
            #endregion

            #region Delegate examp2 
            //Writer writer = new Writer(WriterEven);
            //writer += WriterDivisible;
            //writer += WriterEven;
            ////anonim
            //writer += delegate (int n)
            //{
            //    Console.WriteLine($"number {n} is {(n % 4== 0 ? "4 ye bolunur" : "4 ye bolunmur")}");

            //};
            ////lambda
            ////lamdani yazanda diger cw baxmir digerlerine baxmaq isdesen lambdani commete at
            //writer = n =>
            //{
            //    Console.WriteLine($"number {n} is {(n % 5 == 0 ? "5 ye bolunur" : "5 ye bolunmur")}");

            //}; 
            //writer.Invoke(20);
            #endregion

            #region Action 
            //Action<string, int> action = delegate (string name, int age)
            //{
            //    Console.WriteLine($"name {name} and age {age}");
            //};
            //action += (n, a) =>
            //{
            //    Console.WriteLine($"new word {n} new number {a}");
            //};
            //action.Invoke("emin", 20);
            #endregion

            #region Func
            //Func<Person, bool> check = CheckFromAzerbaijan;
            //check += delegate (Person p) { return p.Name.Length > 2; };

            //check += p => p.Email.Contains("@");
            //Person person = new Person
            //{
            //    Name = "Emin",
            //    Email = "eminelekberov09@gmail.com",
            //    Country = "Azerbaijan"
            //};
            //Console.WriteLine(check(person));
            #endregion
        }

       
        #region Example 2
        //static int SumEven(int[] arr)
        //{
        //    int result = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item%2==0)
        //        {
        //            result += item;
        //        }
        //    }
        //    return result;
        //}
        //static int  SumOdd(int[] arr)
        //{
        //    int result = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item % 2 == 1)
        //        {
        //            result += item;
        //        }
        //    }
        //    return result;
        //}
        #endregion

        #region Delegate Examp
        public delegate bool Checkers(int x);
        static bool IsEven(int a) => a % 2 == 0;
        static bool IsDivisibleByThree(int a) => a % 3 == 0;

        public static int Sum(Checkers call, params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                if (call(item))
                {
                    sum += item;
                }
            }
            return sum;
        }
        #endregion

        #region Delegate examp2
        // public delegate void Writer(int n);
        //public  static void WriterEven(int n)
        // {
        //     Console.WriteLine($"number {n} is {(n % 2 == 0 ? "2 ye bolunur":"2 ye bolunmur")}");
        // }
        // static void WriterDivisible(int n)
        // {
        //     Console.WriteLine($"number {n} is {(n % 3 == 0 ? "3 ye bolunur" : "3 ye bolunmur")}");
        // }
        #endregion

        #region Func
        static bool CheckFromAzerbaijan(Person p) {
            return p.Country == "Azerbaijan"; 
        }
        #endregion
    }

    #region Func
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
    }
    #endregion
}

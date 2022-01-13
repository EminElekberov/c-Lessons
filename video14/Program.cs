using System;

namespace video14
{
    class Program
    {

        static void Main(string[] args)
        {
            #region 1
            ATM atm = new ATM(500);
            atm.BalanceFinished += (n, m) =>
            {
                Console.WriteLine($"ATM de{n} AZN mebleginde  pul yoxdur" +
$"Balans {m} AZN");
            };
            atm.BalanceFinished += UserBalanceFinished;
            atm.TransferSuuccessFuly += (n, m, time) =>
            {
                Console.WriteLine($"{time} tarixinde {n} azn mebleginde emeliyyat gedib. Balans {m} azn");
            };
            atm.WithDraw(100);
            atm.WithDraw(300);
            atm.WithDraw(500);
            Console.ReadLine();
            #endregion

            #region
            User register = new User("EMin");
            register.registerUserEvent += EmailVerification;
            register.registerUserEvent += SmsVerification;
            register.RegisterUser();
        }

        public class User
        {
            public string Name { get; set; }
            public event EventHandler registerUserEvent;
            public User(string name)
            {
                Name = name;
            }
            public void RegisterUser()
            {
                Console.WriteLine("user register olundu");
                registerUserEvent(this, EventArgs.Empty);

            }
        }
        public static void EmailVerification(object source, EventArgs e)
        {
            Console.WriteLine("send EMail");
        }
        public static void SmsVerification(object source, EventArgs e)
        {
            Console.WriteLine("send sms");
        }

        public static void UserBalanceFinished(double x, double y)
        {
            Console.WriteLine($"Hormetli musderi balansda teleb olunan mebleginde {x} AZN mebleg yoxdur");
        }
    }
    }
    #endregion


#region
//User register = new User("EMin");
//register.registerUserEvent += EmailVerification;
//register.registerUserEvent += SmsVerification;
//register.RegisterUser();
//Console.ReadLine();

//User register2 = new User("Mina");
//register2.registerUserEvent += EmailVerification;
//register2.registerUserEvent += SmsVerification;
//register2.RegisterUser();
//Console.ReadLine();
//}
//public class User
//{
//    public string Name { get; set; }
//    public delegate void RegisterUserEventHandler(object sender, RegisterUserEventArgs e);
//    public event RegisterUserEventHandler registerUserEvent;
//    public User(string name)
//    {
//        Name = name;
//    }
//    public void RegisterUser()
//    {
//        Console.WriteLine($"{Name} registr oldu");
//        registerUserEvent(this, new RegisterUserEventArgs(Name));
//    }
//}
//public class RegisterUserEventArgs : EventArgs
//{
//    public string NameArg { get; set; }
//    public RegisterUserEventArgs(string name)
//    {
//        NameArg = name;
//    }
//}
//public static void EmailVerification(object source, RegisterUserEventArgs e)
//{
//    Console.WriteLine($"send EMail {e.NameArg}");
//}
//public static void SmsVerification(object source, RegisterUserEventArgs e)
//{
//    Console.WriteLine($"send sms {e.NameArg}");
//}
//
#endregion


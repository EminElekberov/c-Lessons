using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Medicine med = new Medicine("Nospa",20,40);
            //Medicine med2 = new Medicine("Adalzit",30, 50);
            //Pharmacy ph = new Pharmacy();
            //ph.Books.Add(med);
            //ph.Books.Add(med2);
            ////ph.FindMedicineByName("ydryftyfy");
            ////ph.AddMedicine(new Medicine("Nospa",10,25));
            ////ph.Medicines("nospa");
            //ph.Sell("Adalzit", 15);
            //ph.Sell("adalzit", 10);
            //ph.Sell("nospa", 15);
            #endregion
            GetValueIndexes("eduhweuih9868e3");
        }
        public static string GetValueIndexes(string pass)
        {
            char[] check = pass.ToCharArray();
            for (int i = 0; i < check.Length; i++)
            {
                int change = Convert.ToInt32(check[i]);
               
                if (change > 96 && change < 123)
                {
                    Console.WriteLine(check[i]+"  string tipindedir");
                }
                else
                {
                    Console.WriteLine(check[i]+" string tipinde deyil ");
                }

            }
            return pass;
        }
    }
}

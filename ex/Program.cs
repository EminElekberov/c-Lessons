using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n, sum = 0;
            
            Console.Write("how many enter number? :");
            n = Convert.ToInt32(Console.ReadLine());

            
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);

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
            //Console.WriteLine();
            //ph.Sell("nospa", 15);
            #endregion
            //GetValueIndexes("eduhweuih9868e3");
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

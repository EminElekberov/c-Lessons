using System;
using System.Collections.Generic;
using System.Text;

namespace ex
{
    public class Pharmacy : IPharmacy
    {
        public List<Medicine> Books { get; set ; }
        public Pharmacy()
        {
            this.Books = new List<Medicine>();
        }
        public void AddMedicine(Medicine medicine)
        {
            string lowercase = medicine.Name.Trim().ToLower();
            Medicine medicine1 = Books.Find(f => f.Name.Trim().ToLower().Equals(lowercase));
            if (medicine1==null)
            {
                Books.Add(medicine);
                Console.WriteLine();
                Console.WriteLine("elave olundu");
            }
            else
            {
                medicine1.Count++;
                Console.WriteLine("sayi artdis"+medicine1.Count);
            }
        }
        public Medicine FindMedicineByName(string medicinename)
        {
            string med = medicinename.Trim().ToLower();
            Medicine med1 = Books.Find(m => m.Name.Trim().ToLower().Equals(med));
            if (med1!=null)
            {
                Console.WriteLine(med1.Name);
            }
            else
            {
                Console.WriteLine("bele derman tapilmadi");
            }
            return med1;
        }
        public void Medicines(string medicine)
        {
            string find = medicine.Trim().ToLower();
            Medicine med = Books.Find(n => n.Name.Trim().ToLower().Equals(find));
            if (med!=null)
            {
                Console.WriteLine($"name {med.Name} \n Count {med.Count} \n price {med.Price}");
            }
            else
            {
                Console.WriteLine("bele derman tapilmadi");
            }
        }

        public void Sell(string medicineName, int buyproductCount)
        {
            string mediName = medicineName.Trim().ToLower();
            Medicine sell = Books.Find(s => s.Name.Trim().ToLower().Equals(mediName));
            if (sell.Count>buyproductCount)
            {
                sell.Count -= buyproductCount;
                double resultprice = buyproductCount * sell.Price;
                Medicine._totalInCome += resultprice;
                Console.WriteLine();
                Console.WriteLine($"umumi qiymet {resultprice} manat elde qalan derman sayi {sell.Count} ,elde edilen gelir {Medicine._totalInCome}");
            }
            else
            {
                Console.WriteLine("kifayet qeder derman yoxdur");
            }
        }
    }
}

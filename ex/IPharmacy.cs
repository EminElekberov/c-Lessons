using System;
using System.Collections.Generic;
using System.Text;

namespace ex
{
    interface IPharmacy
    {
        public List<Medicine> Books { get; set; }
        public void Medicines(string medicine);
        public void Sell(string medicineName, int buyproductCount);
        public Medicine FindMedicineByName(string medicinename);
        public void AddMedicine(Medicine medicine);
    }
}

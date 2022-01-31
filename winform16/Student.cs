using System;
using System.Collections.Generic;
using System.Text;

namespace winform16
{
   public  class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GroupNo { get; set; }
        public string FullNamek { get { return Name + " " + Surname; } }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}

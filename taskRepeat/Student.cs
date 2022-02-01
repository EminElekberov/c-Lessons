using System;
using System.Collections.Generic;
using System.Text;

namespace taskRepeat
{
   public  class Student
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullNamek { get { return Name + " " + Surname; } }
        public Student(string name, string surname)
        {
            this.Name = name;
            Surname = surname;
            Id = _id;
            _id++;
        }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}

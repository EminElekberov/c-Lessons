using System;
using System.Collections.Generic;
using System.Text;

namespace taskRepeat
{
   public  class Student
    {
        public static int id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
            Id =id;
            id++;
        }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }
}

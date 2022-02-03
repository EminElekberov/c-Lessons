using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskRepeat
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public List<Student> students = new List<Student>();
        public string imgFile { get; set; }
        public List<Student> GetStudents() => students;
        public string FullName { get { return Name + " " + Surname+ " "+Email; } }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}

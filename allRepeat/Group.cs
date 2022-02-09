using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allRepeat
{
    public class Group
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string GroupNo { get; set; }
       public  List<Student> students;
        public Group(string name)
        {
            GroupNo = name;
            Id = _id;
            _id++;
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public List<Student> GetAlLStudent() => students;

        public override string ToString()
        {
            return GroupNo;
        }
    }
}

using System;
using System.Collections.Generic;

namespace taskRepeat
{
    public class Group
    {
        private static int _id = 1;
        public String Name { get; set; }
        public int Id { get; set; }
        private List<Student> students;
        public void DeleteStudent(Student student)
        {
            students.Remove(student);
            
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public List<Student> GetAlLStudent() => students;

        public Group(string nm)
        {
            Name = nm;
            Id = _id;
            _id++;
            students = new List<Student>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

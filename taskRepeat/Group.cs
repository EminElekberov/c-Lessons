using System;
using System.Collections.Generic;

namespace taskRepeat
{
    public class Group
    {
        public static int id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> students;
        public Group(string nm)
        {
            Name = nm;
            Id = id;
            id++;
            students = new List<Student>();
        }
        public List<Student> GetAllStudent() => students;
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

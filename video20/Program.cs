using System;
using System.Reflection;

namespace video20
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("emin", "elekberov");
            var type = student.GetType(); 
            Assembly Curassembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(Curassembly.FullName);
            Console.WriteLine("-----------");
            foreach (var item in type.GetProperties())
            {
                if (item.PropertyType== lastName)
                {

                }
                Console.WriteLine(item);
            }
            
            Console.WriteLine("-----------");

            foreach (MemberInfo item in type.GetMembers())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            foreach (var item in type.GetConstructors())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            var type2 =typeof(Student); 
            Console.WriteLine("typeof "+type2.GetMethods().Length);
            Console.ReadLine();
        }
        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }
    class Student
    {
        public string Firstname { get; set; }
        public string lastName { get; set; }
        public byte Age { get; set; }
        private int X;
        public Student(string nm,string srnm)
        {
            Firstname = nm;
            lastName = srnm;

        }
    }
}
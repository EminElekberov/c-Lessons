using System;

namespace video3
{
    class Program
    {
        static void Main(string[] args)
        {

            Cars bmw = new Cars();
            bmw.Name = "BMW";
            bmw.DoorCount = 2;
            bmw.MotorGucu = 4;
            bmw.Motor();

            Cars kia = new Cars();
            kia.Name = "kia";
            kia.DoorCount = 4;
            kia.MotorGucu = 5;
            kia.Motor();
        }


        //    Student[] students = new Student[2];
        //    for (int i = 0; i < students.Length; i++)
        //    {
        //        Console.WriteLine("adi daxil edin: ");
        //        string name = Console.ReadLine();
        //        Console.WriteLine("bali daxil edin: ");
        //        double point = Convert.ToDouble(Console.ReadLine());
        //        Student student = new Student(name,point);
                
        //        students[i] = student;

        //    }
        //    Console.WriteLine($"telebelrin ortalamasi : {AvarageStudent(students)}");

        //}
        //public static double AvarageStudent(Student[] students)
        //{
        //    double sum = 0;
        //    foreach (var item in students)
        //    {
        //        sum += item.Point;
        //    }
        //    return sum/students.Length;
        //}

    }
}

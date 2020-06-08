using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student me = new Student("Shawn", 1);
            me.AddGrade(1, 3, 4.0);
            me.AddGrade(2, 4, 3.0);

            Console.WriteLine(me.Gpa());

            Console.WriteLine(me.GetGradeLevel());

            me.AddGrade(3, 100, 3.0);
            Console.WriteLine(me.GetGradeLevel());
        }
    }
}

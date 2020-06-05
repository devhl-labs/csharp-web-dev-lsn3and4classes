using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; }

        public int StudentId { get; }

        public int NumberOfCredits { get; }

        public double Gpa { get; }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;

            StudentId = studentId;

            NumberOfCredits = numberOfCredits;

            Gpa = gpa;
        }
    }
}

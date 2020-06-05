using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Teacher
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string Subject { get; }

        public int YearsTeaching { get; }

        public Teacher(string firstName, string lastName, string subject, int yearsTeaching)
        {
            FirstName = firstName;

            LastName = lastName;

            Subject = subject;

            YearsTeaching = yearsTeaching;
        }
    }
}

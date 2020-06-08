using System;
using System.Collections.Generic;
using System.Linq;

#nullable enable

namespace SchoolPractice
{
    public enum GradeLevel
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }

    public class Student
    {
        public string Name { get; }

        public int StudentId { get; }

        private readonly List<EnrollementResult> _results = new List<EnrollementResult>();

        public Student(string name, int studentId, List<EnrollementResult>? results = null)
        {
            Name = name;

            StudentId = studentId;

            if (results != null)
                _results = results;
        }

        public GradeLevel GetGradeLevel()
            => _results.Sum(g => g.Credits) switch
                {
                    var x when x > 89 => GradeLevel.Senior,
                    var x when x > 59 => GradeLevel.Junior,
                    var x when x > 29 => GradeLevel.Sophomore,
                    _ => GradeLevel.Freshman
                };
        

        public void AddGrade(int courseId, double credits, double grade) => _results.Add(new EnrollementResult(courseId, credits, grade));

        public double Gpa()
        {
            if (_results.Count == 0)
                return 0;

            double sum = 0;

            foreach (EnrollementResult result in _results)
                sum += result.Credits * result.Grade;

            return Math.Round(sum / _results.Sum(r => r.Credits), 2);
        }

        public override bool Equals(object? obj)
            => obj is Student student &&
                   Name == student.Name &&
                   StudentId == student.StudentId;

        public override int GetHashCode() => HashCode.Combine(StudentId);        
    }
}

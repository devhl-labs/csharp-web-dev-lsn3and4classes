using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public int CourseId {get;}

        public string Name { get; }

        public int Credits { get; }

        public Dictionary<int, Student> Students { get; } = new Dictionary<int, Student>();

        public Course(string name, int courseId, int credits)
        {
            Name = name;

            CourseId = courseId;

            Credits = credits;
        }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   CourseId == course.CourseId &&
                   Name == course.Name &&
                   Credits == course.Credits &&
                   EqualityComparer<Dictionary<int, Student>>.Default.Equals(Students, course.Students);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CourseId);
        }
    }
}

#nullable enable

namespace SchoolPractice
{
    public class EnrollementResult
    {
        public int CourseId { get; }

        public double Credits { get; }

        public double Grade { get; }

        public EnrollementResult(int courseId, double credits, double grade)
        {
            CourseId = courseId;

            Credits = credits;

            Grade = grade;
        }
    }
}

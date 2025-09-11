

namespace Schoolsystem.Domain
{
    public class Grade
    {
        public int Id { get; set; }
        public Student AssignedStudent { get; set; } = default!;
        public int StudentId { get; set; }
        public Course AssignedCourse { get; set; } = default!;
        public int CourseId { get; set; }
        public char GradeGot { get; set; }
        public string Remark { get; set; } = default!;
        public DateTime DateGrade { get; set; }

    }
}

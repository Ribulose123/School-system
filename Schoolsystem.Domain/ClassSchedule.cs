

namespace Schoolsystem.Domain
{
    public class ClassSchedule
    {
        public int Id { get; set; }
        public Course AssignedCourse { get; set; } = default!;
        public int CourseId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string ClassRoom { get; set; } = default!;
    }
}

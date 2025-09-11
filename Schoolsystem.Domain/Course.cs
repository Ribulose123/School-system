using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolsystem.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime CourseHours { get; set; }
        public Teacher AssignedTeacher { get; set; } = default!;
        public int AssignedTeacherId { get; set; }
    }
}

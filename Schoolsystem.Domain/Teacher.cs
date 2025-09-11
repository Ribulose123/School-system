

namespace Schoolsystem.Domain
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; } = default!;
        public GenderType Gender { get; set; }
        public string? Qulification { get; set; }
        public string Email { get; set; } = default!;
        public int PhoneNumber { get; set; }
    }
}

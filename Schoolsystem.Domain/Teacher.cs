using Schoolsystem.Domain.Validations;
using System.ComponentModel.DataAnnotations;

namespace Schoolsystem.Domain
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string TeacherName { get; set; } = default!;

        public GenderType Gender { get; set; }

        public string? Qualification { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = default!;

        [Phone]
        public string? PhoneNumber { get; set; }

        [Required]
        [PastOrTodayDate(ErrorMessage = "Date of hire must be in the past or today.")]
        public DateTime DateOfHire { get; set; }

        [Required]
        [PastOrTodayDate(ErrorMessage = "Date of birth must be in the past or today.")]
        public DateTime DateOfBirth { get; set; }
    }
}

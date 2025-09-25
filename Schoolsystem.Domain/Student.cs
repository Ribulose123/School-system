using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolsystem.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public GenderType Gender { get; set; }
        public string? PhoneNumber { get; set; }   
        public DateTime DateOfEnrollement { get; set; }


    }
}

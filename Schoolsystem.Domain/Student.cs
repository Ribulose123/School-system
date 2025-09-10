using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolsystem.Domain
{
    public class Student
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string address { get; set; }
        public GenderType Gender { get; set; }

        public int phoneNumber { get; set; }
        public DateTime dateOfEnrollement { get; set; }

    }
}

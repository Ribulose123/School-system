using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolsystem.Domain.Validations
{
    public class PastOrTodayDateAttribute: ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(value is DateTime dateTime)
            {
                return dateTime.Date <= DateTime.Today;
            }
            return true;
        }
    }
}

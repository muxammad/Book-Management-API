using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Managment.Application.Helper.Attributes
{
    public class YearOnlyAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Publication year is required.");
            }

            if (value is DateTime dateTime)
            {
                // Ensure the date is exactly January 1st
                if (dateTime.Month != 1 || dateTime.Day != 1)
                {
                    return new ValidationResult("Only the year should be provided, formatted as YYYY-01-01.");
                }

                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid date format.");
        }
    }
}

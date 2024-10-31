using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPdotNetCoreWebApp.Domain.Attribute
{
    public class AgeRequirementAttribute : ValidationAttribute
    {
        private readonly int _minimumAge;

        public AgeRequirementAttribute(int minimumAge)
        {
            _minimumAge = minimumAge;
            ErrorMessage = $"Age must be at least {_minimumAge}.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is int age && age >= _minimumAge)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage);
        }
    }
}

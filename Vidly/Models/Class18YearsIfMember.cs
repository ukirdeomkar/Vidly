using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Class18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.PayAsYouGo || customer.MembershipTypeId == MembershipType.Unknown)
                return ValidationResult.Success;
            if (customer.BirthDate == null)
                return new ValidationResult("Birthdate is Required");
            
            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("This membership requires minimum age 18");
        }
    }
}

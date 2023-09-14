

using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class EmptyMembershipString : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            //if(customer.MembershipTypeId == '')
            //{
            //    return new ValidationResult("please select a membership type");
            //}
            return ValidationResult.Success;
        }

    }
}

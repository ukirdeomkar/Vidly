using FluentValidation;
using Vidly.Models;

namespace Vidly.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() { 
            RuleFor(c=>c.Name ).NotEmpty().WithMessage("THe name must not be blank");
            
        }
    }
}

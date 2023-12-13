using FluentValidation;
using Getri_API_EmployeeServiceWithFluentValidation.Models;

namespace Getri_API_EmployeeServiceWithFluentValidation.Validation
{
    public class EmployeeValidation : AbstractValidator<Employee>
    {
        public EmployeeValidation() 
        { 
            RuleFor(x => x.EmpId).NotNull();
            RuleFor(x => x.EmpName).Length(5, 50).WithMessage("Employee Name length should be between 5 to 10 characters.");
            RuleFor(x => x.EmpName).NotNull().WithMessage("Employee Name should not be blank.");
            RuleFor(x => x.EmpEmail).EmailAddress().WithMessage("Email Address should be in proper format.");
            RuleFor(x => x.EmpAge).InclusiveBetween(20, 60).WithMessage("Employee Age should be between 20 to 60.");
            RuleFor(x => x.EmpPhoneNo).MinimumLength(10).MaximumLength(15).WithMessage("Phone Number should be between 10 to 15 digits.");
        }
    }
}

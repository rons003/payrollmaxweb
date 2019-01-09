

using FluentValidation;

namespace payroll.ViewModels.Validations
{
    public class RegistrationViewModelValidator : AbstractValidator<RegistrationViewModel>
    {
        public RegistrationViewModelValidator()
        {
            RuleFor(vm => vm.Email).NotEmpty().WithMessage("Email cannot be empty");
            RuleFor(vm => vm.Password).NotEmpty().WithMessage("Password cannot be empty");
            RuleFor(vm => vm.EmployeeNo).NotEmpty().WithMessage("Employee Number cannot be empty");
            RuleFor(vm => vm.Birthday).NotEmpty().WithMessage("Birthday cannot be empty"); 
            RuleFor(vm => vm.MiddleInitial).NotEmpty().WithMessage("Middle Initial cannot be empty");        
        }
    }
}


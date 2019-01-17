

using FluentValidation;

namespace payroll.ViewModels.Validations
{
    public class RegistrationViewModelValidator : AbstractValidator<RegistrationViewModel>
    {
        public RegistrationViewModelValidator()
        {
            RuleFor(vm => vm.Email).NotEmpty().WithMessage("Email cannot be empty");
            RuleFor(vm => vm.Password).NotEmpty().WithMessage("Password cannot be empty");
            RuleFor(vm => vm.UserName).NotEmpty().WithMessage("Employee Number cannot be empty");
            RuleFor(vm => vm.Birthday).NotEmpty().WithMessage("Birthday cannot be empty"); 
            RuleFor(vm => vm.LastName).NotEmpty().WithMessage("Last Name cannot be empty");     
            RuleFor(vm => vm.QuestionOne).NotEmpty().WithMessage("Question One cannot be empty");    
            RuleFor(vm => vm.QuestionTwo).NotEmpty().WithMessage("Question Two cannot be empty"); 
            RuleFor(vm => vm.QuestionThree).NotEmpty().WithMessage("Question Three cannot be empty"); 
        }
    }
}


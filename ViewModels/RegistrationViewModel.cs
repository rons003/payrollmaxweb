using System;
using FluentValidation;
using payroll.ViewModels.Validations;


namespace payroll.ViewModels
{
    public class RegistrationViewModel
    {
        public string EmployeeNo { get; set; }
        public DateTime Birthday { get; set; }
        public string MiddleInitial { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }   
    }
}
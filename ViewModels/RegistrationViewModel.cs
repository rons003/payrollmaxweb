using System;
using FluentValidation;
using payroll.ViewModels.Validations;


namespace payroll.ViewModels
{
    public class RegistrationViewModel
    {
        public string UserName { get; set; }
        public string Birthday { get; set; }
        public string MiddleInitial { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }   
    }
}
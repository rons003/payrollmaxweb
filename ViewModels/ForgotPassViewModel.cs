using System;
using FluentValidation;
using payroll.ViewModels.Validations;


namespace payroll.ViewModels
{
    public class ForgotPassViewModel
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public int SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
    }
}
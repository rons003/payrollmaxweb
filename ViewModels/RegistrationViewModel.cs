using System;
using FluentValidation;
using payroll.ViewModels.Validations;


namespace payroll.ViewModels
{
    public class RegistrationViewModel
    {
        public string UserName { get; set; }
        public string Birthday { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string QuestionOne { get; set; }
        public string QuestionTwo { get; set; }
        public string QuestionThree { get; set; }
    }
}
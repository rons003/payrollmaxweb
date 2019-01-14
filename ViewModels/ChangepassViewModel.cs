using System;
using FluentValidation;
using payroll.ViewModels.Validations;


namespace payroll.ViewModels
{
    public class ChangepassViewModel
    {
        public string Id { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
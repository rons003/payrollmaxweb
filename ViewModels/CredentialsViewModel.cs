
using FluentValidation.AspNetCore;
using payroll.ViewModels.Validations;
public class CredentialsViewModel
{
    public string EmployeeNo { get; set; }
    public string Password { get; set; }
}
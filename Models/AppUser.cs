using Microsoft.AspNetCore.Identity;
namespace payroll.Models
{
    // Add profile data for application users by adding properties to this class
    public class AppUser : IdentityUser
    {
        // Extended Properties
        public string EmployeeNo { get; set; }
    }
}
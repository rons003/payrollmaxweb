using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        // public string IdentityId { get; set; }   
        // public AppUser Identity { get; set; }  // navigation property
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public int ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Users
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string UserPword { get; set; }
        public string UserLevel { get; set; }
        public string Locked { get; set; }
        public string Status { get; set; }
    }
}

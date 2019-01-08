using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class UserPermission
    {
        public string UserName { get; set; }
        public string NameOfForm { get; set; }
        public string CurrentRights { get; set; }
    }
}

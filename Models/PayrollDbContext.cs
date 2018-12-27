using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace payroll.Models
{
    public class PayrollDbContext : IdentityDbContext<AppUser>
    {
        public PayrollDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
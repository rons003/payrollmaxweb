using payroll.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace payroll.Models
{
    public class IntegraDbContext : IdentityDbContext<AppUser>
    {
        public IntegraDbContext(DbContextOptions<IntegraDbContext> options) : base(options)
        {
        }

        public DbSet<VwsPayrollHeader> VwsPayrollHeaders { get; set; }
        public DbSet<VwsEmployee> VwsEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VwsPayrollHeader>().ToTable("vwsPayrollHeader");
            modelBuilder.Entity<VwsEmployee>().ToTable("vwsEmployees");
        }
    }
}
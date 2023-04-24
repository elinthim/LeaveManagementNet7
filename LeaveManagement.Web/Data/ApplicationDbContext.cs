using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee> // for ordinary/regular database you youse DbContext. But for user related tables you need IdentityDbContext and can be extended to which specific user type iam using with angle brackets <> inside angel brackets i use emplyee that inheritates from Identityuser in employee.cs
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; } /// Press ctrl +D and you will just copy past the line atomaticly

    }
}
using Microsoft.EntityFrameworkCore;

namespace APICore.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        public DbSet<Employees> Employee { get; set; }

    }
}

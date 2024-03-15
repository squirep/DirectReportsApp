using DirectReportsApp.Data;
using Microsoft.EntityFrameworkCore;

namespace DirectReportsApp.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext( DbContextOptions<EmployeeDbContext> options )
            : base( options )
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}

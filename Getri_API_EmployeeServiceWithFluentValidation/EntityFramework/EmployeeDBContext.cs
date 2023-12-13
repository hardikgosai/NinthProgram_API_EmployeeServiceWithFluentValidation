using Getri_API_EmployeeServiceWithFluentValidation.Models;
using Microsoft.EntityFrameworkCore;

namespace Getri_API_EmployeeServiceWithFluentValidation.EntityFramework
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            new EmployeeMap(modelBuilder.Entity<Employee>());
        }
    }
}

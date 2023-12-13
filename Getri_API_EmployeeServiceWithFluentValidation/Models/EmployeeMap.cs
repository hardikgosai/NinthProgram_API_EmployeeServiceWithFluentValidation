using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Getri_API_EmployeeServiceWithFluentValidation.Models
{
    public class EmployeeMap
    {
        public EmployeeMap(EntityTypeBuilder<Employee> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.EmpId);
            entityTypeBuilder.Property(t => t.EmpId).IsRequired();
            entityTypeBuilder.Property(t => t.EmpName).IsRequired();
            entityTypeBuilder.Property(t => t.EmpName).HasMaxLength(50);
            entityTypeBuilder.Property(t => t.EmpAge).IsRequired();
            //entityTypeBuilder.Property(t => t.EmpEmail).IsRequired();
            entityTypeBuilder.Property(t => t.EmpGender).IsRequired();
            entityTypeBuilder.Property(t => t.EmpCountry).IsRequired();
            entityTypeBuilder.Property(t => t.EmpCity).IsRequired();
            //entityTypeBuilder.Property(t => t.EmpAddress).IsRequired();
            entityTypeBuilder.Property(t => t.EmpPhoneNo).IsRequired();
        }
    }
}

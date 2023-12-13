using Getri_API_EmployeeServiceWithFluentValidation.EntityFramework;
using Getri_API_EmployeeServiceWithFluentValidation.Models;

namespace Getri_API_EmployeeServiceWithFluentValidation.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext employeeDBContext;

        public EmployeeRepository(EmployeeDBContext _employeeDBContext)
        {
            employeeDBContext = _employeeDBContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            var employee1 = employeeDBContext.Employees.Add(employee);
            employeeDBContext.SaveChanges();
            return employee1.Entity;
        }

        public bool DeleteEmployee(int id)
        {
            Employee employee = employeeDBContext.Employees.Find(id);
            if (employee != null)
            {
                employeeDBContext.Employees.Remove(employee);
                employeeDBContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }            
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
           return employeeDBContext.Employees;
        }

        public Employee SearchEmployee(int id)
        {
            return employeeDBContext.Employees.Find(id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var employee1 = employeeDBContext.Employees.Update(employee);
            employeeDBContext.SaveChanges();
            return employee1.Entity;
        }
    }
}

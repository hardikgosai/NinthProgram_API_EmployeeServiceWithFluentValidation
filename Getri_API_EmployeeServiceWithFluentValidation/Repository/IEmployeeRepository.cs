using Getri_API_EmployeeServiceWithFluentValidation.Models;

namespace Getri_API_EmployeeServiceWithFluentValidation.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();

        Employee SearchEmployee(int id);

        Employee AddEmployee(Employee employee);

        Employee UpdateEmployee(Employee employee);

        bool DeleteEmployee(int id);
    }
}

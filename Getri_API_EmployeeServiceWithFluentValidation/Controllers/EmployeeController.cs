using Getri_API_EmployeeServiceWithFluentValidation.Models;
using Getri_API_EmployeeServiceWithFluentValidation.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Getri_API_EmployeeServiceWithFluentValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        [HttpGet("EmployeeList")]
        public IActionResult GetAllEmployees()
        {
            return Ok(employeeRepository.GetAllEmployees());
        }

        [HttpGet("SearchEmployee")]
        public IActionResult SearchEmployee(int id)
        {
            var employee = employeeRepository.SearchEmployee(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {
                return NotFound("Employee not found");
            }
        }

        [HttpPost("CreateEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var employee1 = employeeRepository.AddEmployee(employee);
                return Ok(employee1);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("EditEmployee")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {               
                var employee1 = employeeRepository.UpdateEmployee(employee);
                return Ok(employee1);               
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("EmployeeDelete")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = employeeRepository.SearchEmployee(id);
            if (employee != null)
            {
                return Ok(employeeRepository.DeleteEmployee(id));
            }
            else
            {
                return NotFound("Employee not found");
            }
        }
    }
}

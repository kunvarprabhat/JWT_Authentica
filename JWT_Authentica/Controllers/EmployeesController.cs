using JWT_Authentica.Interfaces;
using JWT_Authentica.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace JWT_Authentica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,User")]
        public List<Employee> GetEmployee()
        {
            return _employeeService.GetEmployeesDetails();
        }
        [HttpPost]
        [Authorize]
        public Employee AddEmployee([FromBody] Employee model)
        {
            var emplyee = _employeeService.AddEmployee(model);
            return emplyee;
        }
    }
}

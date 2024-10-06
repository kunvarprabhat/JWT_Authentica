using JWT_Authentica.Context;
using JWT_Authentica.Interfaces;
using JWT_Authentica.Models;

namespace JWT_Authentica.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly JwtContext _context;
        public EmployeeService( JwtContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            var emp = _context.Employees.Add(employee);
            _context.SaveChanges();
            return emp.Entity;
        }
        public List<Employee> GetEmployeesDetails()
        {
            var employee = _context.Employees.ToList();
            return employee;
        }
    }
}

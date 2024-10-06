using JWT_Authentica.Models;

namespace JWT_Authentica.Interfaces
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeesDetails();
        public Employee AddEmployee(Employee employee);
    }
}

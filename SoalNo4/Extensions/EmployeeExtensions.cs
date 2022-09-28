using SoalNo4.Entities;

namespace SoalNo4.Extensions
{
    public static class EmployeeExtensions
    {
        public static void Map(this Employee dbEmployee, Employee employee)
        {
            dbEmployee.Name = employee.Name;
            dbEmployee.Email = employee.Email;
            dbEmployee.Phone = employee.Phone;
            dbEmployee.Salary = employee.Salary;
        }
    }
}

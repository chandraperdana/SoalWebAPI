using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoalNo4.ActionFilters;
using SoalNo4.Entities;
using SoalNo4.Extensions;

namespace SoalNo4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employees = dbContext.Employees.ToList();

            return Ok(employees);
        }

        [HttpGet("{id}", Name = "EmployeeById")]
        [ServiceFilter(typeof(ValidateEntityExistsAttribute<Employee>))]
        public IActionResult Get(Guid id)
        {
            var dbEmployee = HttpContext.Items["entity"] as Employee;

            return Ok(dbEmployee);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public IActionResult Post([FromBody] Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();

            return CreatedAtRoute("EmployeeById", new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateEntityExistsAttribute<Employee>))]
        public IActionResult Put(Guid id, [FromBody] Employee employee)
        {
            var dbEmployee = HttpContext.Items["entity"] as Employee;
            dbEmployee.Map(employee);

            dbContext.Employees.Update(dbEmployee);
            dbContext.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateEntityExistsAttribute<Employee>))]
        public IActionResult Delete(Guid id)
        {
            var dbEmployee = HttpContext.Items["entity"] as Employee;

            dbContext.Employees.Remove(dbEmployee);
            dbContext.SaveChanges();

            return NoContent();
        }
    }
}

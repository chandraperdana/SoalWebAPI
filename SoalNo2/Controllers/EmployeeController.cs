using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoalNo2.Data;
using SoalNo2.Models;
using System.Text.Json;

namespace SoalNo2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees(int pageSize = 0, int pageNumber = 1)
        {
            IQueryable<Employee> query = _db.Employees;

            if (pageSize > 0)
            {
                if (pageSize > 100)
                {
                    pageSize = 100;
                }
                query = query.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
            }

            var employees = await query.ToListAsync();

            Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagination));
            return Ok(employees);
        }
    }
}

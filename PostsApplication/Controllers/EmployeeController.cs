using Microsoft.AspNetCore.Mvc;
using PostsApplication.Models;

namespace PostsApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static readonly List<Employee> employees = new()
        {
            new Employee { Id = 1,Name="john Doe",Designation="Manager",Email="xyz@gmail.com",Phone="42343234234" },
            new Employee { Id = 2,Name="Jack more",Designation="Senior Manager",Email="abc@gmail.com",Phone="121212333" }
        };
        [HttpGet]
        public IActionResult GetEmployeeDetails()
        {
            return Ok(employees);
        }
    }
}

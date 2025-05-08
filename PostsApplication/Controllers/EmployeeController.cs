using Microsoft.AspNetCore.Mvc;
using PostsApplication.Models;

namespace PostsApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static readonly List<Employee> emp = new()
        {
            new Employee { Id = 1,Name="john Doe2",Projects = new List<Projects>
                {
                    new Projects { projectName = "Retain" },
                    new Projects { projectName = "WFM" }
                },Designation="Manager",Email="xyz@gmail.com",Phone="42343234234" },
            new Employee { Id = 2,Name="Jack more",Projects = new List<Projects>
                {
                    new Projects { projectName = "Retain" }
                },Designation="Senior Manager",Email="abc@gmail.com",Phone="121212333" }
        };
        [HttpGet]
        public IActionResult GetEmployeeDetails()
        {
            return Ok(emp);
        }


    }
}

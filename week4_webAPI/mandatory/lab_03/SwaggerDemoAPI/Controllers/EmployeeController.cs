using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SwaggerDemoAPI.Models;
using SwaggerDemoAPI.Filters;

namespace SwaggerDemoAPI.Controllers
{
    [ApiController]
    [Route("api/emp")]
    [ServiceFilter(typeof(CustomAuthFilter))]  
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Salary = 60000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "IT" },
                    Skills = new List<Skill> {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(1990, 5, 1)
                }
            };
        }

        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> GetStandard()
        {
            

            return Ok(employees);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Employee emp)
        {
            if (emp == null)
                return BadRequest("Invalid Employee Data");

            employees.Add(emp);
            return Ok(emp);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SwaggerDemoAPI.Models;
using System.Collections.Generic;

namespace SwaggerDemoAPI.Controllers
{
    [ApiController]
    [Route("api/emp")] 
    public class EmployeeController : ControllerBase
    {
     
        private static readonly List<Employee> Employees = new()
        {
            new Employee { Id = 1, Name = "Alice", Position = "Developer", Salary = 60000 },
            new Employee { Id = 2, Name = "Bob", Position = "Manager", Salary = 80000 },
            new Employee { Id = 3, Name = "Charlie", Position = "Tester", Salary = 50000 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(Employees);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var emp = Employees.Find(e => e.Id == id);
            if (emp == null) return NotFound();
            return Ok(emp);
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            employee.Id = Employees.Count + 1;
            Employees.Add(employee);
            return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
        }

   
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee updatedEmployee)
        {
            var emp = Employees.Find(e => e.Id == id);
            if (emp == null) return NotFound();

            emp.Name = updatedEmployee.Name;
            emp.Position = updatedEmployee.Position;
            emp.Salary = updatedEmployee.Salary;

            return NoContent();
        }

      
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var emp = Employees.Find(e => e.Id == id);
            if (emp == null) return NotFound();

            Employees.Remove(emp);
            return NoContent();
        }
    }
}

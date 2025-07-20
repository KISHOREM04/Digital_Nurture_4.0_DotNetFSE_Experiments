using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SwaggerDemoAPI.Models;
using SwaggerDemoAPI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SwaggerDemoAPI.Controller
{
    [ApiController]
    [Route("api/emp")]
    [ServiceFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
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
            },
            new Employee
            {
                Id = 2,
                Name = "Bob",
                Salary = 50000,
                Permanent = false,
                Department = new Department { Id = 2, Name = "HR" },
                Skills = new List<Skill> {
                    new Skill { Id = 3, Name = "Communication" }
                },
                DateOfBirth = new DateTime(1992, 7, 15)
            }
        };

       
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> GetAll()
        {
            return Ok(employees);
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee emp)
        {
            if (emp == null)
                return BadRequest("Invalid Employee Data");

            emp.Id = employees.Max(e => e.Id) + 1;
            employees.Add(emp);
            return Ok(emp);
        }

   
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee emp)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existing = employees.FirstOrDefault(e => e.Id == id);
            if (existing == null)
                return BadRequest("Invalid employee id");

  
            existing.Name = emp.Name;
            existing.Salary = emp.Salary;
            existing.Permanent = emp.Permanent;
            existing.Department = emp.Department;
            existing.Skills = emp.Skills;
            existing.DateOfBirth = emp.DateOfBirth;

            return Ok(existing);
        }

        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return NotFound("Employee not found");

            employees.Remove(emp);
            return Ok($"Employee with id {id} deleted");
        }
    }
}

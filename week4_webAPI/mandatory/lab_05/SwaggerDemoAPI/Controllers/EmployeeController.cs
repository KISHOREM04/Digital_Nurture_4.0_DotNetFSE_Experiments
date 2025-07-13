using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Id = 1, Name = "Jeevapriya", Role = "Admin" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid ID");

            return Ok($"Employee with ID {id} deleted.");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] EmployeeModel model)
        {
            if (id <= 0 || model == null)
                return BadRequest("Invalid data");

            return Ok(new { Message = "Updated successfully", Data = model });
        }
    }

    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}

using ITE_Q2_32E3_Esguerra_Ma.Corolla.DTO.User;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ITE_Q2_32E3_Esguerra_Ma.Corolla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new GetUserResponse { Message = "Users successfully retrieved!" });
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
            {
                return BadRequest(new { message = "Invalid user ID!" });
            }

            if (id < 0)
            {
                return NotFound(new { message = $"User with ID {id} not found" });
            }
            return Ok(new GetUserResponse { Message = $"User with ID {id} successfully searched!" });
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] AddUserRequest value)
        {
            return Ok(new AddUserResponse { Message = "User successfully added!", User = value });
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public IActionResult Put( [FromBody] EditUserRequest value)
        {
            return Ok(new EditUserResponse { Message = "User successfully edited!", User = value });
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}

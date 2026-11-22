using ITE_Q2_32E3_Esguerra_Ma.Corolla.DTO.User;
using ITE_Q2_32E3_Esguerra_Ma.Corolla.DTO.UserGroup;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ITE_Q2_32E3_Esguerra_Ma.Corolla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupController : ControllerBase
    {
        // GET: api/<UserGroupController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserGroupController>/5
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
            return Ok(new GetUserGroupResponse { Message = $"User group with ID {id} successfully searched!" });
        }

        // POST api/<UserGroupController>
        [HttpPost]
        public IActionResult Post([FromBody] AddGroupRequest value)
        {
            return Ok(new AddUserGroupResponse { Message = "User group successfully added!", User = value });
        }

        // PUT api/<UserGroupController>/5
        [HttpPut]
        public IActionResult Put(int id, [FromBody] EditUserRequest value)
        {
            return Ok(new EditUserGroupResponse { Message = "User group successfully edited!", User = value });
        }

        // DELETE api/<UserGroupController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

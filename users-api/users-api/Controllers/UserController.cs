using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using users_api.Models;

namespace users_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = new User() { 
                Id = 1,
                FirstName = "Phillip",
                LastName = "Jones",
                Email = "ptj92e@gmail.com",
                Active = true
            };
            return Ok(user);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateNewUser([FromBody] CreateUserInput userInput)
        {
            // Check password rules and create new auth record
            // Create new user tied to that auth record
            return Ok(userInput);
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateUser(int id)
        {
            // get user to update
            // update user
            return Ok(id);
        }

        [HttpPut("deactivate")]
        public async Task<IActionResult> DeactivateUser(int id)
        {
            // Set user active status to false
            return Ok(id);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            // Delete user and corresponding auth record
            return Ok(200);
        }
    }
}

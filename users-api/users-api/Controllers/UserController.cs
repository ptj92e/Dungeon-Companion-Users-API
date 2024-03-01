using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using users_api.Interfaces;
using users_api.Models;
using users_api.Services;

namespace users_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public UserController(ILogger<UserController> logger, IUserService userService, IAuthService authService)
        {
            _logger = logger;
            _userService = userService;
            _authService = authService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userService.GetUser(id);
            return Ok(user);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateNewUser([FromBody] CreateUserInput userInput)
        {
            // Check password rules and create new auth record
            var recordId = await _authService.CreateAuthRecord(userInput);
            // Create new user tied to that auth record
            var newUser = await _userService.CreateNewUser(userInput, recordId);


            return Ok(newUser);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser([FromBody] User userUpdate)
        {
            // get user to update
            var user = await _userService.GetUser(userUpdate.Id);

            // update user
            var updatedUser = await _userService.UpdateUserInfo(userUpdate);

            return Ok(updatedUser.Id);
        }

        [HttpPut("deactivate")]
        public async Task<IActionResult> DeactivateUser(int id)
        {
            // Set user active status to false
            var user = await _userService.GetUser(id);

            var deactivatedUser = await _userService.UpdateUserInfo(user);

            return Ok(deactivatedUser.Id);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            // Delete user and corresponding auth record
            var deleted = await _userService.DeleteUser(id);

            return Ok(deleted);
        }
    }
}

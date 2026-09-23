using Microsoft.AspNetCore.Mvc;
using PersonalFinTracker.Api.Contracts.Users;
using PersonalFinTracker.Application.Users;


namespace PersonalFinTracker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest request)
        {
            Guid id = await _userService.CreateAsync(request.Name, request.Email);

            UserResponse response = new UserResponse(id, request.Name, request.Email);

            return CreatedAtAction(nameof(GetById), new { id }, response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }
    }
}
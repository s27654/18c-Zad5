using Microsoft.AspNetCore.Mvc;
using WebApplication1.Animal;

namespace WebApplication1
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ValidationService _validationService;

        public UserController(ValidationService validationService)
        {
            _validationService = validationService;
        }

        [HttpPost("validate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> ValidateUser([FromBody] User user)
        {
            return null;
        }
    }
}


using Microsoft.AspNetCore.Mvc;
using YourFinance.Backend.Models;
using YourFinance.Backend.Services;

namespace YourFinance.Auth.Api.Controllers;

// Controller used to handle requests to create new accounts
// and requests to log into existing accounts
[ApiController]
[Route("users")]
public class AuthenticationController : ControllerBase {
    private readonly AuthenticationService _authService;
    
    public AuthenticationController(AuthenticationService authService) {
        _authService = authService;
    }

    // POST route controller used to handle requests to create new accounts
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] AuthorizationRequest request) {
        try {
            var newUser = await _authService.Register(request);
            return Created("", newUser);
        }
        catch (InvalidOperationException ex) {
            return Conflict(new { message = ex.Message }); // 409 for duplicate username
        }
        catch (ArgumentException ex) {
            return BadRequest(new { message = ex.Message }); // 400 for validation
        }

    }

    // POST route controller used to handle requests to log into existing accounts
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] AuthorizationRequest request) {
        try {
            var existingUser = await _authService.Login(request);
            return Ok(existingUser);
        }
        catch (UnauthorizedAccessException) {
            return Unauthorized(new { message = "Invalid credentials." });
        }
    }
}
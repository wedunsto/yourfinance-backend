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
    public IActionResult Register([FromBody] AuthorizationRequest request) {
        var newUser = _authService.Register(request);
        return Created("", newUser);
    }

    // POST route controller used to handle requests to log into existing accounts
    [HttpPost("login")]
    public IActionResult Login([FromBody] AuthorizationRequest request) {
        var existingUser = _authService.Login(request);
        return Ok(existingUser);
    }
}
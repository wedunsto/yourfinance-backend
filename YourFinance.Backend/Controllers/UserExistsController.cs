using Microsoft.AspNetCore.Mvc;
using YourFinance.Backend.Models;
using YourFinance.Backend.Services;

namespace YourFinance.Backend.Controllers;

[ApiController]
[Route("users")]
public class UserExistsController : ControllerBase {
	private readonly UserExistsService _userExistsService;
	
	public UserExistsController(UserExistsService getUserService) {
		_userExistsService = getUserService;
	}
	
	[HttpGet("exists")]
	public ActionResult<UserExistsResponse> Exists([FromQuery] string username) {
		var exists = _userExistsService.UserExists(username);
		
		return Ok(new UserExistsResponse(exists));
	}
}
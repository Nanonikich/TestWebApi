using Microsoft.AspNetCore.Mvc;

namespace Service.Api.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
	[HttpGet]
	public IActionResult GetUsers()
	{
		var users = new[]
		{
			new { Name = "Nikita" },
		};

		return Ok(users);
	}
}

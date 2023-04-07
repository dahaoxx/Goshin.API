using Goshin.API.Controllers.Abstractions;
using Goshin.API.Mappers;
using Goshin.API.Models.Request;
using Goshin.API.Models.Response;
using Goshin.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Goshin.API.Controllers;

public class UserController : AuthControllerBase
{
	private readonly IUserService _userService;
	
	public UserController(IUserService userService)
	{
		_userService = userService;
	}
	
	[HttpPost, AllowAnonymous] 
	public async Task<ActionResult<AddUserResponse>> Post([FromBody] AddUserRequest addUserRequest)
	{
		var user = addUserRequest.ToDomain();
		var addedUser = await _userService.AddAsync(user, addUserRequest.Password);
		if (addedUser is null)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, "The server failed to add the user");
		}
		
		return Ok(addedUser.ToResponse());
	}
}


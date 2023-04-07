using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Goshin.API.Auth;
using Goshin.API.Auth.Config;
using Goshin.API.Controllers.Abstractions;
using Goshin.API.Models.Request;
using Goshin.Domain.Entities;
using Goshin.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Goshin.API.Controllers;

public class AuthenticationController : ApiControllerBase
{
	private readonly IUserService _userService;
	private readonly IOptions<JwtOptions> _jwtOptions;

	public AuthenticationController(IUserService userService, IOptions<JwtOptions> jwtOptions)
	{
		_userService = userService;
		_jwtOptions = jwtOptions;
	}
	
	[HttpPost]
	public async Task<ActionResult<string>> Authenticate([FromBody] LoginRequest loginRequest)
	{
		var authenticatedUser = await _userService.Authenticate(loginRequest.Username, loginRequest.Password);
		if (authenticatedUser is null)
		{
			return StatusCode(StatusCodes.Status401Unauthorized, "Invalid username or password");
		}

		var jwtSecurityToken = CreateJwt(authenticatedUser);
		var tokenToReturn = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

		return Ok(tokenToReturn);
	}

	private JwtSecurityToken CreateJwt(User user)
	{
		var signingCredentials = CreateSigninCredentials();
		var claims = CreateClaims(user);

		var jwtSecurityToken = new JwtSecurityToken(_jwtOptions.Value.Issuer,
			_jwtOptions.Value.Audience,
			claims,
			DateTime.UtcNow,
			DateTime.UtcNow.AddHours(3),
			signingCredentials);

		return jwtSecurityToken;
	}

	private SigningCredentials CreateSigninCredentials()
	{
		var jwtSecret = _jwtOptions.Value.Secret;
		var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecret));
		var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

		return signingCredentials;
	}

	private static IEnumerable<Claim> CreateClaims(User user)
	{
		var claimList = new List<Claim>
		{
			AuthenticationClaim.Level(user.Level),
			AuthenticationClaim.Roles(user.Roles)
		};
		
		return claimList;
	}
}


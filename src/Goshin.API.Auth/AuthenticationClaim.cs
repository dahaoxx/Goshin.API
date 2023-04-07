using System.Security.Claims;
using Goshin.Domain.Enums;

namespace Goshin.API.Auth;

public readonly record struct AuthenticationClaim(string Name, string Value)
{
	public static AuthenticationClaim Level(Level level) => new(ClaimName.Level, level.ToString());
	public static AuthenticationClaim Roles(Role roles) => new(ClaimName.Role, roles.ToString());

	public static implicit operator Claim(AuthenticationClaim claim)
		=> new(claim.Name, claim.Value);
}


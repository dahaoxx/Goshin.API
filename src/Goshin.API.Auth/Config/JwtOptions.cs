namespace Goshin.API.Auth.Config;

public class JwtOptions
{
	public const string SectionName = "JWT";
	public required string Issuer { get; set; }
	public required string Audience { get; set; }
	public required string Secret { get; set; }
}


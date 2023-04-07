namespace Goshin.Services.Sanity.Config;

public class GoshinSanityOptions
{
	public const string SectionName = "Sanity";
	public string ProjectId { get; set; } = string.Empty;
	public string Dataset { get; set; }	= string.Empty;
	public string Token { get; set; } = string.Empty;
	public string ApiVersion { get; set; } = "v1";
	public bool UseCdn { get; set; }
}


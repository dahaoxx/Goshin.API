using Newtonsoft.Json;

namespace Goshin.Services.Sanity.Models;

public class SanityLevel
{
	[JsonProperty("_id")] public required string Id { get; set; }
	[JsonProperty("_type")] public string DocumentType => "level";
	public int LevelId { get; init; }
	public string Name { get; init; } = string.Empty;
}


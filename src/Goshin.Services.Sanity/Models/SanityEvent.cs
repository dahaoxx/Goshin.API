using Newtonsoft.Json;
using Sanity.Linq.CommonTypes;

namespace Goshin.Services.Sanity.Models;

public class SanityEvent
{
    [JsonProperty("_id")] public required string Id { get; set; }
    [JsonProperty("_type")] public string DocumentType => "event";
    public string Title { get; init; } = string.Empty;
    public List<SanityBlock> Content { get; init; } = new();
    public DateTime Date { get; init; }
    public DateTime LastSignupDate { get; init; }
    public List<SanityReference<SanityLevel>> VisibleTo { get; init; } = new();
    public List<SanityReference<SanityLevel>> CanParticipate { get; init; } = new();
    public int Price { get; init; }
}
using Newtonsoft.Json;
using Sanity.Linq.CommonTypes;

namespace Goshin.Services.Sanity.Models;

public class SanityArticle
{
    [JsonProperty("_id")] public required string Id { get; set; }

    [JsonProperty("_type")] public string DocumentType => "article";
    public string Title { get; init; } = string.Empty;
    public List<SanityBlock> Content { get; init; } = new();
    public List<SanityReference<SanityLevel>> VisibleTo { get; init; } = new();
}
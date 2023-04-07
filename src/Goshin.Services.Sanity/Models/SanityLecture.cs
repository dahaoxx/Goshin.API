using Sanity.Linq.CommonTypes;

namespace Goshin.Services.Sanity.Models;

internal class SanityLecture : SanityDocument
{
    internal string Name { get; set; } = string.Empty;
    internal DateTimeOffset Date { get; set; }
    internal string Number { get; set; } = string.Empty;
    internal string Description { get; set; } = string.Empty;
    internal IEnumerable<SanityVideo> Videos { get; set; } = new List<SanityVideo>();
}
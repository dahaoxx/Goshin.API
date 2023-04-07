using Sanity.Linq.CommonTypes;

namespace Goshin.Services.Sanity.Models;

internal class SanityProduct : SanityDocument
{
    internal string Name { get; set; } = string.Empty;
    internal string Description { get; set; } = string.Empty;
    internal double Price { get; set; }
    internal string ImageUrl { get; set; } = string.Empty;
    internal IEnumerable<string> Sizes { get; set; } = new List<string>();
}
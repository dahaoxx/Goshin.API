using Sanity.Linq.CommonTypes;

namespace Goshin.Services.Sanity.Models;

internal class SanityVideo : SanityDocument
{
    internal string Title { get; set; } = string.Empty;
    internal string Url { get; set; } = string.Empty;
    internal string ThumbnailUrl { get; set; } = string.Empty;
}
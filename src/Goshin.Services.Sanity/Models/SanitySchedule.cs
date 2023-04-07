
using Sanity.Linq.CommonTypes;

namespace Goshin.Services.Sanity.Models;

internal class SanitySchedule : SanityDocument
{
    internal Domain.Enums.Level Class { get; set; }
    internal string Title { get; set; } = string.Empty;
    internal IEnumerable<SanityLecture> Lecture = new List<SanityLecture>();
}
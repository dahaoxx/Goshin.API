using Goshin.Domain.Contracts;
using Goshin.Domain.Enums;

namespace Goshin.Services.Sanity.Extensions;

internal static class EnumerableExtensions
{
	internal static IEnumerable<T> WhereVisibleTo<T>(this IEnumerable<T> enumerable, Level visibleTo)
		where T : IVisibleTo
	{
		return enumerable.Where(x => x.VisibleTo.Contains(visibleTo));
	}
}


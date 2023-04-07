using Goshin.Domain.Enums;

namespace Goshin.Domain.Contracts;

public interface IVisibleTo
{
	IEnumerable<Level> VisibleTo { get; init; }
}

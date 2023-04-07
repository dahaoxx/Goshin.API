using System.Diagnostics;
using Goshin.Domain.Enums;
using Goshin.Services.Sanity.Models;
using Sanity.Linq.CommonTypes;

namespace Goshin.Services.Sanity.Mappers;

internal static class LevelMapper
{
	internal static IEnumerable<Level> ToDomain(this IEnumerable<SanityReference<SanityLevel>> levelIds)
		=> levelIds.Select(v => v.Value.LevelId.ToDomain());

	private static Level ToDomain(this int levelId)
	{
		return levelId switch
		{
			0 => Level.Champs,
			1 => Level.Junior,
			2 => Level.Basics,
			3 => Level.Mastery,
			_ => throw new UnreachableException("Could not map Sanity.Level.levelId to DomainLevel")
		};
	}

	// TODO: Consider removing this
	internal static int ToSanity(this Level level)
	{
		return level switch
		{
			Level.Champs  => 0,
			Level.Junior  => 1,
			Level.Basics  => 2,
			Level.Mastery => 3,
			_             => throw new UnreachableException("Could not map Domain.Level to Sanity.Level.levelId")
		};
	}
}

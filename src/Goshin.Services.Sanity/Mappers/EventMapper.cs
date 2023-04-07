using Goshin.Domain.Models;
using Goshin.Services.Sanity.Models;
using Sanity.Linq;
using Sanity.Linq.Extensions;

namespace Goshin.Services.Sanity.Mappers;

internal static class EventMapper
{
	internal static IEnumerable<Event> ToDomain(this IEnumerable<SanityEvent> sanityEvents, SanityDataContext sanityContext)
		=> sanityEvents.Select(sanityEvent => sanityEvent.ToDomain(sanityContext));

	internal static Event ToDomain(this SanityEvent sanityEvent, SanityDataContext sanityContext)
		=> new()
		{
			Id = Guid.Parse(sanityEvent.Id),
			Title = sanityEvent.Title,
			Content = sanityEvent.Content.ToHtml(sanityContext),
			Date = sanityEvent.Date,
			LastSignupDate = sanityEvent.LastSignupDate,
			VisibleTo = sanityEvent.VisibleTo.ToDomain(),
			CanParticipate = sanityEvent.CanParticipate.ToDomain(),
			Price = sanityEvent.Price
		};
}


using Goshin.Domain.Enums;
using Goshin.Domain.Models;
using Goshin.Services.Sanity.Config;
using Goshin.Services.Sanity.Contracts;
using Goshin.Services.Sanity.Extensions;
using Goshin.Services.Sanity.Mappers;
using Goshin.Services.Sanity.Models;
using Microsoft.Extensions.Options;
using Sanity.Linq;

namespace Goshin.Services.Sanity;

public class SanityEventService : SanityService, ISanityEventService
{
	private readonly SanityDocumentSet<SanityEvent> _events;

	public SanityEventService(IOptions<GoshinSanityOptions> options)
		: base(options)
	{
		_events = SanityContext.DocumentSet<SanityEvent>();
	}

	public async Task<IEnumerable<Event>> GetAllAsync()
	{
		var sanityEvents = await _events
			.Include(e => e.VisibleTo)
			.Include(e => e.CanParticipate)
			.ToListAsync();
		var domainEvents = sanityEvents.ToDomain(SanityContext);

		return domainEvents;
	}

	public async Task<Event?> GetByIdAsync(Guid id)
	{
		var sanityEvent = await _events.Where(a => a.Id == id.ToString())
			.Include(e => e.VisibleTo)
			.Include(e => e.CanParticipate)
			.FirstOrDefaultAsync();
		var domainEvent = sanityEvent?.ToDomain(SanityContext);

		return domainEvent;
	}

	public async Task<IEnumerable<Event>> GetVisibleToAsync(Level visibleTo)
	{
		var events = await GetAllAsync();
		var visibleDomainEvents = events.WhereVisibleTo(visibleTo);

		return visibleDomainEvents;
	}
}

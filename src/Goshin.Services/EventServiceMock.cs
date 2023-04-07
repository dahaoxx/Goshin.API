using Goshin.Services.Contracts;

namespace Goshin.Services;

public class EventServiceMock : IEventService
{
	public Task<bool> IsSignedUp(Guid userId, Guid eventId)
		=> Task.FromResult(true);
}


namespace Goshin.Services.Contracts;

public interface IEventService
{
	Task<bool> IsSignedUp(Guid userId, Guid eventId);
}

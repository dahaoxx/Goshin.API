using Goshin.Domain.Entities;

namespace Goshin.Services.Contracts;

public interface IUserService
{
	Task<User?> AddAsync(User user, string password);
	Task<User?> Authenticate(string username, string password);
}

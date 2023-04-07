using Goshin.Domain.Entities;

namespace Goshin.Database.Repositories.Contracts;

public interface IUserRepository
{
	Task<User?> GetByUsernameAsync(string username);
	Task<User?> AddAsync(User user);
}

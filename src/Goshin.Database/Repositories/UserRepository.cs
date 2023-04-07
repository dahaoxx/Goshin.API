using Goshin.Database.Repositories.Contracts;
using Goshin.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Goshin.Database.Repositories;

public class UserRepository : IUserRepository
{
	private readonly GoshinContext _context;

	public UserRepository(GoshinContext context)
	{
		_context = context;
	}

	public async Task<User?> AddAsync(User user)
	{
		try
		{
			await _context.Set<User>().AddAsync(user);
			await _context.SaveChangesAsync();
			return user;
		}
		catch (DbUpdateException)
		{
			// TODO: Add logging
		}
		catch (Exception)
		{
			// TODO: Add logging
		}

		return null;
	}

	public async Task<User?> GetByUsernameAsync(string username)
	{
		try
		{
			var user = await _context.Set<User>().FirstOrDefaultAsync(x => x.UserName == username);
			return user;
		}
		catch (DbUpdateException)
		{
			// TODO: Add logging
		}
		catch (Exception)
		{
			// TODO: Add logging
		}

		return null;
	}
}


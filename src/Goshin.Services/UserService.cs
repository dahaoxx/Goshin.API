using Goshin.API.Auth;
using Goshin.Database.Repositories.Contracts;
using Goshin.Domain.Entities;
using Goshin.Domain.Enums;
using Goshin.Services.Contracts;

namespace Goshin.Services;

public class UserService : IUserService
{
	private readonly IUserRepository _userRepository;
	
	public UserService(IUserRepository userRepository)
	{
		_userRepository = userRepository;
	}

	public Task<User?> AddAsync(User user, string password)
	{
		user.Salt = AuthenticationUtils.CreateSalt();
		user.Password = AuthenticationUtils.CreateHash(password, user.Salt);
		user.UserName = CreateUserName(user.FirstName, user.LastName, user.BirthDate);
		user.Roles = Role.Member;

		return _userRepository.AddAsync(user);
	}
	
	public async Task<User?> Authenticate(string username, string password)
	{
		var foundUser = await _userRepository.GetByUsernameAsync(username);
		if (foundUser is null)
		{
			return null;
		}
		
		var isPasswordCorrect = AuthenticationUtils.VerifyPasswordHash(password, foundUser.Password, foundUser.Salt);
		
		return isPasswordCorrect
			? foundUser
			: null;
	}

	// Example: Daniel Hansen born 1998-06-10 will have the username: DanHan98
	private static string CreateUserName(string firstName, string lastName, DateTime birthDate)
		=> $"{firstName[..3]}{lastName[..3]}{birthDate.Year.ToString().Substring(2, 2)}";
}


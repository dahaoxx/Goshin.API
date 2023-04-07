using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Goshin.API.Auth;

public static class AuthenticationUtils
{
	public static byte[] CreateHash(string password, byte[] salt)
		=> KeyDerivation.Pbkdf2(password: password,
			salt: salt,
			prf: KeyDerivationPrf.HMACSHA256,
			iterationCount: 1000,
			numBytesRequested: 32);

	public static byte[] CreateSalt()
	{
		var salt = new byte[24];
		var rng = RandomNumberGenerator.Create();
		rng.GetBytes(salt);
		return salt;
	}

	public static bool VerifyPasswordHash(string password, byte[] hash, byte[] salt)
		=> hash.SequenceEqual(CreateHash(password, salt));
}


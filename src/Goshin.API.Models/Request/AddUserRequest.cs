using Goshin.Domain.Enums;

namespace Goshin.API.Models.Request;

public class AddUserRequest
{
	public required string FirstName { get; init; }
	public required string LastName { get; init; }
	public required string Email { get; init; }
	public required string Password { get; init; }
	public required string PhoneNumber { get; init; }
	public required string Address { get; init; }
	public required string PostalCode { get; init; }
	public required Level Level { get; init; }
	public required DateTime BirthDate { get; init; }
	public required bool IsMailConsented { get; init; }
	public required bool IsImagesConsented { get; init; }
}


using Goshin.API.Models.Request;
using Goshin.API.Models.Response;
using Goshin.Domain.Entities;

namespace Goshin.API.Mappers;

public static class UserMapper
{
	public static User ToDomain(this AddUserRequest addUserRequest)
		=> new()
		{
			FirstName = addUserRequest.FirstName,
			LastName = addUserRequest.LastName,
			Email = addUserRequest.Email,
			PhoneNumber = addUserRequest.PhoneNumber,
			Address = addUserRequest.Address,
			PostalCode = addUserRequest.PostalCode,
			BirthDate = addUserRequest.BirthDate,
			IsMailConsented = addUserRequest.IsMailConsented,
			IsImagesConsented = addUserRequest.IsImagesConsented,
			Level = addUserRequest.Level,
		};
	
	public static AddUserResponse ToResponse(this User user)
		=> new()
		{
			FirstName = user.FirstName,
			LastName = user.LastName,
		};
}


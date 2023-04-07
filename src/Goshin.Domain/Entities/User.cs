using System.ComponentModel.DataAnnotations;
using Goshin.Domain.Abstractions;
using Goshin.Domain.Enums;

namespace Goshin.Domain.Entities;

public class User : EntityBase
{
	[MaxLength(50)] public string UserName { get; set; } = string.Empty;
	[MaxLength(50)] public required string FirstName { get; set; }
	[MaxLength(50)] public required string LastName { get; set; }
	[MaxLength(320)] public required string Email { get; set; }
	[MaxLength(20)] public required string PhoneNumber { get; set; }
	[MaxLength(50)] public required string Address { get; set; }
	[MaxLength(4)] public required string PostalCode { get; set; }
	public Role Roles { get; set; }
	public Level Level { get; set; }
	public required DateTime BirthDate { get; set; }
	public DateTime LastPaymentDate { get; set; } = DateTime.Now;
	public required bool IsMailConsented { get; set; }
	public required bool IsImagesConsented { get; set; }
	public bool IsActive { get; set; } = true;
	public bool IsPasswordForgotten { get; set; }
	public byte[] Password { get; set; } = Array.Empty<byte>();
	public byte[] Salt { get; set; } = Array.Empty<byte>();
}


namespace Goshin.Domain.Enums;

[Flags]
public enum Role
{
	None = 0,
	Admin = 1,
	Accountant = 2,
	Instructor = 4,
	Member = 8,
}

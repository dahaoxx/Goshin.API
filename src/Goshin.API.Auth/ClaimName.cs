namespace Goshin.API.Auth;

public readonly record struct ClaimName
{
	private readonly string _name;

	private ClaimName(string name)
	{
		_name = name;
	}

	public static readonly ClaimName Level = new("Level");
	public static readonly ClaimName Role = new("Role");

	public static implicit operator string(ClaimName claimName)
		=> claimName._name;

}


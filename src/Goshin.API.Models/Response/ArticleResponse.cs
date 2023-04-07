using Goshin.Domain.Enums;

namespace Goshin.API.Models.Response;

public class ArticleResponse
{
	public required Guid Id { get; set; } 
	public required string Title { get; set; }
	public required string Content { get; set; }
}


namespace Goshin.API.Models.Response;

public class ArticleResponse
{
	public Guid Id { get; set; }
	public string Title { get; set; } = string.Empty;
	public string Content { get; set; } = string.Empty;
}


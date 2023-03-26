using Goshin.API.Models.Response;
using Goshin.Domain.Models;

namespace Goshin.Mappers;

public static class ArticleMapper
{
	public static ArticleResponse ToResponse(this Article article) => new()
	{
		Id = article.Id,
		Title = article.Title,
		Content = article.Content
	};
}


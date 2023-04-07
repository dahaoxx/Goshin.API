using Goshin.Domain.Models;
using Goshin.Services.Sanity.Models;
using Sanity.Linq;
using Sanity.Linq.Extensions;

namespace Goshin.Services.Sanity.Mappers;

internal static class ArticleMapper
{
	internal static IEnumerable<Article> ToDomain(this IEnumerable<SanityArticle> sanityArticles, SanityDataContext sanityContext)
		=> sanityArticles.Select(sanityArticle => sanityArticle.ToDomain(sanityContext));

	internal static Article ToDomain(this SanityArticle sanityArticle, SanityDataContext sanityContext)
		=> new()
		{
			Id = Guid.Parse(sanityArticle.Id),
			Title = sanityArticle.Title,
			Content = sanityArticle.Content.ToHtml(sanityContext),
			VisibleTo = sanityArticle.VisibleTo.ToDomain()
		};
}

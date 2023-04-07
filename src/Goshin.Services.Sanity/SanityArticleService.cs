using Goshin.Domain.Enums;
using Goshin.Domain.Models;
using Goshin.Services.Sanity.Config;
using Goshin.Services.Sanity.Contracts;
using Goshin.Services.Sanity.Extensions;
using Goshin.Services.Sanity.Mappers;
using Goshin.Services.Sanity.Models;
using Microsoft.Extensions.Options;
using Sanity.Linq;

namespace Goshin.Services.Sanity;

public class SanityArticleService : SanityService, ISanityArticleService
{
	private readonly SanityDocumentSet<SanityArticle> _articles;
	
	public SanityArticleService(IOptions<GoshinSanityOptions> options)
		: base(options)
	{
		_articles = SanityContext.DocumentSet<SanityArticle>();
	}
	
	public async Task<IEnumerable<Article>> GetAllAsync()
	{
		var sanityArticles = await _articles
			.Include(a => a.VisibleTo)
			.ToListAsync();
		var domainArticles = sanityArticles.ToDomain(SanityContext);

		return domainArticles;
	}

	public async Task<Article?> GetByIdAsync(Guid id)
	{
		var sanityArticle = await _articles
			.Where(a => a.Id == id.ToString())
			.Include(a => a.VisibleTo)
			.FirstOrDefaultAsync();
		var domainArticle = sanityArticle?.ToDomain(SanityContext);

		return domainArticle;
	}
	
	public async Task<IEnumerable<Article>> GetVisibleToAsync(Level visibleTo)
	{
		var articles = await GetAllAsync();
		var visibleDomainArticles = articles.WhereVisibleTo(visibleTo).ToList();

		return visibleDomainArticles;
	}
}


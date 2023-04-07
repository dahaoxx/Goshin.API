using Goshin.Services.Sanity.Config;
using Microsoft.Extensions.Options;
using Sanity.Linq;

namespace Goshin.Services.Sanity;

public class SanityService
{
	protected readonly SanityDataContext SanityContext;

	protected SanityService(IOptions<GoshinSanityOptions> options)
	{
		var sanityOptions = new SanityOptions
		{
			ProjectId = options.Value.ProjectId,
			Dataset = options.Value.Dataset,
			Token = options.Value.Token,
			ApiVersion = options.Value.ApiVersion,
			UseCdn = options.Value.UseCdn,
		};

		SanityContext = new SanityDataContext(sanityOptions);
	}
}


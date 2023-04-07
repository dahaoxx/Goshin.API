using Goshin.Services.Sanity.Config;
using Goshin.Services.Sanity.Contracts;
using Microsoft.Extensions.DependencyInjection;


namespace Goshin.Services.Sanity.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddSanityServices(this IServiceCollection services, Action<GoshinSanityOptions> options)
    {
        services.Configure(options);
        services.AddTransient<ISanityArticleService, SanityArticleService>();
        services.AddTransient<ISanityEventService, SanityEventService>();
        // services.AddTransient<IProductService, ProductServiceMock>();
        // services.AddTransient<IScheduleService, ScheduleServiceMock>();
        // services.AddTransient<IVideosService, VideosServiceMock>();
    }
}
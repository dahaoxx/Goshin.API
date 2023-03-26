using Goshin.Services.Contracts;
using Goshin.Services.Mock;
using Microsoft.Extensions.DependencyInjection;

namespace Goshin.Services.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddGoshinServices(this IServiceCollection services)
    {
        services.AddTransient<IArticleService, ArticleServiceMock>();
        services.AddTransient<IEventService, EventServiceMock>();
        services.AddTransient<IProductService, ProductServiceMock>();
        services.AddTransient<IScheduleService, ScheduleServiceMock>();
    }
}
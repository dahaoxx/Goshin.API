using Goshin.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Goshin.Services.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddGoshinServices(this IServiceCollection services)
    {
        services.AddTransient<IEventService, EventServiceMock>();
        services.AddTransient<IUserService, UserService>();
    }
}
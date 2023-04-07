using Goshin.Database.Repositories;
using Goshin.Database.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Goshin.Database.Extensions;

public static class ServiceCollectionExtensions
{
	public static void AddGoshinDatabase(this IServiceCollection services, IConfiguration configuration)
	{
		var connectionString = configuration.GetConnectionString("DefaultConnection");
		services.AddDbContext<GoshinContext>(dbContextOptions => dbContextOptions.UseSqlServer(connectionString));
		services.AddGoshinRepositories();
	}
	
	private static void AddGoshinRepositories(this IServiceCollection services)
	{
		services.AddTransient<IUserRepository, UserRepository>();
	}
}


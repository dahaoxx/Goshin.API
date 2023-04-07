using Microsoft.OpenApi.Models;

namespace Goshin.API.Extensions;

public static class ServiceCollectionExtensions
{
	public static void AddGoshinSwagger(this IServiceCollection service)
	{
		service.AddSwaggerGen(c =>
		{
			c.SwaggerDoc("v1", new OpenApiInfo()
			{
				Title = "Goshin.API",
				Version = "v1",
			});
			c.AddSecurityDefinition("JWT",
				new OpenApiSecurityScheme
				{
					Description = "JWT Authorization header using the Bearer scheme.",
					Name = "Authorization",
					In = ParameterLocation.Header,
					Type = SecuritySchemeType.Http,
					Scheme = "bearer",
				});
			c.AddSecurityRequirement(new OpenApiSecurityRequirement
			{
				{
					new OpenApiSecurityScheme
					{
						Reference = new OpenApiReference
						{
							Type = ReferenceType.SecurityScheme,
							Id = "JWT",
						},
					},
					new List<string>()
				},
			});
		});
	}
}


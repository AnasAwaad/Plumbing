using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Context;

namespace RepositoryLayer.Extensions;
public static class RepositoryLayerExtensions
{
	public static IServiceCollection LoadRepositoryLayerExtensions(this IServiceCollection services, IConfiguration config)
	{
		// add connection string
		services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
		return services;
	}
}

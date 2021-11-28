using BookShop.ApplicationServices;
using BookShop.Infrastructure.EntityFramework;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookShop.Tests.Bootstrap
{
    public static class Registrations
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(isp => new BookShopContextDbContextFactory(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<BookShopService>();
            return services;
        }
    }
}
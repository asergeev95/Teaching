using System.Threading.Tasks;
using BookShop.Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace BookShop.Tests.Bootstrap
{
    [TestFixture]
    public class BaseTestFixture
    {
        [OneTimeSetUp]
        public async Task OneTimeSetup()
        {
            var dbContextFactory =
                CompositionRoot.ServiceProvider.GetRequiredService<BookShopContextDbContextFactory>();
            await dbContextFactory.GetContext().Database.MigrateAsync();
        }
        
        
    }
}
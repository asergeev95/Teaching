using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.ApplicationServices;
using BookShop.Core;
using BookShop.Infrastructure.EntityFramework;
using BookShop.Tests.Bootstrap;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace BookShop.Tests
{
    [TestFixture]
    public class BookShopServiceTests : BaseTestFixture
    {
        //[OneTimeSetUp] будет выполнено перед запуском ВСЕХ тестов в классе
        //[SetUp] перед каждым тестов
        //[TearDown] будет выполняться после выполнения каждого теста
        //[OneTimeTearDown] после всех тестов в классе

        [TearDown]
        public async Task TearDown()
        {
            var dbContextFactory =
                CompositionRoot.ServiceProvider.GetRequiredService<BookShopContextDbContextFactory>();
            var dbContext = dbContextFactory.GetContext();
            await dbContext.Clear();
        }
        
        [Test]
        public async Task ShouldAddShop()
        {
            var bookShopService = CompositionRoot.ServiceProvider.GetRequiredService<BookShopService>();
            var shops = await bookShopService.AddShop();
            shops.Count.Should().Be(1);
        }
        
        [Test]
        public async Task ShouldGetExactlyOneShop()
        {
            var bookShopService = CompositionRoot.ServiceProvider.GetRequiredService<BookShopService>();
            var shops = await bookShopService.AddShop();
            shops.Count.Should().Be(1);
            var addedShop = shops.First();
            var shopFromDatabase = await bookShopService.GetShop(addedShop.Id);
            shopFromDatabase.Should().NotBeNull();
        }
        
        [Test]
        public async Task ShouldAddAndReceiveShops()
        {
            var bookShopService = CompositionRoot.ServiceProvider.GetRequiredService<BookShopService>();
            await bookShopService.AddShop();
            await bookShopService.AddShop();
            var shops = await bookShopService.GetShops();
            shops.Count.Should().Be(2);

            var books = new List<Book>();
            books.
        }
    }
}
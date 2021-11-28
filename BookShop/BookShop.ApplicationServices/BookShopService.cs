using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Core;
using BookShop.Core.Models;
using BookShop.Infrastructure.EntityFramework;

namespace BookShop.ApplicationServices
{
    public class BookShopService
    {
        private readonly BookShopContextDbContextFactory _dbContextFactory;
        
        public BookShopService(BookShopContextDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<List<Shop>> AddShop()
        {
            var dbContext = _dbContextFactory.GetContext();
            dbContext.AddShop();
            await dbContext.SaveChangesAsync();
            return await dbContext.GetShop();
        }
        public async Task AddBook(AddBookModel model, Guid shopId)
        {
            var bookEntity = new Book(model);
            var dbContext = _dbContextFactory.GetContext();
            var shop = await dbContext.GetShop(shopId);
            shop.AddBook(bookEntity);
            await dbContext.SaveChangesAsync();
        }
        
        public async Task<Shop> GetShop(Guid shopId)
        {
            var dbContext = _dbContextFactory.GetContext();
            var shop = await dbContext.GetShop(shopId);
            return shop;
        }

        public async Task<List<ShopModel>> GetShops()
        {
            var dbContext = _dbContextFactory.GetContext();
            var shops = await dbContext.GetShops();
            return shops.Select(shop => new ShopModel
            {
                Id = shop.Id,
                Balance = shop.Balance,
                Books = shop.Books.Select(book => new BookModel
                {
                    Id = book.Id,
                    Author = book.Author,
                    Name = book.Name,
                    Genre = book.Genre,
                    Price = book.Price
                }).ToList()
            }).ToList();
        }
    }
}
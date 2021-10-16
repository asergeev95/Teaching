using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookShop.Core;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Infrastructure.EntityFramework
{
    public sealed class BookShopDbContext : DbContext
    {
        public const string DefaultSchemaName = "BookShop";
        

        public BookShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.HasDefaultSchema(DefaultSchemaName);
        }
        
        public void AddShop()
        {
            Set<Shop>().Add(new Shop
            {
                Balance = 100,
                Books = new List<Book>()
            });
        }
        
        public async Task<List<Shop>> GetShop()
        {
            return await Set<Shop>().ToListAsync();
        }

        public Task<Shop> GetShop(Guid shopId)
        {
            return Set<Shop>().Include(x => x.Books).SingleOrDefaultAsync(shop => shop.Id == shopId);
        }
      
        public Task<Book> GetBook(long id)
        {
            return Set<Book>().SingleOrDefaultAsync(book => book.Id == id);
        }

        public async Task<List<Shop>> GetShops()
        {
            return await Set<Shop>().Include(x => x.Books).ToListAsync();
        }
    }
}
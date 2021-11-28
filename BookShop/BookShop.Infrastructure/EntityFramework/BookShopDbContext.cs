using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<Shop>> GetShop(Guid shopId)
        {
            var shops = Set<Shop>().Include(x => x.Books);
            var shopsWithBigBalance = shops.Where(x => x.Balance > 100);
            var shopsWithBigBalanceAndALotOfBooks = shopsWithBigBalance.Where(shop => shop.Books.Count > 500);
            var receivedShops =  shopsWithBigBalanceAndALotOfBooks.AsEnumerable();
            var receivedShopsBigBalance = receivedShops.Where(x => x.Balance > 100);
            var receivedShopsWithBigBalanceAndALotOfBooks = receivedShopsBigBalance.Where(shop => shop.Books.Count > 500);
            var finalList = receivedShopsWithBigBalanceAndALotOfBooks.ToList();
        }
     
        public async Task<List<Shop>> GetShops()
        {
            return await Set<Shop>().Include(x => x.Books).ToListAsync();
        }
        
        public async Task Clear()
        {
            var shops = await Set<Shop>().ToListAsync();
            Set<Shop>().RemoveRange(shops);
            await SaveChangesAsync();
        }
    }
}
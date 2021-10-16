using BookShop.ApplicationServices.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Infrastructure
{
    public class BookShopDbContext : DbContext, IBookShopDbContext
    {
        public void AddBook()
        {
            
        }
    }
}
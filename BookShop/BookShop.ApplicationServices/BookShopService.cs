using BookShop.ApplicationServices.Interfaces;

namespace BookShop.ApplicationServices
{
    public class BookShopService
    {
        private readonly IBookShopDbContext _bookShopDbContext;

        public BookShopService(IBookShopDbContext bookShopDbContext)
        {
            _bookShopDbContext = bookShopDbContext;
        }
        public void AddBook()
        {
            _bookShopDbContext.AddBook();
        }
    }
}
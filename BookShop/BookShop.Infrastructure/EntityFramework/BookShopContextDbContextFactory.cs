namespace BookShop.Infrastructure.EntityFramework
{
    public class BookShopContextDbContextFactory 
    {
        private readonly string _connectionString;

        public BookShopContextDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public BookShopDbContext GetContext()
        {
            return new BookShopDbContext(BookShopDbContextDesignTimeFactory.GetSqlServerOptions(_connectionString));
        }
    }
}
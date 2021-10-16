using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookShop.Infrastructure.EntityFramework
{
    [UsedImplicitly]
    public sealed class BookShopDbContextDesignTimeFactory : IDesignTimeDbContextFactory<BookShopDbContext>
    {
        private const string DefaultConnectionString =
            "Server=127.0.0.1;Database=BookShop;User Id = sa;Password=2wsx2WSX;";

        public static DbContextOptions<BookShopDbContext> GetSqlServerOptions([CanBeNull] string connectionString)
        {
            return new DbContextOptionsBuilder<BookShopDbContext>()
                .UseSqlServer(connectionString ?? DefaultConnectionString, x =>
                {
                    x.MigrationsHistoryTable("__EFMigrationsHistory", BookShopDbContext.DefaultSchemaName);
                })
                .Options;
        }
        public BookShopDbContext CreateDbContext(string[] args)
        {
            return new BookShopDbContext(GetSqlServerOptions(null));
        }
    }
}
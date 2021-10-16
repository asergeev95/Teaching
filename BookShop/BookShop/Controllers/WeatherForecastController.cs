using BookShop.ApplicationServices;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    [ApiController]
    [Route("book-shop")]
    public class BookShopController : ControllerBase
    {
        private readonly BookShopService _bookShopService;

        public BookShopController(BookShopService bookShopService)
        {
            _bookShopService = bookShopService;
        }
        
        //GET, POST, DELETE, UPDATE, PATCH
        [HttpPost("add-book")]
        public void AddBook()
        {
            _bookShopService.AddBook();
        }
    }
}
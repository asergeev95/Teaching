using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookShop.ApplicationServices;
using BookShop.ApplicationServices.Models;
using BookShop.Core;
using BookShop.Core.Models;
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
        
        [HttpGet("{id}")]
        public async Task<Shop> GetShop(Guid id)
        {
            return await _bookShopService.GetShop(id);
        }
        
        [HttpGet("all-shops")]
        public async Task<List<ShopModel>> GetShops()
        {
            return await _bookShopService.GetShops();
        }
        
        //GET, POST, DELETE, UPDATE, PATCH
        [HttpPost("add-shop")]
        public async Task<List<Shop>> AddShop()
        {
            return await _bookShopService.AddShop();
        }
        
        //GET, POST, DELETE, UPDATE, PATCH
        [HttpPost("add-book/{shopId}")]
        public async Task AddBook([FromBody] AddBookModel model, Guid shopId)
        {
            await _bookShopService.AddBook(model, shopId);
        }

        [HttpPost("update-book")]
        public void UpdateBook([FromBody] UpdateBookModel model)
        {
            
        }
        
        //сюда добавятся ручки для удаления книги и изменения данных книги
    }
}
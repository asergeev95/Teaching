using System;
using System.Collections.Generic;

namespace BookShop.Core.Models
{
    public class ShopModel
    {
        public Guid Id { get; set; }
        public int Balance { get; set; }
        public List<BookModel> Books { get; set; }
    }
}
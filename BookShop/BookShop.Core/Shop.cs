using System;
using System.Collections.Generic;

namespace BookShop.Core
{
    public class Shop
    {
        
        public Guid Id { get; set; }
        
        public int Balance { get; set; }
        
        public List<Book> Books { get; set; }

        public void AddBook(Book bookEntity)
        {
            Books.Add(bookEntity);
        }
    }
}
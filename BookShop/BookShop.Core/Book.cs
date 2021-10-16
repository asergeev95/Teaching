using System;
using BookShop.ApplicationServices.Models;

namespace BookShop.Core
{
    public class Book
    {
        private Book()
        {
        }
        
        public Book(AddBookModel model)
        {
            Name = model.Name;
            Author = model.Author;
            Price = model.Price;
            Genre = model.Genre;
        }

        public long Id { get; set; }
        public string Name { get; private set; }
        
        public string Author { get; private set; }
        
        public double Price { get; private set; }
        
        public string Genre { get; private set; }
        
        public Guid ShopId { get; set; }
        
        public Shop Shop { get; set; }
    }
}
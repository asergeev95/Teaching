namespace BookShop.Core.Models
{
    public class BookModel
    {
        public long Id { get; set; }
        
        public string Name { get; set; }
        
        public string Author { get; set; }
        
        public double Price { get; set; }
        
        public string Genre { get; set; }
    }
}
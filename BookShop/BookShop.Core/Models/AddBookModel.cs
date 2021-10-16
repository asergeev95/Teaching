namespace BookShop.ApplicationServices.Models
{
    public class AddBookModel
    {
        public string Name { get; set; }
        
        public string Author { get; set; }
        
        public double Price { get; set; }
        
        public string Genre { get; set; }
    }
}
namespace NilaVerse.Models
{
    public class Item
    {
        //Item details
        public int Id { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}

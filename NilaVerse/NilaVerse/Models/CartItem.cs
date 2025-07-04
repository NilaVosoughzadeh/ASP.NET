namespace NilaVerse.Models
{
    public class CartItem
    {
        //CartItem details
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal getTotalPrice()
        {
            return Item.Price = Quantity;
        }
    }
}

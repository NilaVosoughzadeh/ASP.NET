namespace NilaVerse.Models
{
    public class CartViewModel
    {
        //CartViewModel details
        public CartViewModel()
        {
                CartItems = new List<CartItem>();
        }
        public List<CartItem> CartItems { get; set; }
        public decimal OrderTotal { get; set; }
    }
}

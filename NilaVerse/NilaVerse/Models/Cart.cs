namespace NilaVerse.Models
{
    public class Cart
    {
        //Cart details
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public int OrderId { get; set; }
        public List<CartItem> CartItems { get; set; }
        public void addItem(CartItem item)
        {
            if (CartItems.Exists(i => i.Item.Id == item.Id))
            {

            }
            else
            {
                CartItems.Add(item);
            }
        }
        public void removeItem(int item)
        {

        }
    }
}

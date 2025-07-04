namespace NilaVerse.Models
{
    public class Product
    {
        public Product()
        {
            Categories = new List<Category>();
        }

        //Product details
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; }
    }
}

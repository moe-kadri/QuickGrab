
namespace _278Project.Models
{
    public class Cart
    {
        public string? Id { get; set; }
        public int ProductId { get; set; }
        public int quantity { get; set; }

        public User? user { get; set; }
        public Product? product { get; set; }
    }

}
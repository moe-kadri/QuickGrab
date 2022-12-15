namespace _278Project.Models
{

    public class Order
    {
        public int OrderId { get; set; }
        public string? userName { get; set; }
        IEnumerable<int> productsInOrder { get; set; } = null!;

        public string? address { get; set; }
        public int cardNbr { get; set; }
        public string? cardName { get; set; }
        public int expiryMonth { get; set; }
        public int expiryYear { get; set; }
        public int cvv { get; set; }

    }
}
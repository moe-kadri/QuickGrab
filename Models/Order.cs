namespace _278Project.Models{

    public class Order{
        public int UserId{get;set;}
        public int ProductId{get;set;}

        public string? address{get;set;}
        public int cardNbr{get;set;}
        public string? cardName{get;set;}
        public int expiryMonth{get;set;}
        public int expiryYear{get;set;}
        public int cvv{get;set;}

    }
}
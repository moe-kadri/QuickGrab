namespace _278Project.Models{
    public class WishList{

        public WishList(int userId, int productId){
            this.UserId= userId;
            this.ProductId= productId;
        }
        public int UserId{get;set;}
        public int ProductId{get;set;}
        public int quantity{get;set;}

        public User? user{get;set;}
        public Product? product{get;set;}
    }
    
}
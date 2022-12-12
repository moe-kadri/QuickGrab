namespace _278Project.Models{
    public class Product{
        public int ProductId{get;set;}
        public string? name{get;set;}
        public string? weight{get;set;}
        public float price {get;set;}
        public string? category{get;set;}
        public bool is_promoted{get;set;}
        public bool is_best_seller{get;set;}
        public string? imgURL{get;set;}

        public int quantity{get;set;}
    }
}
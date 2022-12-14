using _278Project.Models;
namespace _278Project.Repos;

public interface IAdminsRepo
{
    public void AddProduct(Product product);
    public void RemoveProduct(Product product);

    public void updateProductPrice(int productId, int price);
    public void updateProductQuantity(int productId, int quantity);
    public void updateProductPromotion(int productId, bool promotion);
    public void updateProductBestSeller(int productId, bool bestSeller);

    public void RemoveOrder(int orderId);


}
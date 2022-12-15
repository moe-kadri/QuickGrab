using _278Project.Models;
namespace _278Project.Repos;

public interface IUsersRepo
{
    public void AddtoCart(Cart cart);
    public void AddtoWishList(WishList wishlist);
    public void updateEmail(int id, string mail);
    public void updatePassword(int id, string pass);
    public void updatePhoneNumber(int id, string phone);

    public Cart? getProductFromCart(string userId, int productId);
    public void removeItemFromCart(string userId, int productId);
    public void removeItemFromWishList(string userId, int productId);

    IEnumerable<Product> getProducts();

    public int totalInCart(string id);
    public int totalInWishList(string id);

    public IEnumerable<Product> search(string name);

    public WishList? getProductFromWishList(string userId, int productId);
}
using _278Project.Models;
namespace _278Project.Repos;

public interface IUsersRepo
{
    public void AddtoCart(Cart cart);
    public void AddtoWishList(WishList wishlist);

    public Cart? getProductFromCart(string userId, int productId);
    public void removeItemFromCart(string userId, int productId);
    public void removeItemFromWishList(string userId, int productId);

    IEnumerable<Product> getProducts();
    public IEnumerable<Cart> getCarts();

    public int totalInCart(string id);
    public int totalInWishList(string id);

    // public IEnumerable<Product> search(string name);

    public WishList? getProductFromWishList(string userId, int productId);

    public User? getUserByName(string name);
    public Cart? GetCart(string id, int productId);
    public Product? GetProductById(int id);
}
using _278Project.Data;
using _278Project.Models;
namespace _278Project.Repos;



public class UsersRepo : IUsersRepo
{
    private readonly AppDbContext _context;

    public UsersRepo(AppDbContext context)
    {
        _context = context;
    }

    public void AddtoCart(Cart cart)
    {
        _context.Carts.Add(cart);
        _context.SaveChanges();
    }
    public void AddtoWishList(WishList wishlist)
    {
        _context.WishLists.Add(wishlist);
        _context.SaveChanges();
    }

    public Cart? getProductFromCart(string userId, int productId)
    {
        IQueryable<Cart> query = _context.Carts;
        query = query.Where(c => c.ProductId == productId);
        query = query.Where(c => c.UserName == userId);
        return query.FirstOrDefault();

    }
    public WishList? getProductFromWishList(string userId, int productId)
    {
        IQueryable<WishList> query = _context.WishLists;
        query = query.Where(c => c.ProductId == productId);
        query = query.Where(c => c.Id == userId);
        return query.FirstOrDefault();

    }
    public void removeItemFromCart(string userId, int productId)
    {
        var itemToDelete = getProductFromCart(userId, productId);
        if (itemToDelete != null)
        {
            _context.Carts.Remove(itemToDelete);
            _context.SaveChanges();
        }

    }
    public void removeItemFromWishList(string userId, int productId)
    {
        var itemToDelete = getProductFromWishList(userId, productId);
        if (itemToDelete != null)
        {
            _context.WishLists.Remove(itemToDelete);
            _context.SaveChanges();
        }

    }

    public int totalInCart(string id)
    {
        var carts = _context.Carts.Where(c => c.UserName == id).ToList();
        return carts.Count();
    }
    public int totalInWishList(string id)
    {
        var wishlists = _context.WishLists.Where(w => w.Id == id).ToList();
        return wishlists.Count();
    }

    // public IEnumerable<Product> search(string name)
    // {
    //     return _context.Products.Where(p => p.name == name).ToList();
    // }

    IEnumerable<Product> IUsersRepo.getProducts()
    {
        return _context.Products.OrderBy(p => p.name).ToList();
    }
    public IEnumerable<Cart> getCarts()
    {
        return _context.Carts.OrderBy(c => c.UserName).ToList();
    }
    public User? getUserByName(string name)
    {
        return _context.Users.Where(u => u.UserName == name).FirstOrDefault();
    }

    public Cart? GetCart(string id, int productId)
    {
        IQueryable<Cart> query = _context.Carts;
        query = query.Where(c => c.UserName == id);
        query = query.Where(c => c.ProductId == productId);
        return query.FirstOrDefault();
    }
    public Product? GetProductById(int id)
    {
        return _context.Products.Where(p => p.ProductId == id).FirstOrDefault();
    }
}

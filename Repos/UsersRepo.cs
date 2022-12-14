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

    // public void AddtoCart(int userId, int productId)
    // {
    //     // var cart = new Cart(userId, productId);
    //     // _context.Carts.Add(cart);
    //     // _context.SaveChanges();
    // }
    // public void AddtoWishList(int userId, int productId)
    // {
    //     // var wishlist = new Cart(userId, productId);
    //     // _context.Carts.Add(wishlist);
    //     // _context.SaveChanges();
    // }
    // // public void updateEmail(int id, string mail)
    // // {
    // //     User? user = _context.Users.Find(id);
    // //     if (user != null)
    // //     {
    // //         user.email = mail;
    // //         _context.SaveChanges();
    // //     }



    // // }
    // // public void updatePassword(int id, string pass)
    // // {
    // //     User? user = _context.Users.Find(id);
    // //     if (user != null)
    // //     {
    // //         user.password = pass;
    // //         _context.SaveChanges();
    // //     }

    // // }
    // // public void updatePhoneNumber(int id, int phone)
    // // {
    // //     User? user = _context.Users.Find(id);
    // //     if (user != null)
    // //     {
    // //         user.phone = phone;
    // //         _context.SaveChanges();
    // //     }

    // // }
    // public Cart? getProductFromCart(int userId, int productId)
    // {
    //     // Cart? cart = _context.Carts.Where(u => (u.UserId == userId && u.ProductId == productId)).FirstOrDefault();
    //     // return cart;

    // }
    // public void removeItem(int userId, int productId)
    // {
    //     // var itemToDelete = getProductFromCart(userId, productId);
    //     // if (itemToDelete != null)
    //     // {
    //     //     _context.Carts.Remove(itemToDelete);
    //     //     _context.SaveChanges();
    //     // }

    // }

    // public int totalInCart(int id)
    // {
    //     // var carts = _context.Carts.Where(c => c.UserId == id).ToList();
    //     // return carts.Count();
    // }
    // public int totalInWishList(int id)
    // {
    //     // var wishlists = _context.WishLists.Where(w => w.UserId == id).ToList();
    //     // return wishlists.Count();
    // }

    // public IEnumerable<Product> search(string name)
    // {
    //     return _context.Products.Where(p => p.name == name).ToList();
    // }

    // IEnumerable<Product> IUsersRepo.getProducts()
    // {
    //     return _context.Products.OrderBy(p => p.name).ToList();
    // }

}

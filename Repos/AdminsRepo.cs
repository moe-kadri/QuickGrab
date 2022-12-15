using _278Project.Data;
using _278Project.Models;
namespace _278Project.Repos;

public class AdminsRepo : IAdminsRepo
{
    private readonly AppDbContext _context;

    public AdminsRepo(AppDbContext context)
    {
        _context = context;
    }
    public void AddProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }
    public void RemoveProduct(Product product)
    {
        _context.Products.Remove(product);
        _context.SaveChanges();

    }

    public void updateProductPrice(int productId, int price)
    {
        var product = _context.Products.Find(productId);
        if (product != null)
        {
            product.price = price;
            _context.SaveChanges();
        }
    }
    public void updateProductQuantity(int productId, int quantity)
    {
        var product = _context.Products.Find(productId);
        if (product != null)
        {
            product.quantity = quantity;
            _context.SaveChanges();
        }
    }
    public void updateProductPromotion(int productId, bool promotion)
    {
        var product = _context.Products.Find(productId);
        if (product != null)
        {
            product.is_promoted = promotion;
            _context.SaveChanges();
        }
    }
    public void updateProductBestSeller(int productId, bool bestSeller)
    {
        var product = _context.Products.Find(productId);
        if (product != null)
        {
            product.is_best_seller = bestSeller;
            _context.SaveChanges();
        }
    }


    public Product? GetProductById(int id)
    {
        return _context.Products.Find(id);
    }
    public void RemoveOrder(int orderId)
    {
        var order = _context.Orders.Find(orderId);
        if (order != null)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }


    }
    IEnumerable<Product> IAdminsRepo.getProducts()
    {
        return _context.Products.OrderBy(p => p.name).ToList();
    }
}
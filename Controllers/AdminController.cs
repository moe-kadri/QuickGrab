using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using _278Project.Models;
using _278Project.Repos;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly IAdminsRepo _adminsRepo;
    public AdminController(IAdminsRepo adminsRepo)
    {
        _adminsRepo = adminsRepo;
    }
    public IActionResult Index()
    {
        var products = _adminsRepo.getProducts();
        var disp = new ProductViewModel { };
        disp.Products = products;
        return View(disp);
    }

    [HttpGet]
    public IActionResult AddProduct()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddProduct(Product product)
    {
        if (ModelState.IsValid)
        {
            _adminsRepo.AddProduct(product);
        }
        else return View("Error");
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult UpdateProduct(int id)
    {
        var item = _adminsRepo.GetProductById(id);
        return View(item);
    }
    [HttpPost]
    public IActionResult UpdateProduct(Product product)
    {
        var ProductToUpdate = _adminsRepo.GetProductById(product.ProductId);
        if (ProductToUpdate != null)
        {
            _adminsRepo.updateProductBestSeller(ProductToUpdate.ProductId, product.is_best_seller);
            _adminsRepo.updateProductPromotion(ProductToUpdate.ProductId, product.is_promoted);
            _adminsRepo.updateProductPrice(ProductToUpdate.ProductId, product.price);
            _adminsRepo.updateProductQuantity(ProductToUpdate.ProductId, product.quantity);
        }
        return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult Delete(Product product)
    {
        var ProductToDelete = _adminsRepo.GetProductById(product.ProductId);
        if (ProductToDelete != null) _adminsRepo.RemoveProduct(ProductToDelete);

        return RedirectToAction("Index");
    }

}
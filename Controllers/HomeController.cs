using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _278Project.Models;
using _278Project.Repos;
using Microsoft.AspNetCore.Identity;

namespace _278Project.Controllers;

public class HomeController : Controller
{

    private readonly IUsersRepo _usersRepo;

    public HomeController(IUsersRepo usersRepo)
    {
        _usersRepo = usersRepo;
    }

    public IActionResult Index(Cart cart)
    {
        var products = _usersRepo.getProducts().ToList();
        var search = new Search { };

        Tuple<List<Product>, Search, Cart> disp = new Tuple<List<Product>, Search, Cart>(products, search, cart);
        return View(disp);
    }
    public IActionResult AboutUs()
    {
        return View();
    }
    public IActionResult BabyCare()
    {
        var products = _usersRepo.getProducts();
        return View(products);
    }
    public IActionResult Beauty()
    {
        var products = _usersRepo.getProducts();
        return View(products);
    }

    public IActionResult Food()
    {
        var products = _usersRepo.getProducts();
        return View(products);
    }
    public IActionResult FruitesAndVeggies()
    {
        var products = _usersRepo.getProducts();
        return View(products);
    }
    public IActionResult Gardening()
    {
        var products = _usersRepo.getProducts();
        return View(products);
    }
    public IActionResult Office()
    {
        var products = _usersRepo.getProducts();
        return View(products);
    }
    public IActionResult NewArrivals()
    {
        return View();
    }
    public IActionResult BestSellers()
    {
        return View();
    }

    public IActionResult BestDeals()
    {
        return View();
    }
    public IActionResult LogReg()
    {
        return View();
    }
    [HttpGet]
    public IActionResult ViewCart()
    {
        var carts = _usersRepo.getCarts();
        return View(carts);
    }
    [HttpGet]
    public IActionResult ShoppingCart(int id)
    {

        var item = _usersRepo.GetProductById(id);
        if (id == 0) return View("Error");
        return View(item);
    }
    [HttpPost]
    public IActionResult ShoppingCart(Cart cart)
    {
        var CartToAdd = new Cart { };
        CartToAdd.UserName = User.Identity.Name;
        CartToAdd.ProductId = 1;
        //cart.ProductId;
        if (CartToAdd != null)
        {
            _usersRepo.AddtoCart(CartToAdd);
        }
        return RedirectToAction("Index");

    }
    public IActionResult Payment()
    {
        return View();
    }

    public IActionResult PaymentConfirmation()
    {
        return View();
    }

    public IActionResult Profile()
    {
        var user = _usersRepo.getUserByName(User.Identity.Name);
        return View(user);
    }
    [HttpGet]
    public IActionResult UpdateProduct(string id)
    {
        var item = _usersRepo.getUserByName(id);
        return View(item);
    }


    public IActionResult WishList()
    {
        return View();
    }

    public IActionResult DetailsForCheckout()
    {
        return View();
    }

    public IActionResult Categories()
    {
        return Redirect(Url.Action("Index", "Home") + "#category");
    }
    [HttpPost]
    public IActionResult Search(Search search)
    {
        // string? name= search.name;
        // var disp = _usersRepo.search(name);
        var products = _usersRepo.getProducts().ToList();
        Tuple<List<Product>, Search> disp = new Tuple<List<Product>, Search>(products, search);
        return View(disp);


    }
    public IActionResult Promotions()
    {
        return Redirect(Url.Action("Index", "Home") + "#BestPromotions");
    }

    public IActionResult App()
    {
        return Redirect(Url.Action("Index", "Home") + "#download-app");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
